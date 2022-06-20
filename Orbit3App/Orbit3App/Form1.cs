using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Solartron.Orbit3;

namespace Orbit3App
{
    public partial class Form1 : Form
    {

        OrbitServer Orbit;
        const int NETINDEX = 0;
        const String NOTCONNECTED = "Not connected to Orbit\r\n";

        public Form1()
        {

            try
            {
                Orbit = new OrbitServer();
            } 
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Environment.Exit(0); // Close app if there's an init failure
            }

            InitializeComponent();
            this.Text = "Orbit3 Measurement App V" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        
        #region Buttons
        /// <summary>
        /// Carries out the measurement. Displays results and chart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStartDynamic2_Click(object sender, EventArgs e)
        {
            if (Orbit.Connected == true)
            {
                List<Module> Modules;
                ConsoleOut("\r\nDynamic 2 collection of " + ParseSyncs() + " reads\r\n");
                try
                {
                    OrbitNetwork OrbitNetwork = Orbit.Networks[NETINDEX];                                     
                   
                    if (OrbitNetwork.Dynamic2Capable)
                    {
                        Modules = DataAcquisition(OrbitNetwork);

                        PrintResults(Modules);

                        PrintMinMax(Modules);

                        GenerateChart(Modules);
                    }
                }
                catch (Exception Ex)
                {
                    // Need to ensure that speed is reset to low
                    Orbit.Networks[NETINDEX].NetSpeed = eNetSpeed.Low;
                    
                    ConsoleOut("ERROR: " + Ex.Message + "\r\n");
                }
            }
            else
            {
                ConsoleOut("Not connected to Orbit\r\n");
            }
        }


        /// <summary>
        /// Establishing connection to Orbit Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (Orbit.Connected)
            {
                ConsoleOut("Already connected to Orbit\r\n");
            }
            else
            {
                ConsoleOut("Attempting to connect to Orbit...\r\n");    
                try
                {
                    Orbit.Connect();
                    ConsoleOut("Connected to Orbit\r\n");
                    ConsoleOut("Available Networks: " + Orbit.Networks.Count + "\r\n");

                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < Orbit.Networks.Count; i++)
                    {
                        sb.Append("\t");
                        sb.AppendLine(Orbit.Networks[i].Description);
                    }

                    // Displaying networks
                    String AvailableNetworks = sb.ToString();
                    ConsoleOut(AvailableNetworks);
                }
                catch(Exception Ex)
                {
                    ConsoleOut("#ERROR: " + Ex.Message + "\r\n");
                }
            }
        }

        /// <summary>
        /// Disconnect from Orbit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            if (Orbit.Connected)
            {
                ConsoleOut("\r\nDisconnecting from Orbit...\r\n");
                Orbit.Disconnect();
                ConsoleOut("\r\nDisconnected succesfully\r\n");
            }
            else
            {
                ConsoleOut(NOTCONNECTED);
            }
        }

        /// <summary>
        /// 'Assuming' a module's Orbit identity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFindHotSwappable_Click(object sender, EventArgs e)
        {
            if (Orbit.Connected)
            {
                String ModuleDescription = Orbit.Networks[NETINDEX].Description;
                ConsoleOut("\r\nSearching for HotSwappable modules on network: " + ModuleDescription + "\r\n");

                try
                {
                    // The function returns the number of new modules added to the network
                    int modulesFound = Orbit.Networks[NETINDEX].Modules.FindHotswapped();
                    ConsoleOut("New modules on the network: " + modulesFound + "\r\n");
                    InitializeZeroing();
                }
                catch (Exception Ex)
                {
                    ConsoleOut("ERROR#: " + Ex.Message);
                }
            }
            else
            {
                ConsoleOut(NOTCONNECTED);
            }
        }

        /// <summary>
        /// Lists all modules connected to network.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonListModules_Click(object sender, EventArgs e)
        {
            if (Orbit.Connected)
            {
                int NumberOfModules = Orbit.Networks[NETINDEX].Modules.Count;
                String ModuleDescription = Orbit.Networks[NETINDEX].Description;
                ConsoleOut("\r\nNumber of connected modules to " + ModuleDescription + ": " + NumberOfModules + "\r\n\r\n");

                try
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < Orbit.Networks[NETINDEX].Modules.Count; i++)
                    {
                        sb.Append("\t");
                        sb.Append((i + 1) + ". ");
                        sb.AppendLine(Orbit.Networks[NETINDEX].Modules[i].ModuleID);
                    }

                    // Displaying modules
                    String ModulesInNetwork = sb.ToString();
                    ConsoleOut(ModulesInNetwork);
                }
                catch (Exception Ex)
                {
                    ConsoleOut("ERROR#: " + Ex.Message);
                }
            }
            else
            {
                ConsoleOut(NOTCONNECTED);
            }
        }

        /// <summary>
        /// Pings network for modules
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPing_Click(object sender, EventArgs e)
        {
            if (Orbit.Connected)
            {
                String ModuleDescription = Orbit.Networks[NETINDEX].Description;
                ConsoleOut("\r\nAttempting to ping network: " + ModuleDescription + "\r\n");

                try
                {
                    Orbit.Networks[NETINDEX].Modules.Ping();
                    InitializeZeroing();

                    ConsoleOut("\tPing complete.\r\n");
                }
                catch (Exception Ex)
                {
                    ConsoleOut("ERROR#: " + Ex.Message);
                }
            }
            else
            {
                ConsoleOut(NOTCONNECTED);
            }
        }
        /// <summary>
        /// Add a module by notifying the controllerthrough manipulation of the modules input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNotifyAdd_Click(object sender, EventArgs e)
        {
            if (Orbit.Connected)
            {
                String ModuleDescription = Orbit.Networks[NETINDEX].Description;

                if (Orbit.Networks[NETINDEX].Modules.Notifying == false)
                {
                    ConsoleOut("\r\nWaiting for module to notify on network " + ModuleDescription + "\r\n\t[Press ESCAPE to stop]\r\n");

                    try
                    {
                        bool IsModuleAdded = Orbit.Networks[NETINDEX].Modules.NotifyAddModule();

                        if (IsModuleAdded)
                        {
                            ConsoleOut("\tModule added.\r\n");
                            InitializeZeroing();
                        }
                        else
                        {
                            ConsoleOut("\tNotifyAdd stopped.\r\n");
                        }
                    }
                    catch (Exception Ex)
                    {
                        ConsoleOut("ERROR#: " + Ex.Message);
                    }
                }
                else
                {
                    ConsoleOut("Already Notifying on network " + ModuleDescription + "\r\n\t[Press ESCAPE to stop]\r\n");
                }
                
            }
            else
            {
                ConsoleOut(NOTCONNECTED);
            }
        }

        /// <summary>
        /// Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        /// <summary>
        /// Display message in TextBoxOutput
        /// </summary>
        /// <param name="consoleMessage">string appended to TextBox</param>
        private void ConsoleOut(string consoleMessage)
        {
            TextBoxOutput.AppendText(consoleMessage);
        }


        /// <summary>
        /// Update the zero array (dependent on the number of module connected).
        /// </summary>
        private void InitializeZeroing()
        {
            ArrayOfReadingInCounts = new int[Orbit.Networks[NETINDEX].Modules.Count];
            ArrayOfReadingInUnits = new double[Orbit.Networks[NETINDEX].Modules.Count];
        }

        private int[] ArrayOfReadingInCounts;
        private double[] ArrayOfReadingInUnits;


        #region Data acauisition and chart

        /// <summary>
        /// Changes network speed to ultraHigh.
        /// Configures dynamic2 on the networks, enables, prepares and carries out a collection of syncs.
        /// Resets the speed back to low.
        /// </summary>
        /// <param name="OrbitNetwork"></param>
        /// <returns>List of modules with their names and reads arrays</returns>
        private List<Module> DataAcquisition(OrbitNetwork OrbitNetwork)
        {
            // Set speed to UltraHigh
            OrbitNetwork.NetSpeed = eNetSpeed.UltraHigh;
            ConsoleOut(OrbitNetwork.Description + "'s network speed changed: " + OrbitNetwork.NetSpeed + "\r\n");

            // Network configuration
            OrbitNetwork.Dynamic.DynamicRate = eDynamicRate.Dynamic2Custom;
            OrbitNetwork.Dynamic.NumberOfModules = Orbit.Networks[NETINDEX].Modules.Count;
            OrbitNetwork.Dynamic.CollectionSize = ParseSyncs();
            OrbitNetwork.Dynamic.DynamicInterval = ParseInterval();
            OrbitNetwork.Dynamic.DynamicMode = eDynamicMode.Normal;

            ConsoleOut("Dynamic 2 configuration:\r\n" +
                "\tRate: " + OrbitNetwork.Dynamic.DynamicRate + "\r\n" +
                "\tNumber of Modules: " + OrbitNetwork.Dynamic.NumberOfModules + "\r\n" +
                "\tNumber of Syncs: " + OrbitNetwork.Dynamic.CollectionSize + "\r\n" +
                "\tInterval: " + OrbitNetwork.Dynamic.DynamicInterval / 1000 + " [ms]\r\n" +
                "\tDynamic Mode: " + OrbitNetwork.Dynamic.DynamicMode + "\r\n");

            // Enable Dynamic and prepare network
            OrbitNetwork.Dynamic.Enabled = true;
            ConsoleOut("\t" + OrbitNetwork.Description + "Dynamic 2 Enabled: " + OrbitNetwork.Dynamic.Enabled + "\r\n");

            OrbitNetwork.Dynamic.Prepare();
            ConsoleOut("\t" + OrbitNetwork.Description + "Dynamic 2 Prepared\r\n");

            // START!
            Orbit.StartAllDynamic();
            ConsoleOut("\tDynamic 2 collection started...\r\n");

            while (Orbit.DynamicInProgress)
            {
                Thread.Sleep(100);
            }
            ConsoleOut("\tDynamic 2 collection complete.\r\n\r\n");

            // Disable Dynamic
            OrbitNetwork.Dynamic.Enabled = false;

            // Set speed to Low
            OrbitNetwork.NetSpeed = eNetSpeed.Low;
            ConsoleOut(OrbitNetwork.Description + "'s network speed changed: " + OrbitNetwork.NetSpeed + "\r\n");

            // Check if error occured
            ConsoleOut(String.Format("Dynamic Error Value: {0}",
                Orbit.GetErrorString((int)OrbitNetwork.Dynamic.DynamicData.CollectionStatus)));

            int ReadCount = OrbitNetwork.Dynamic.DynamicData.ReadingCount;
            int ModuleCount = OrbitNetwork.Dynamic.DynamicData.ModuleCount;
            OrbitDynamicData DynamicData = OrbitNetwork.Dynamic.DynamicData;

            List<Module> Modules = new List<Module>(ModuleCount);

            // Add new module to list and set its name and array of reads
            for (int ModuleIndex = 0; ModuleIndex < ModuleCount; ModuleIndex++)
            {
                Modules.Add(new Module(ReadCount));
                Modules[ModuleIndex].Name = Orbit.Networks[NETINDEX].Modules[ModuleIndex].ModuleID;

                for (int BlockIndex = 0; BlockIndex < ReadCount; BlockIndex++)
                {
                    Modules[ModuleIndex].Reads[BlockIndex] = DynamicData[ModuleIndex, BlockIndex];
                }
            }

            return Modules;
        }

        /// <summary>
        /// Displays results of dynamic2 collection in text box.
        /// </summary>
        /// <param name="modules">List of modules from which results are displayed.</param>
        private void PrintResults(List<Module> modules)
        {
            String Headings = "\r\nRead#\t";
            String Results = string.Empty;
            int ReadCount = modules[0].Reads.Length;

            foreach (Module module in modules)
            {
                Headings += module.Name + "\t";
            }

            for (int i = 0; i < ReadCount; i++)
            {
                Results += (i + 1) + "\t";
                foreach (Module module in modules)
                {
                    Results += string.Format("{0:0.000000}", module.Reads[i]) + "\t\t";
                }
                Results += "\r\n";
            }

            ConsoleOut(Headings + "\r\n");
            ConsoleOut(Results + "\r\n");
        }

        /// <summary>
        /// Displays Min, Max and Average results of dynamic2 collection in text box.
        /// </summary>
        /// <param name="modules"></param>
        private void PrintMinMax(List<Module> modules)
        {
            String Headings = "\r\nModule:" + "\t\tMin:" + "\t\tMax:" + "\t\tAvg:";
            String MinMaxVal = string.Empty;

            foreach (Module module in modules)
            {
                MinMaxVal += module.Name + "\t" +
                    string.Format("{0:0.000000}", module.Reads.Min()) + "\t\t" +
                    string.Format("{0:0.000000}", module.Reads.Max()) + "\t\t" +
                    string.Format("{0:0.000000}", module.Reads.Average()) + "\r\n";
            }

            ConsoleOut(Headings + "\r\n");
            ConsoleOut(MinMaxVal + "\r\n");
        }

        /// <summary>
        /// Generates a chart based on the setup.
        /// </summary>
        /// <param name="modules"></param>
        private void GenerateChart(List<Module> modules)
        {
            ChartSetup();
            foreach (Module module in modules)
            {
                AddSeriesToChart(module);
            }
        }

        /// <summary>
        /// Adding series to chart by getting the array of results from Module.
        /// </summary>
        /// <param name="module"></param>
        private void AddSeriesToChart(Module module)
        {
            chart1.Series.Add(new Series(module.Name));
            chart1.Series.FindByName(module.Name).Points.DataBindY(module.Reads);
            chart1.Series.FindByName(module.Name).ChartType = SeriesChartType.FastLine;
            chart1.Series.FindByName(module.Name).BorderWidth = 2;
        }

        /// <summary>
        /// Chart settings.
        /// </summary>
        private void ChartSetup()
        {
            chart1.Series.Clear();
            chart1.ResetAutoValues();
            chart1.Titles.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Reading";
            chart1.ChartAreas[0].AxisY.Title = "Results";
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Trebuchet MS", 10F, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Trebuchet MS", 10F, FontStyle.Bold);

            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular);

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = ParseSyncs();
            //chart1.ChartAreas[0].AxisX.Interval = 5;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = true;
            //chart1.ChartAreas[0].AxisY.MinorGrid.Interval = 1;
            chart1.ChartAreas[0].AxisX.MinorGrid.LineDashStyle = ChartDashStyle.Solid;
            chart1.ChartAreas[0].AxisX.MinorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.DarkGray;

            chart1.ChartAreas[0].AxisY.Interval = 0.5;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisY.MinorGrid.Interval = 0.5;
            chart1.ChartAreas[0].AxisY.MinorGrid.LineDashStyle = ChartDashStyle.Solid;
            chart1.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DarkGray;
        }

        #endregion

        #region Private helpers

        /// <summary>
        /// Parses user input to value of interval between readings
        /// </summary>
        /// <returns></returns>
        private int ParseInterval()
        {
            try
            {
                // Get user input
                var UserInput = this.TextBoxInterval.Text;

                // Remove all spaces
                UserInput = UserInput.Replace(" ", "");

                // Parse String input to int
                int interval = Int32.Parse(UserInput) * 1000; // need to provice [ms] rather than [us]
                int lowerLimit = 256;
                int upperLimit = 30000000;
                if ((interval < lowerLimit || interval > upperLimit) && interval != 0)
                {
                    MessageBox.Show("Interval is out of range.");
                    return -1;
                }
                else return interval;
            }
            catch (Exception)
            {
                MessageBox.Show("Interval: Wrong input.");
                return -1;
            }
        }

        /// <summary>
        /// Parses user input to value of number of readings (collection size)
        /// </summary>
        /// <returns></returns>
        private int ParseSyncs()
        {
            try
            {
                // Get user input
                var UserInput = this.TextBoxSyncs.Text;

                // Remove all spaces
                UserInput = UserInput.Replace(" ", "");

                // Parse String input to int
                int collection = Int32.Parse(UserInput);
                if (collection < 1)
                {
                    MessageBox.Show("You can't have zero syncs.");
                    return -1;
                }
                else return collection;
            }
            catch (Exception)
            {
                MessageBox.Show("Syncs: Wrong input.");
                return -1;
            }
        }

        #endregion
    }
}