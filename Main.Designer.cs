using System.Drawing;
using System.Windows.Forms;

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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenGcode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStriptxtCommandShow = new System.Windows.Forms.ToolStripTextBox();
            this.cmb_COM = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.cmb_BAUD = new System.Windows.Forms.ToolStripComboBox();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button17 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button33 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Command = new System.Windows.Forms.TextBox();
            this.txtCommandShow = new System.Windows.Forms.TextBox();
            this.DrawArea = new System.Windows.Forms.Panel();
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.printerToolStripMenuItem,
            this.toolStriptxtCommandShow,
            this.cmb_COM,
            this.toolStripTextBox3,
            this.cmb_BAUD,
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1274, 27);
            this.menuStrip.TabIndex = 59;
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // OpenGcode
            // 
            this.OpenGcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenGcode.Name = "OpenGcode";
            this.OpenGcode.Size = new System.Drawing.Size(140, 22);
            this.OpenGcode.Text = "Open Gcode";
            this.OpenGcode.Click += new System.EventHandler(this.btnOpernGcode_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(137, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.testToolStripMenuItem.Text = "Test";
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
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
            // printerToolStripMenuItem
            // 
            this.printerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.printerToolStripMenuItem.Name = "printerToolStripMenuItem";
            this.printerToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.printerToolStripMenuItem.Text = "Printer";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // toolStriptxtCommandShow
            // 
            this.toolStriptxtCommandShow.BackColor = System.Drawing.SystemColors.Control;
            this.toolStriptxtCommandShow.Enabled = false;
            this.toolStriptxtCommandShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStriptxtCommandShow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStriptxtCommandShow.Name = "toolStriptxtCommandShow";
            this.toolStriptxtCommandShow.Size = new System.Drawing.Size(100, 23);
            this.toolStriptxtCommandShow.Text = "COM :";
            this.toolStriptxtCommandShow.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_COM
            // 
            this.cmb_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_COM.Name = "cmb_COM";
            this.cmb_COM.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBox3.Enabled = false;
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.Text = "BAUD :";
            this.toolStripTextBox3.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_BAUD
            // 
            this.cmb_BAUD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_BAUD.Name = "cmb_BAUD";
            this.cmb_BAUD.Size = new System.Drawing.Size(100, 23);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.btn_ConnectToPrinter_Clicked);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.btn_DisconnectPrinter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 673);
            this.panel1.TabIndex = 65;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.button17, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.button14, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button15, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button16, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(60, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 50);
            this.tableLayoutPanel3.TabIndex = 67;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button17.BackgroundImage")));
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.Location = new System.Drawing.Point(150, 0);
            this.button17.Margin = new System.Windows.Forms.Padding(0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(50, 50);
            this.button17.TabIndex = 41;
            this.button17.Text = "All";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.HomeAxis);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button14.BackgroundImage")));
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.Location = new System.Drawing.Point(0, 0);
            this.button14.Margin = new System.Windows.Forms.Padding(0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(50, 50);
            this.button14.TabIndex = 8;
            this.button14.Text = "X";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.HomeAxis);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(50, 0);
            this.button15.Margin = new System.Windows.Forms.Padding(0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 50);
            this.button15.TabIndex = 9;
            this.button15.Text = "Y";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.HomeAxis);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button16.BackgroundImage")));
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.Location = new System.Drawing.Point(100, 0);
            this.button16.Margin = new System.Windows.Forms.Padding(0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(50, 50);
            this.button16.TabIndex = 10;
            this.button16.Text = "Z";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.HomeAxis);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button10, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.button11, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.button12, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.button13, 0, 8);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(308, 77);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(39, 332);
            this.tableLayoutPanel2.TabIndex = 66;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Enabled = false;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 34);
            this.button5.TabIndex = 0;
            this.button5.Text = "Z";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(0, 34);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 34);
            this.button6.TabIndex = 1;
            this.button6.Text = "10";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(0, 68);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 34);
            this.button7.TabIndex = 2;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(0, 102);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 34);
            this.button8.TabIndex = 3;
            this.button8.Text = "0.1";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(0, 136);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 20);
            this.button9.TabIndex = 4;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Location = new System.Drawing.Point(0, 156);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(39, 34);
            this.button10.TabIndex = 5;
            this.button10.Text = "0.1";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Location = new System.Drawing.Point(0, 190);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(39, 34);
            this.button11.TabIndex = 6;
            this.button11.Text = "1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Location = new System.Drawing.Point(0, 224);
            this.button12.Margin = new System.Windows.Forms.Padding(0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 34);
            this.button12.TabIndex = 7;
            this.button12.Text = "10";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Enabled = false;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(0, 258);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(39, 34);
            this.button13.TabIndex = 8;
            this.button13.Text = "Z";
            this.button13.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 10;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.Controls.Add(this.button33, 4, 8);
            this.tableLayoutPanel5.Controls.Add(this.button18, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.button32, 4, 7);
            this.tableLayoutPanel5.Controls.Add(this.button31, 4, 6);
            this.tableLayoutPanel5.Controls.Add(this.button30, 4, 5);
            this.tableLayoutPanel5.Controls.Add(this.button29, 7, 4);
            this.tableLayoutPanel5.Controls.Add(this.button28, 6, 4);
            this.tableLayoutPanel5.Controls.Add(this.button27, 5, 4);
            this.tableLayoutPanel5.Controls.Add(this.button26, 5, 4);
            this.tableLayoutPanel5.Controls.Add(this.button25, 3, 4);
            this.tableLayoutPanel5.Controls.Add(this.button24, 2, 4);
            this.tableLayoutPanel5.Controls.Add(this.button23, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.button22, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.button21, 4, 3);
            this.tableLayoutPanel5.Controls.Add(this.button20, 4, 2);
            this.tableLayoutPanel5.Controls.Add(this.button19, 4, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(5, 70);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 10;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(332, 332);
            this.tableLayoutPanel5.TabIndex = 68;
            // 
            // button33
            // 
            this.button33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button33.Enabled = false;
            this.button33.Image = ((System.Drawing.Image)(resources.GetObject("button33.Image")));
            this.button33.Location = new System.Drawing.Point(132, 272);
            this.button33.Margin = new System.Windows.Forms.Padding(0);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(33, 34);
            this.button33.TabIndex = 69;
            this.button33.Text = "Y";
            this.button33.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.Enabled = false;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.Location = new System.Drawing.Point(132, 0);
            this.button18.Margin = new System.Windows.Forms.Padding(0);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(33, 34);
            this.button18.TabIndex = 68;
            this.button18.Text = "Y";
            this.button18.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button32.Location = new System.Drawing.Point(132, 238);
            this.button32.Margin = new System.Windows.Forms.Padding(0);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(33, 34);
            this.button32.TabIndex = 67;
            this.button32.Text = "10";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button31
            // 
            this.button31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button31.Location = new System.Drawing.Point(132, 204);
            this.button31.Margin = new System.Windows.Forms.Padding(0);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(33, 34);
            this.button31.TabIndex = 58;
            this.button31.Text = "1";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button30
            // 
            this.button30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button30.Location = new System.Drawing.Point(132, 170);
            this.button30.Margin = new System.Windows.Forms.Padding(0);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(33, 34);
            this.button30.TabIndex = 49;
            this.button30.Text = "0.1";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button29
            // 
            this.button29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button29.Enabled = false;
            this.button29.Image = ((System.Drawing.Image)(resources.GetObject("button29.Image")));
            this.button29.Location = new System.Drawing.Point(264, 136);
            this.button29.Margin = new System.Windows.Forms.Padding(0);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(33, 34);
            this.button29.TabIndex = 44;
            this.button29.Text = "X";
            this.button29.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button28.Location = new System.Drawing.Point(231, 136);
            this.button28.Margin = new System.Windows.Forms.Padding(0);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(33, 34);
            this.button28.TabIndex = 43;
            this.button28.Text = "10";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button27
            // 
            this.button27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button27.Location = new System.Drawing.Point(198, 136);
            this.button27.Margin = new System.Windows.Forms.Padding(0);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(33, 34);
            this.button27.TabIndex = 42;
            this.button27.Text = "1";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button26
            // 
            this.button26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button26.Location = new System.Drawing.Point(165, 136);
            this.button26.Margin = new System.Windows.Forms.Padding(0);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(33, 34);
            this.button26.TabIndex = 41;
            this.button26.Text = "0.1";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button25
            // 
            this.button25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button25.Location = new System.Drawing.Point(99, 136);
            this.button25.Margin = new System.Windows.Forms.Padding(0);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(33, 34);
            this.button25.TabIndex = 39;
            this.button25.Text = "0.1";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button24
            // 
            this.button24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button24.Location = new System.Drawing.Point(66, 136);
            this.button24.Margin = new System.Windows.Forms.Padding(0);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(33, 34);
            this.button24.TabIndex = 38;
            this.button24.Text = "1";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button23
            // 
            this.button23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button23.Location = new System.Drawing.Point(33, 136);
            this.button23.Margin = new System.Windows.Forms.Padding(0);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(33, 34);
            this.button23.TabIndex = 37;
            this.button23.Text = "10";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button22
            // 
            this.button22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button22.Enabled = false;
            this.button22.Image = ((System.Drawing.Image)(resources.GetObject("button22.Image")));
            this.button22.Location = new System.Drawing.Point(0, 136);
            this.button22.Margin = new System.Windows.Forms.Padding(0);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(33, 34);
            this.button22.TabIndex = 36;
            this.button22.Text = "X";
            this.button22.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button21.Location = new System.Drawing.Point(132, 102);
            this.button21.Margin = new System.Windows.Forms.Padding(0);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(33, 34);
            this.button21.TabIndex = 31;
            this.button21.Text = "0.1";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button20
            // 
            this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button20.Location = new System.Drawing.Point(132, 68);
            this.button20.Margin = new System.Windows.Forms.Padding(0);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(33, 34);
            this.button20.TabIndex = 22;
            this.button20.Text = "1";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.MoveAxis);
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.Location = new System.Drawing.Point(132, 34);
            this.button19.Margin = new System.Windows.Forms.Padding(0);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(33, 34);
            this.button19.TabIndex = 13;
            this.button19.Text = "10";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.MoveAxis);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txt_Command, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtCommandShow, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1074, 27);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 673);
            this.tableLayoutPanel4.TabIndex = 69;
            // 
            // txt_Command
            // 
            this.txt_Command.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_Command.Location = new System.Drawing.Point(10, 638);
            this.txt_Command.Margin = new System.Windows.Forms.Padding(10);
            this.txt_Command.Name = "txt_Command";
            this.txt_Command.Size = new System.Drawing.Size(180, 20);
            this.txt_Command.TabIndex = 70;
            this.txt_Command.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Command_KeyDown);
            // 
            // txtCommandShow
            // 
            this.txtCommandShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCommandShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommandShow.Location = new System.Drawing.Point(3, 3);
            this.txtCommandShow.Multiline = true;
            this.txtCommandShow.Name = "txtCommandShow";
            this.txtCommandShow.ReadOnly = true;
            this.txtCommandShow.Size = new System.Drawing.Size(194, 617);
            this.txtCommandShow.TabIndex = 69;
            // 
            // DrawArea
            // 
            this.DrawArea.Location = new System.Drawing.Point(356, 30);
            this.DrawArea.Name = "DrawArea";
            this.DrawArea.Size = new System.Drawing.Size(128, 134);
            this.DrawArea.TabIndex = 72;
            this.DrawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawArea_Paint);
            // 
            // chk_5
            // 
            this.chk_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_5.AutoSize = true;
            this.chk_5.Location = new System.Drawing.Point(1032, 81);
            this.chk_5.Name = "chk_5";
            this.chk_5.Size = new System.Drawing.Size(15, 14);
            this.chk_5.TabIndex = 79;
            this.chk_5.UseVisualStyleBackColor = true;
            this.chk_5.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chk_2
            // 
            this.chk_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_2.AutoSize = true;
            this.chk_2.Location = new System.Drawing.Point(1032, 61);
            this.chk_2.Name = "chk_2";
            this.chk_2.Size = new System.Drawing.Size(15, 14);
            this.chk_2.TabIndex = 80;
            this.chk_2.UseVisualStyleBackColor = true;
            this.chk_2.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chk_6
            // 
            this.chk_6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_6.AutoSize = true;
            this.chk_6.Location = new System.Drawing.Point(1053, 81);
            this.chk_6.Name = "chk_6";
            this.chk_6.Size = new System.Drawing.Size(15, 14);
            this.chk_6.TabIndex = 81;
            this.chk_6.UseVisualStyleBackColor = true;
            this.chk_6.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chk_3
            // 
            this.chk_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_3.AutoSize = true;
            this.chk_3.Location = new System.Drawing.Point(1053, 61);
            this.chk_3.Name = "chk_3";
            this.chk_3.Size = new System.Drawing.Size(15, 14);
            this.chk_3.TabIndex = 82;
            this.chk_3.UseVisualStyleBackColor = true;
            this.chk_3.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chk_1
            // 
            this.chk_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_1.AutoSize = true;
            this.chk_1.Location = new System.Drawing.Point(1011, 61);
            this.chk_1.Name = "chk_1";
            this.chk_1.Size = new System.Drawing.Size(15, 14);
            this.chk_1.TabIndex = 83;
            this.chk_1.UseVisualStyleBackColor = true;
            this.chk_1.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chk_4
            // 
            this.chk_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_4.AutoSize = true;
            this.chk_4.Location = new System.Drawing.Point(1011, 81);
            this.chk_4.Name = "chk_4";
            this.chk_4.Size = new System.Drawing.Size(15, 14);
            this.chk_4.TabIndex = 84;
            this.chk_4.UseVisualStyleBackColor = true;
            this.chk_4.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chk_7
            // 
            this.chk_7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_7.AutoSize = true;
            this.chk_7.Location = new System.Drawing.Point(1011, 101);
            this.chk_7.Name = "chk_7";
            this.chk_7.Size = new System.Drawing.Size(15, 14);
            this.chk_7.TabIndex = 85;
            this.chk_7.UseVisualStyleBackColor = true;
            this.chk_7.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chk_8
            // 
            this.chk_8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_8.AutoSize = true;
            this.chk_8.Location = new System.Drawing.Point(1032, 101);
            this.chk_8.Name = "chk_8";
            this.chk_8.Size = new System.Drawing.Size(15, 14);
            this.chk_8.TabIndex = 86;
            this.chk_8.UseVisualStyleBackColor = true;
            this.chk_8.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chk_9
            // 
            this.chk_9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_9.AutoSize = true;
            this.chk_9.Location = new System.Drawing.Point(1053, 101);
            this.chk_9.Name = "chk_9";
            this.chk_9.Size = new System.Drawing.Size(15, 14);
            this.chk_9.TabIndex = 87;
            this.chk_9.UseVisualStyleBackColor = true;
            this.chk_9.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // lbl_Placement
            // 
            this.lbl_Placement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Placement.AutoSize = true;
            this.lbl_Placement.Location = new System.Drawing.Point(1011, 33);
            this.lbl_Placement.Name = "lbl_Placement";
            this.lbl_Placement.Size = new System.Drawing.Size(57, 13);
            this.lbl_Placement.TabIndex = 88;
            this.lbl_Placement.Text = "Placement";
            this.lbl_Placement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(25, 25);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.MoveToCorner);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 25);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MoveToCorner);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(25, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MoveToCorner);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MoveToCorner);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1014, 150);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(50, 50);
            this.tableLayoutPanel1.TabIndex = 89;
            // 
            // btn_Modify
            // 
            this.btn_Modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Modify.Location = new System.Drawing.Point(1002, 121);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 23);
            this.btn_Modify.TabIndex = 90;
            this.btn_Modify.Text = "Modify";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // GcodeManipulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 700);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.tableLayoutPanel1);
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
            this.Controls.Add(this.DrawArea);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Name = "GcodeManipulator";
            this.Text = "GcodeManipulator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenGcode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStriptxtCommandShow;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripComboBox cmb_BAUD;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmb_COM;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox txt_Command;
        private TextBox txtCommandShow;
        private Panel DrawArea;
        private CheckBox chk_5;
        private CheckBox chk_2;
        private CheckBox chk_6;
        private CheckBox chk_3;
        private CheckBox chk_1;
        private CheckBox chk_4;
        private CheckBox chk_7;
        private CheckBox chk_8;
        private CheckBox chk_9;
        private Label lbl_Placement;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_Modify;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button32;
        private Button button31;
        private Button button30;
        private Button button29;
        private Button button28;
        private Button button27;
        private Button button26;
        private Button button25;
        private Button button24;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button17;
        private Button button14;
        private Button button15;
        private Button button16;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button18;
        private Button button33;
    }
}

