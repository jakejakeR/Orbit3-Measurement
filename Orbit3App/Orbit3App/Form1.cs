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

        public Form1()
        {

            try
            {
                Orbit = new OrbitServer();
            } catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Environment.Exit(0); // Close app if there's an init failure
            }

            InitializeComponent();
            this.Text = "Orbit3 Measurement App V" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            ConsoleOut("Hello World!");
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
                ConsoleOut("Attempting to connect Orbit...\r\n");
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

                    String AvailableNetworks = sb.ToString();
                    ConsoleOut(AvailableNetworks);
                }
                catch(Exception Ex)
                {
                    ConsoleOut("#ERROR: " + Ex.Message + "\r\n");
                }
            }
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {

        }

        private void ButtonFindHotSwappable_Click(object sender, EventArgs e)
        {

        }

        private void ButtonListModules_Click(object sender, EventArgs e)
        {

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

        
    }
}
