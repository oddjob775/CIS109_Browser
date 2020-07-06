namespace WebBrowser
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BackBtn = new System.Windows.Forms.ToolStripButton();
            this.FwdBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmboLocation = new System.Windows.Forms.ToolStripComboBox();
            this.GoBtn = new System.Windows.Forms.ToolStripButton();
            this.StopBtn = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackBtn,
            this.toolStripSeparator4,
            this.FwdBtn,
            this.toolStripSeparator1,
            this.cmboLocation,
            this.GoBtn,
            this.toolStripSeparator2,
            this.StopBtn,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 36);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BackBtn
            // 
            this.BackBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackBtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(56, 33);
            this.BackBtn.Text = "◄◄";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // FwdBtn
            // 
            this.FwdBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FwdBtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FwdBtn.Image = ((System.Drawing.Image)(resources.GetObject("FwdBtn.Image")));
            this.FwdBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FwdBtn.Name = "FwdBtn";
            this.FwdBtn.Size = new System.Drawing.Size(56, 33);
            this.FwdBtn.Text = "►►";
            this.FwdBtn.Click += new System.EventHandler(this.FwdBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // cmboLocation
            // 
            this.cmboLocation.DropDownWidth = 120;
            this.cmboLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboLocation.MaxDropDownItems = 20;
            this.cmboLocation.Name = "cmboLocation";
            this.cmboLocation.Size = new System.Drawing.Size(480, 36);
            this.cmboLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmboLocation_KeyDown);
            // 
            // GoBtn
            // 
            this.GoBtn.BackColor = System.Drawing.Color.Lime;
            this.GoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GoBtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBtn.ForeColor = System.Drawing.Color.White;
            this.GoBtn.Image = ((System.Drawing.Image)(resources.GetObject("GoBtn.Image")));
            this.GoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(57, 33);
            this.GoBtn.Text = "GO!";
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.Red;
            this.StopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StopBtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBtn.ForeColor = System.Drawing.Color.White;
            this.StopBtn.Image = ((System.Drawing.Image)(resources.GetObject("StopBtn.Image")));
            this.StopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(33, 33);
            this.StopBtn.Text = "Ø";
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 36);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 414);
            this.webBrowser1.TabIndex = 1;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 36);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "HTML_of_TROY";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton BackBtn;
        private System.Windows.Forms.ToolStripButton FwdBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cmboLocation;
        private System.Windows.Forms.ToolStripButton GoBtn;
        private System.Windows.Forms.ToolStripButton StopBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

