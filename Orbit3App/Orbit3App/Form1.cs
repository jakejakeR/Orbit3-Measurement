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
        public Form1()
        {
            OrbitServer Orbit;

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

        /// <summary>
        /// Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
