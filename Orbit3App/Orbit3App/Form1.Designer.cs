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
            this.labelDynamic = new System.Windows.Forms.Label();
            this.tbSyncs = new System.Windows.Forms.TextBox();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelInterval = new System.Windows.Forms.Label();
            this.labelSyncs = new System.Windows.Forms.Label();
            this.buttonStartDynamic2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPing = new System.Windows.Forms.Button();
            this.buttonNotifyAdd = new System.Windows.Forms.Button();
            this.buttonFindHotSwappable = new System.Windows.Forms.Button();
            this.buttonListModules = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // tbSyncs
            // 
            this.tbSyncs.BackColor = System.Drawing.SystemColors.Window;
            this.tbSyncs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSyncs.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSyncs.Location = new System.Drawing.Point(3, 53);
            this.tbSyncs.Name = "tbSyncs";
            this.tbSyncs.Size = new System.Drawing.Size(273, 33);
            this.tbSyncs.TabIndex = 6;
            this.tbSyncs.Text = "100";
            this.tbSyncs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbInterval
            // 
            this.tbInterval.BackColor = System.Drawing.SystemColors.Window;
            this.tbInterval.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbInterval.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbInterval.Location = new System.Drawing.Point(282, 53);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(273, 33);
            this.tbInterval.TabIndex = 4;
            this.tbInterval.Text = "0";
            this.tbInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tbSyncs, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelInterval, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbInterval, 1, 1);
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
            // buttonStartDynamic2
            // 
            this.buttonStartDynamic2.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonStartDynamic2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStartDynamic2.Font = new System.Drawing.Font("Calibri", 14F);
            this.buttonStartDynamic2.Location = new System.Drawing.Point(0, 0);
            this.buttonStartDynamic2.Name = "buttonStartDynamic2";
            this.buttonStartDynamic2.Size = new System.Drawing.Size(558, 40);
            this.buttonStartDynamic2.TabIndex = 2;
            this.buttonStartDynamic2.Text = "START";
            this.buttonStartDynamic2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonStartDynamic2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(558, 40);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.labelDynamic);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(450, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 486);
            this.panel3.TabIndex = 6;
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Font = new System.Drawing.Font("Calibri", 12F);
            this.bClose.Location = new System.Drawing.Point(480, 3);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 44);
            this.bClose.TabIndex = 1;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.bClose);
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
            // buttonPing
            // 
            this.buttonPing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPing.Font = new System.Drawing.Font("Calibri", 14F);
            this.buttonPing.Location = new System.Drawing.Point(228, 135);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(219, 62);
            this.buttonPing.TabIndex = 5;
            this.buttonPing.Text = "Ping";
            this.buttonPing.UseVisualStyleBackColor = true;
            // 
            // buttonNotifyAdd
            // 
            this.buttonNotifyAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNotifyAdd.Font = new System.Drawing.Font("Calibri", 14F);
            this.buttonNotifyAdd.Location = new System.Drawing.Point(3, 135);
            this.buttonNotifyAdd.Name = "buttonNotifyAdd";
            this.buttonNotifyAdd.Size = new System.Drawing.Size(219, 62);
            this.buttonNotifyAdd.TabIndex = 4;
            this.buttonNotifyAdd.Text = "Notify Add";
            this.buttonNotifyAdd.UseVisualStyleBackColor = true;
            // 
            // buttonFindHotSwappable
            // 
            this.buttonFindHotSwappable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindHotSwappable.Font = new System.Drawing.Font("Calibri", 14F);
            this.buttonFindHotSwappable.Location = new System.Drawing.Point(228, 69);
            this.buttonFindHotSwappable.Name = "buttonFindHotSwappable";
            this.buttonFindHotSwappable.Size = new System.Drawing.Size(219, 60);
            this.buttonFindHotSwappable.TabIndex = 3;
            this.buttonFindHotSwappable.Text = "Find Hot Swappable";
            this.buttonFindHotSwappable.UseVisualStyleBackColor = true;
            // 
            // buttonListModules
            // 
            this.buttonListModules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonListModules.Font = new System.Drawing.Font("Calibri", 14F);
            this.buttonListModules.Location = new System.Drawing.Point(3, 69);
            this.buttonListModules.Name = "buttonListModules";
            this.buttonListModules.Size = new System.Drawing.Size(219, 60);
            this.buttonListModules.TabIndex = 2;
            this.buttonListModules.Text = "List Modules";
            this.buttonListModules.UseVisualStyleBackColor = true;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisconnect.Font = new System.Drawing.Font("Calibri", 14F);
            this.buttonDisconnect.Location = new System.Drawing.Point(228, 3);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(219, 60);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnect.Font = new System.Drawing.Font("Calibri", 14F);
            this.buttonConnect.Location = new System.Drawing.Point(3, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(219, 60);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // tbOutput
            // 
            this.tbOutput.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOutput.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbOutput.ForeColor = System.Drawing.Color.Lime;
            this.tbOutput.Location = new System.Drawing.Point(0, 200);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutput.Size = new System.Drawing.Size(450, 337);
            this.tbOutput.TabIndex = 1;
            this.tbOutput.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonPing, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNotifyAdd, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonFindHotSwappable, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonListModules, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonDisconnect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonConnect, 0, 0);
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
            this.panel1.Controls.Add(this.tbOutput);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 537);
            this.panel1.TabIndex = 4;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDynamic;
        private System.Windows.Forms.TextBox tbSyncs;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Label labelSyncs;
        private System.Windows.Forms.Button buttonStartDynamic2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonPing;
        private System.Windows.Forms.Button buttonNotifyAdd;
        private System.Windows.Forms.Button buttonFindHotSwappable;
        private System.Windows.Forms.Button buttonListModules;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

