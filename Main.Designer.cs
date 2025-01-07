namespace Master_2
{
    partial class GcodeManipulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GcodeManipulator));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DrawArea = new System.Windows.Forms.Panel();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.chk_5 = new System.Windows.Forms.CheckBox();
            this.chk_2 = new System.Windows.Forms.CheckBox();
            this.chk_6 = new System.Windows.Forms.CheckBox();
            this.chk_3 = new System.Windows.Forms.CheckBox();
            this.chk_1 = new System.Windows.Forms.CheckBox();
            this.chk_4 = new System.Windows.Forms.CheckBox();
            this.chk_7 = new System.Windows.Forms.CheckBox();
            this.chk_8 = new System.Windows.Forms.CheckBox();
            this.chk_9 = new System.Windows.Forms.CheckBox();
            this.lbl_Placement = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenGcode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawArea
            // 
            this.DrawArea.Location = new System.Drawing.Point(12, 27);
            this.DrawArea.Name = "DrawArea";
            this.DrawArea.Size = new System.Drawing.Size(128, 134);
            this.DrawArea.TabIndex = 20;
            this.DrawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawArea_Paint);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(936, 120);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 23);
            this.btn_Modify.TabIndex = 21;
            this.btn_Modify.Text = "Modify";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // chk_5
            // 
            this.chk_5.AutoSize = true;
            this.chk_5.Location = new System.Drawing.Point(966, 80);
            this.chk_5.Name = "chk_5";
            this.chk_5.Size = new System.Drawing.Size(15, 14);
            this.chk_5.TabIndex = 24;
            this.chk_5.UseVisualStyleBackColor = true;
            // 
            // chk_2
            // 
            this.chk_2.AutoSize = true;
            this.chk_2.Location = new System.Drawing.Point(966, 60);
            this.chk_2.Name = "chk_2";
            this.chk_2.Size = new System.Drawing.Size(15, 14);
            this.chk_2.TabIndex = 25;
            this.chk_2.UseVisualStyleBackColor = true;
            // 
            // chk_6
            // 
            this.chk_6.AutoSize = true;
            this.chk_6.Location = new System.Drawing.Point(987, 80);
            this.chk_6.Name = "chk_6";
            this.chk_6.Size = new System.Drawing.Size(15, 14);
            this.chk_6.TabIndex = 26;
            this.chk_6.UseVisualStyleBackColor = true;
            // 
            // chk_3
            // 
            this.chk_3.AutoSize = true;
            this.chk_3.Location = new System.Drawing.Point(987, 60);
            this.chk_3.Name = "chk_3";
            this.chk_3.Size = new System.Drawing.Size(15, 14);
            this.chk_3.TabIndex = 27;
            this.chk_3.UseVisualStyleBackColor = true;
            // 
            // chk_1
            // 
            this.chk_1.AutoSize = true;
            this.chk_1.Location = new System.Drawing.Point(945, 60);
            this.chk_1.Name = "chk_1";
            this.chk_1.Size = new System.Drawing.Size(15, 14);
            this.chk_1.TabIndex = 28;
            this.chk_1.UseVisualStyleBackColor = true;
            // 
            // chk_4
            // 
            this.chk_4.AutoSize = true;
            this.chk_4.Location = new System.Drawing.Point(945, 80);
            this.chk_4.Name = "chk_4";
            this.chk_4.Size = new System.Drawing.Size(15, 14);
            this.chk_4.TabIndex = 29;
            this.chk_4.UseVisualStyleBackColor = true;
            // 
            // chk_7
            // 
            this.chk_7.AutoSize = true;
            this.chk_7.Location = new System.Drawing.Point(945, 100);
            this.chk_7.Name = "chk_7";
            this.chk_7.Size = new System.Drawing.Size(15, 14);
            this.chk_7.TabIndex = 30;
            this.chk_7.UseVisualStyleBackColor = true;
            // 
            // chk_8
            // 
            this.chk_8.AutoSize = true;
            this.chk_8.Location = new System.Drawing.Point(966, 100);
            this.chk_8.Name = "chk_8";
            this.chk_8.Size = new System.Drawing.Size(15, 14);
            this.chk_8.TabIndex = 31;
            this.chk_8.UseVisualStyleBackColor = true;
            // 
            // chk_9
            // 
            this.chk_9.AutoSize = true;
            this.chk_9.Location = new System.Drawing.Point(987, 100);
            this.chk_9.Name = "chk_9";
            this.chk_9.Size = new System.Drawing.Size(15, 14);
            this.chk_9.TabIndex = 32;
            this.chk_9.UseVisualStyleBackColor = true;
            // 
            // lbl_Placement
            // 
            this.lbl_Placement.AutoSize = true;
            this.lbl_Placement.Location = new System.Drawing.Point(945, 32);
            this.lbl_Placement.Name = "lbl_Placement";
            this.lbl_Placement.Size = new System.Drawing.Size(57, 13);
            this.lbl_Placement.TabIndex = 33;
            this.lbl_Placement.Text = "Placement";
            this.lbl_Placement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip.TabIndex = 58;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenGcode,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // OpenGcode
            // 
            this.OpenGcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenGcode.Name = "OpenGcode";
            this.OpenGcode.Size = new System.Drawing.Size(180, 22);
            this.OpenGcode.Text = "Open Gcode";
            this.OpenGcode.Click += new System.EventHandler(this.OpenGcode_Click_1);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // GcodeManipulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 612);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lbl_Placement);
            this.Controls.Add(this.chk_9);
            this.Controls.Add(this.chk_8);
            this.Controls.Add(this.chk_7);
            this.Controls.Add(this.chk_4);
            this.Controls.Add(this.chk_1);
            this.Controls.Add(this.chk_3);
            this.Controls.Add(this.chk_6);
            this.Controls.Add(this.chk_2);
            this.Controls.Add(this.chk_5);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.DrawArea);
            this.Name = "GcodeManipulator";
            this.Text = "GcodeManipulator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel DrawArea;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.CheckBox chk_5;
        private System.Windows.Forms.CheckBox chk_2;
        private System.Windows.Forms.CheckBox chk_6;
        private System.Windows.Forms.CheckBox chk_3;
        private System.Windows.Forms.CheckBox chk_1;
        private System.Windows.Forms.CheckBox chk_4;
        private System.Windows.Forms.CheckBox chk_7;
        private System.Windows.Forms.CheckBox chk_8;
        private System.Windows.Forms.CheckBox chk_9;
        private System.Windows.Forms.Label lbl_Placement;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenGcode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

