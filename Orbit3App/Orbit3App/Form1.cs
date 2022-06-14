using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            //ConsoleOut("Hello World!"); //TODO - delete in future (ConsoleOut test)
        }

        #region
        private void ButtonStartDynamic2_Click(object sender, EventArgs e)
        {

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
                ConsoleOut("Searching for HotSwappable modules on network: " + ModuleDescription + "\r\n");

                try
                {
                    // The function returns the number of new modules added to the network
                    int modulesFound = Orbit.Networks[NETINDEX].Modules.FindHotswapped();
                    ConsoleOut("New modules on the network: " + modulesFound + "\r\n");
                    //TODO
                    InitializeZeroing();
                }
                catch (Exception ex)
                {
                    ConsoleOut("ERROR#: " + ex.Message);
                }
            }
            else
            {
                ConsoleOut(NOTCONNECTED);
            }
        }

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
                        sb.AppendLine(Orbit.Networks[NETINDEX].Modules[i].ModuleID);
                    }

                    // Displaying modules
                    String ModulesInNetwork = sb.ToString();
                    ConsoleOut(ModulesInNetwork);
                }
                catch (Exception ex)
                {
                    ConsoleOut("ERROR#: " + ex.Message);
                }
            }
            else
            {
                ConsoleOut(NOTCONNECTED);
            }
        }

        private void ButtonPing_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNotifyAdd_Click(object sender, EventArgs e)
        {

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
        /// <exception cref="NotImplementedException"></exception>
        private void InitializeZeroing()
        {
            ArrayOfReadingInCounts = new int[Orbit.Networks[NETINDEX].Modules.Count];
            ArrayOfReadingInUnits = new double[Orbit.Networks[NETINDEX].Modules.Count];
        }

        private int[] ArrayOfReadingInCounts;
        private double[] ArrayOfReadingInUnits;


    }
}