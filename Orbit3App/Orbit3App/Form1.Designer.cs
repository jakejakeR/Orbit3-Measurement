namespace Orbit3App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelDynamic = new System.Windows.Forms.Label();
            this.TextBoxSyncs = new System.Windows.Forms.TextBox();
            this.TextBoxInterval = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelInterval = new System.Windows.Forms.Label();
            this.labelSyncs = new System.Windows.Forms.Label();
            this.ButtonStartDynamic2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonPing = new System.Windows.Forms.Button();
            this.ButtonNotifyAdd = new System.Windows.Forms.Button();
            this.ButtonFindHotSwappable = new System.Windows.Forms.Button();
            this.ButtonListModules = new System.Windows.Forms.Button();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.TextBoxOutput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDynamic
            // 
            this.labelDynamic.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDynamic.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDynamic.Location = new System.Drawing.Point(0, 0);
            this.labelDynamic.Name = "labelDynamic";
            this.labelDynamic.Size = new System.Drawing.Size(558, 41);
            this.labelDynamic.TabIndex = 0;
            this.labelDynamic.Text = "Dynamic 2 Settings";
            this.labelDynamic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxSyncs
            // 
            this.TextBoxSyncs.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxSyncs.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxSyncs.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxSyncs.Location = new System.Drawing.Point(3, 53);
            this.TextBoxSyncs.Name = "TextBoxSyncs";
            this.TextBoxSyncs.Size = new System.Drawing.Size(273, 33);
            this.TextBoxSyncs.TabIndex = 6;
            this.TextBoxSyncs.Text = "100";
            this.TextBoxSyncs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInterval
            // 
            this.TextBoxInterval.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxInterval.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxInterval.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxInterval.Location = new System.Drawing.Point(282, 53);
            this.TextBoxInterval.Name = "TextBoxInterval";
            this.TextBoxInterval.Size = new System.Drawing.Size(273, 33);
            this.TextBoxInterval.TabIndex = 4;
            this.TextBoxInterval.Text = "0";
            this.TextBoxInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.TextBoxSyncs, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelInterval, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TextBoxInterval, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelSyncs, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(558, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInterval.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInterval.Location = new System.Drawing.Point(282, 0);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(273, 50);
            this.labelInterval.TabIndex = 5;
            this.labelInterval.Text = "Interval between syncs [ms]:";
            this.labelInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSyncs
            // 
            this.labelSyncs.AutoSize = true;
            this.labelSyncs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSyncs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSyncs.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSyncs.Location = new System.Drawing.Point(3, 0);
            this.labelSyncs.Name = "labelSyncs";
            this.labelSyncs.Size = new System.Drawing.Size(273, 50);
            this.labelSyncs.TabIndex = 0;
            this.labelSyncs.Text = "Number of syncs:";
            this.labelSyncs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonStartDynamic2
            // 
            this.ButtonStartDynamic2.BackColor = System.Drawing.Color.PaleGreen;
            this.ButtonStartDynamic2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonStartDynamic2.Font = new System.Drawing.Font("Calibri", 14F);
            this.ButtonStartDynamic2.Location = new System.Drawing.Point(0, 0);
            this.ButtonStartDynamic2.Name = "ButtonStartDynamic2";
            this.ButtonStartDynamic2.Size = new System.Drawing.Size(558, 40);
            this.ButtonStartDynamic2.TabIndex = 2;
            this.ButtonStartDynamic2.Text = "START";
            this.ButtonStartDynamic2.UseVisualStyleBackColor = false;
            this.ButtonStartDynamic2.Click += new System.EventHandler(this.ButtonStartDynamic2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ButtonStartDynamic2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(558, 40);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.labelDynamic);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(450, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 486);
            this.panel3.TabIndex = 6;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.Font = new System.Drawing.Font("Calibri", 12F);
            this.ButtonClose.Location = new System.Drawing.Point(480, 3);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 44);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.ButtonClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(450, 486);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 51);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 51);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonPing
            // 
            this.ButtonPing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPing.Font = new System.Drawing.Font("Calibri", 14F);
            this.ButtonPing.Location = new System.Drawing.Point(228, 135);
            this.ButtonPing.Name = "ButtonPing";
            this.ButtonPing.Size = new System.Drawing.Size(219, 62);
            this.ButtonPing.TabIndex = 5;
            this.ButtonPing.Text = "Ping";
            this.ButtonPing.UseVisualStyleBackColor = true;
            this.ButtonPing.Click += new System.EventHandler(this.ButtonPing_Click);
            // 
            // ButtonNotifyAdd
            // 
            this.ButtonNotifyAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNotifyAdd.Font = new System.Drawing.Font("Calibri", 14F);
            this.ButtonNotifyAdd.Location = new System.Drawing.Point(3, 135);
            this.ButtonNotifyAdd.Name = "ButtonNotifyAdd";
            this.ButtonNotifyAdd.Size = new System.Drawing.Size(219, 62);
            this.ButtonNotifyAdd.TabIndex = 4;
            this.ButtonNotifyAdd.Text = "Notify Add";
            this.ButtonNotifyAdd.UseVisualStyleBackColor = true;
            this.ButtonNotifyAdd.Click += new System.EventHandler(this.ButtonNotifyAdd_Click);
            // 
            // ButtonFindHotSwappable
            // 
            this.ButtonFindHotSwappable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonFindHotSwappable.Font = new System.Drawing.Font("Calibri", 14F);
            this.ButtonFindHotSwappable.Location = new System.Drawing.Point(228, 69);
            this.ButtonFindHotSwappable.Name = "ButtonFindHotSwappable";
            this.ButtonFindHotSwappable.Size = new System.Drawing.Size(219, 60);
            this.ButtonFindHotSwappable.TabIndex = 3;
            this.ButtonFindHotSwappable.Text = "Find Hot Swappable";
            this.ButtonFindHotSwappable.UseVisualStyleBackColor = true;
            this.ButtonFindHotSwappable.Click += new System.EventHandler(this.ButtonFindHotSwappable_Click);
            // 
            // ButtonListModules
            // 
            this.ButtonListModules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonListModules.Font = new System.Drawing.Font("Calibri", 14F);
            this.ButtonListModules.Location = new System.Drawing.Point(3, 69);
            this.ButtonListModules.Name = "ButtonListModules";
            this.ButtonListModules.Size = new System.Drawing.Size(219, 60);
            this.ButtonListModules.TabIndex = 2;
            this.ButtonListModules.Text = "List Modules";
            this.ButtonListModules.UseVisualStyleBackColor = true;
            this.ButtonListModules.Click += new System.EventHandler(this.ButtonListModules_Click);
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDisconnect.Font = new System.Drawing.Font("Calibri", 14F);
            this.ButtonDisconnect.Location = new System.Drawing.Point(228, 3);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(219, 60);
            this.ButtonDisconnect.TabIndex = 1;
            this.ButtonDisconnect.Text = "Disconnect";
            this.ButtonDisconnect.UseVisualStyleBackColor = true;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConnect.Font = new System.Drawing.Font("Calibri", 14F);
            this.ButtonConnect.Location = new System.Drawing.Point(3, 3);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(219, 60);
            this.ButtonConnect.TabIndex = 0;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // TextBoxOutput
            // 
            this.TextBoxOutput.BackColor = System.Drawing.SystemColors.MenuText;
            this.TextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxOutput.Font = new System.Drawing.Font("Calibri", 12F);
            this.TextBoxOutput.ForeColor = System.Drawing.Color.PaleGreen;
            this.TextBoxOutput.Location = new System.Drawing.Point(0, 200);
            this.TextBoxOutput.Multiline = true;
            this.TextBoxOutput.Name = "TextBoxOutput";
            this.TextBoxOutput.ReadOnly = true;
            this.TextBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxOutput.Size = new System.Drawing.Size(450, 337);
            this.TextBoxOutput.TabIndex = 1;
            this.TextBoxOutput.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonPing, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonNotifyAdd, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonFindHotSwappable, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonListModules, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonDisconnect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonConnect, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextBoxOutput);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 537);
            this.panel1.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 181);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(558, 305);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 576);
            this.Name = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDynamic;
        private System.Windows.Forms.TextBox TextBoxSyncs;
        private System.Windows.Forms.TextBox TextBoxInterval;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Label labelSyncs;
        private System.Windows.Forms.Button ButtonStartDynamic2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonPing;
        private System.Windows.Forms.Button ButtonNotifyAdd;
        private System.Windows.Forms.Button ButtonFindHotSwappable;
        private System.Windows.Forms.Button ButtonListModules;
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.TextBox TextBoxOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

