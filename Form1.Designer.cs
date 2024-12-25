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
            this.chk_OriginUp = new System.Windows.Forms.CheckBox();
            this.btnInputFile = new System.Windows.Forms.Button();
            this.lbl_BedSizeX = new System.Windows.Forms.Label();
            this.txt_BedSizeX = new System.Windows.Forms.TextBox();
            this.lbl_BedSizeY = new System.Windows.Forms.Label();
            this.txt_BedSizeY = new System.Windows.Forms.TextBox();
            this.lbl_HomeX = new System.Windows.Forms.Label();
            this.lbl_HomeY = new System.Windows.Forms.Label();
            this.txt_OffSetXMinus = new System.Windows.Forms.TextBox();
            this.txt_OffSetXPlus = new System.Windows.Forms.TextBox();
            this.lbl_OffSetXMinus = new System.Windows.Forms.Label();
            this.lbl_OffSetXPlus = new System.Windows.Forms.Label();
            this.lbl_OffSetYPlus = new System.Windows.Forms.Label();
            this.lbl_OffSetYMinus = new System.Windows.Forms.Label();
            this.txt_OffSetYPlus = new System.Windows.Forms.TextBox();
            this.txt_OffSetYMinus = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DrawArea = new System.Windows.Forms.Panel();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.chk_OriginLeft = new System.Windows.Forms.CheckBox();
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
            this.lbl_TopIdentifier = new System.Windows.Forms.Label();
            this.txt_TopIdentifier = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chk_OriginUp
            // 
            this.chk_OriginUp.AutoSize = true;
            this.chk_OriginUp.Checked = true;
            this.chk_OriginUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_OriginUp.Location = new System.Drawing.Point(1213, 103);
            this.chk_OriginUp.Margin = new System.Windows.Forms.Padding(4);
            this.chk_OriginUp.Name = "chk_OriginUp";
            this.chk_OriginUp.Size = new System.Drawing.Size(44, 20);
            this.chk_OriginUp.TabIndex = 23;
            this.chk_OriginUp.Text = "Up";
            this.chk_OriginUp.UseVisualStyleBackColor = true;
            this.chk_OriginUp.CheckStateChanged += new System.EventHandler(this.Update);
            // 
            // btnInputFile
            // 
            this.btnInputFile.Location = new System.Drawing.Point(16, 15);
            this.btnInputFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(100, 28);
            this.btnInputFile.TabIndex = 1;
            this.btnInputFile.Text = "Insert File";
            this.btnInputFile.UseVisualStyleBackColor = true;
            this.btnInputFile.Click += new System.EventHandler(this.btnInputFile_Click);
            // 
            // lbl_BedSizeX
            // 
            this.lbl_BedSizeX.AutoSize = true;
            this.lbl_BedSizeX.Location = new System.Drawing.Point(1117, 11);
            this.lbl_BedSizeX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BedSizeX.Name = "lbl_BedSizeX";
            this.lbl_BedSizeX.Size = new System.Drawing.Size(72, 16);
            this.lbl_BedSizeX.TabIndex = 2;
            this.lbl_BedSizeX.Text = "Bed Size X";
            // 
            // txt_BedSizeX
            // 
            this.txt_BedSizeX.Location = new System.Drawing.Point(1200, 7);
            this.txt_BedSizeX.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BedSizeX.Name = "txt_BedSizeX";
            this.txt_BedSizeX.Size = new System.Drawing.Size(132, 22);
            this.txt_BedSizeX.TabIndex = 3;
            this.txt_BedSizeX.Text = "220";
            this.txt_BedSizeX.TextChanged += new System.EventHandler(this.Update);
            // 
            // lbl_BedSizeY
            // 
            this.lbl_BedSizeY.AutoSize = true;
            this.lbl_BedSizeY.Location = new System.Drawing.Point(1117, 43);
            this.lbl_BedSizeY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BedSizeY.Name = "lbl_BedSizeY";
            this.lbl_BedSizeY.Size = new System.Drawing.Size(73, 16);
            this.lbl_BedSizeY.TabIndex = 4;
            this.lbl_BedSizeY.Text = "Bed Size Y";
            // 
            // txt_BedSizeY
            // 
            this.txt_BedSizeY.Location = new System.Drawing.Point(1200, 39);
            this.txt_BedSizeY.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BedSizeY.Name = "txt_BedSizeY";
            this.txt_BedSizeY.Size = new System.Drawing.Size(132, 22);
            this.txt_BedSizeY.TabIndex = 5;
            this.txt_BedSizeY.Text = "220";
            this.txt_BedSizeY.TextChanged += new System.EventHandler(this.Update);
            // 
            // lbl_HomeX
            // 
            this.lbl_HomeX.AutoSize = true;
            this.lbl_HomeX.Location = new System.Drawing.Point(1127, 75);
            this.lbl_HomeX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HomeX.Name = "lbl_HomeX";
            this.lbl_HomeX.Size = new System.Drawing.Size(53, 16);
            this.lbl_HomeX.TabIndex = 8;
            this.lbl_HomeX.Text = "Origin X";
            // 
            // lbl_HomeY
            // 
            this.lbl_HomeY.AutoSize = true;
            this.lbl_HomeY.Location = new System.Drawing.Point(1127, 107);
            this.lbl_HomeY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HomeY.Name = "lbl_HomeY";
            this.lbl_HomeY.Size = new System.Drawing.Size(54, 16);
            this.lbl_HomeY.TabIndex = 9;
            this.lbl_HomeY.Text = "Origin Y";
            // 
            // txt_OffSetXMinus
            // 
            this.txt_OffSetXMinus.Location = new System.Drawing.Point(1200, 134);
            this.txt_OffSetXMinus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_OffSetXMinus.Name = "txt_OffSetXMinus";
            this.txt_OffSetXMinus.Size = new System.Drawing.Size(132, 22);
            this.txt_OffSetXMinus.TabIndex = 10;
            this.txt_OffSetXMinus.TextChanged += new System.EventHandler(this.Update);
            // 
            // txt_OffSetXPlus
            // 
            this.txt_OffSetXPlus.Location = new System.Drawing.Point(1200, 164);
            this.txt_OffSetXPlus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_OffSetXPlus.Name = "txt_OffSetXPlus";
            this.txt_OffSetXPlus.Size = new System.Drawing.Size(132, 22);
            this.txt_OffSetXPlus.TabIndex = 11;
            this.txt_OffSetXPlus.TextChanged += new System.EventHandler(this.Update);
            // 
            // lbl_OffSetXMinus
            // 
            this.lbl_OffSetXMinus.AutoSize = true;
            this.lbl_OffSetXMinus.Location = new System.Drawing.Point(1123, 137);
            this.lbl_OffSetXMinus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OffSetXMinus.Name = "lbl_OffSetXMinus";
            this.lbl_OffSetXMinus.Size = new System.Drawing.Size(58, 16);
            this.lbl_OffSetXMinus.TabIndex = 12;
            this.lbl_OffSetXMinus.Text = "OffSet X-";
            // 
            // lbl_OffSetXPlus
            // 
            this.lbl_OffSetXPlus.AutoSize = true;
            this.lbl_OffSetXPlus.Location = new System.Drawing.Point(1121, 166);
            this.lbl_OffSetXPlus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OffSetXPlus.Name = "lbl_OffSetXPlus";
            this.lbl_OffSetXPlus.Size = new System.Drawing.Size(61, 16);
            this.lbl_OffSetXPlus.TabIndex = 13;
            this.lbl_OffSetXPlus.Text = "OffSet X+";
            // 
            // lbl_OffSetYPlus
            // 
            this.lbl_OffSetYPlus.AutoSize = true;
            this.lbl_OffSetYPlus.Location = new System.Drawing.Point(1121, 228);
            this.lbl_OffSetYPlus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OffSetYPlus.Name = "lbl_OffSetYPlus";
            this.lbl_OffSetYPlus.Size = new System.Drawing.Size(62, 16);
            this.lbl_OffSetYPlus.TabIndex = 17;
            this.lbl_OffSetYPlus.Text = "OffSet Y+";
            // 
            // lbl_OffSetYMinus
            // 
            this.lbl_OffSetYMinus.AutoSize = true;
            this.lbl_OffSetYMinus.Location = new System.Drawing.Point(1123, 198);
            this.lbl_OffSetYMinus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OffSetYMinus.Name = "lbl_OffSetYMinus";
            this.lbl_OffSetYMinus.Size = new System.Drawing.Size(59, 16);
            this.lbl_OffSetYMinus.TabIndex = 16;
            this.lbl_OffSetYMinus.Text = "OffSet Y-";
            // 
            // txt_OffSetYPlus
            // 
            this.txt_OffSetYPlus.Location = new System.Drawing.Point(1200, 224);
            this.txt_OffSetYPlus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_OffSetYPlus.Name = "txt_OffSetYPlus";
            this.txt_OffSetYPlus.Size = new System.Drawing.Size(132, 22);
            this.txt_OffSetYPlus.TabIndex = 15;
            this.txt_OffSetYPlus.TextChanged += new System.EventHandler(this.Update);
            // 
            // txt_OffSetYMinus
            // 
            this.txt_OffSetYMinus.Location = new System.Drawing.Point(1200, 194);
            this.txt_OffSetYMinus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_OffSetYMinus.Name = "txt_OffSetYMinus";
            this.txt_OffSetYMinus.Size = new System.Drawing.Size(132, 22);
            this.txt_OffSetYMinus.TabIndex = 14;
            this.txt_OffSetYMinus.TextChanged += new System.EventHandler(this.Update);
            // 
            // DrawArea
            // 
            this.DrawArea.Location = new System.Drawing.Point(16, 62);
            this.DrawArea.Margin = new System.Windows.Forms.Padding(4);
            this.DrawArea.Name = "DrawArea";
            this.DrawArea.Size = new System.Drawing.Size(171, 165);
            this.DrawArea.TabIndex = 20;
            this.DrawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawArea_Paint);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(1236, 447);
            this.btn_Modify.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(100, 28);
            this.btn_Modify.TabIndex = 21;
            this.btn_Modify.Text = "Modify";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // chk_OriginLeft
            // 
            this.chk_OriginLeft.AutoSize = true;
            this.chk_OriginLeft.Checked = true;
            this.chk_OriginLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_OriginLeft.Location = new System.Drawing.Point(1213, 75);
            this.chk_OriginLeft.Margin = new System.Windows.Forms.Padding(4);
            this.chk_OriginLeft.Name = "chk_OriginLeft";
            this.chk_OriginLeft.Size = new System.Drawing.Size(47, 20);
            this.chk_OriginLeft.TabIndex = 22;
            this.chk_OriginLeft.Text = "Left";
            this.chk_OriginLeft.UseVisualStyleBackColor = true;
            this.chk_OriginLeft.CheckStateChanged += new System.EventHandler(this.Update);
            // 
            // chk_5
            // 
            this.chk_5.AutoSize = true;
            this.chk_5.Location = new System.Drawing.Point(1247, 375);
            this.chk_5.Margin = new System.Windows.Forms.Padding(4);
            this.chk_5.Name = "chk_5";
            this.chk_5.Size = new System.Drawing.Size(15, 14);
            this.chk_5.TabIndex = 24;
            this.chk_5.UseVisualStyleBackColor = true;
            // 
            // chk_2
            // 
            this.chk_2.AutoSize = true;
            this.chk_2.Location = new System.Drawing.Point(1247, 351);
            this.chk_2.Margin = new System.Windows.Forms.Padding(4);
            this.chk_2.Name = "chk_2";
            this.chk_2.Size = new System.Drawing.Size(15, 14);
            this.chk_2.TabIndex = 25;
            this.chk_2.UseVisualStyleBackColor = true;
            // 
            // chk_6
            // 
            this.chk_6.AutoSize = true;
            this.chk_6.Location = new System.Drawing.Point(1275, 375);
            this.chk_6.Margin = new System.Windows.Forms.Padding(4);
            this.chk_6.Name = "chk_6";
            this.chk_6.Size = new System.Drawing.Size(15, 14);
            this.chk_6.TabIndex = 26;
            this.chk_6.UseVisualStyleBackColor = true;
            // 
            // chk_3
            // 
            this.chk_3.AutoSize = true;
            this.chk_3.Location = new System.Drawing.Point(1275, 351);
            this.chk_3.Margin = new System.Windows.Forms.Padding(4);
            this.chk_3.Name = "chk_3";
            this.chk_3.Size = new System.Drawing.Size(15, 14);
            this.chk_3.TabIndex = 27;
            this.chk_3.UseVisualStyleBackColor = true;
            // 
            // chk_1
            // 
            this.chk_1.AutoSize = true;
            this.chk_1.Location = new System.Drawing.Point(1219, 351);
            this.chk_1.Margin = new System.Windows.Forms.Padding(4);
            this.chk_1.Name = "chk_1";
            this.chk_1.Size = new System.Drawing.Size(15, 14);
            this.chk_1.TabIndex = 28;
            this.chk_1.UseVisualStyleBackColor = true;
            // 
            // chk_4
            // 
            this.chk_4.AutoSize = true;
            this.chk_4.Location = new System.Drawing.Point(1219, 375);
            this.chk_4.Margin = new System.Windows.Forms.Padding(4);
            this.chk_4.Name = "chk_4";
            this.chk_4.Size = new System.Drawing.Size(15, 14);
            this.chk_4.TabIndex = 29;
            this.chk_4.UseVisualStyleBackColor = true;
            // 
            // chk_7
            // 
            this.chk_7.AutoSize = true;
            this.chk_7.Location = new System.Drawing.Point(1219, 400);
            this.chk_7.Margin = new System.Windows.Forms.Padding(4);
            this.chk_7.Name = "chk_7";
            this.chk_7.Size = new System.Drawing.Size(15, 14);
            this.chk_7.TabIndex = 30;
            this.chk_7.UseVisualStyleBackColor = true;
            // 
            // chk_8
            // 
            this.chk_8.AutoSize = true;
            this.chk_8.Location = new System.Drawing.Point(1247, 400);
            this.chk_8.Margin = new System.Windows.Forms.Padding(4);
            this.chk_8.Name = "chk_8";
            this.chk_8.Size = new System.Drawing.Size(15, 14);
            this.chk_8.TabIndex = 31;
            this.chk_8.UseVisualStyleBackColor = true;
            // 
            // chk_9
            // 
            this.chk_9.AutoSize = true;
            this.chk_9.Location = new System.Drawing.Point(1275, 400);
            this.chk_9.Margin = new System.Windows.Forms.Padding(4);
            this.chk_9.Name = "chk_9";
            this.chk_9.Size = new System.Drawing.Size(15, 14);
            this.chk_9.TabIndex = 32;
            this.chk_9.UseVisualStyleBackColor = true;
            // 
            // lbl_Placement
            // 
            this.lbl_Placement.AutoSize = true;
            this.lbl_Placement.Location = new System.Drawing.Point(1219, 316);
            this.lbl_Placement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Placement.Name = "lbl_Placement";
            this.lbl_Placement.Size = new System.Drawing.Size(71, 16);
            this.lbl_Placement.TabIndex = 33;
            this.lbl_Placement.Text = "Placement";
            this.lbl_Placement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TopIdentifier
            // 
            this.lbl_TopIdentifier.AutoSize = true;
            this.lbl_TopIdentifier.Location = new System.Drawing.Point(1110, 267);
            this.lbl_TopIdentifier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TopIdentifier.Name = "lbl_TopIdentifier";
            this.lbl_TopIdentifier.Size = new System.Drawing.Size(85, 16);
            this.lbl_TopIdentifier.TabIndex = 35;
            this.lbl_TopIdentifier.Text = "Top Identifier";
            // 
            // txt_TopIdentifier
            // 
            this.txt_TopIdentifier.Location = new System.Drawing.Point(1200, 263);
            this.txt_TopIdentifier.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TopIdentifier.Name = "txt_TopIdentifier";
            this.txt_TopIdentifier.Size = new System.Drawing.Size(132, 22);
            this.txt_TopIdentifier.TabIndex = 34;
            this.txt_TopIdentifier.TextChanged += new System.EventHandler(this.txt_TopIdentifier_TextChanged);
            // 
            // GcodeManipulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 753);
            this.Controls.Add(this.lbl_TopIdentifier);
            this.Controls.Add(this.txt_TopIdentifier);
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
            this.Controls.Add(this.chk_OriginUp);
            this.Controls.Add(this.chk_OriginLeft);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.DrawArea);
            this.Controls.Add(this.lbl_OffSetYPlus);
            this.Controls.Add(this.lbl_OffSetYMinus);
            this.Controls.Add(this.txt_OffSetYPlus);
            this.Controls.Add(this.txt_OffSetYMinus);
            this.Controls.Add(this.lbl_OffSetXPlus);
            this.Controls.Add(this.lbl_OffSetXMinus);
            this.Controls.Add(this.txt_OffSetXPlus);
            this.Controls.Add(this.txt_OffSetXMinus);
            this.Controls.Add(this.lbl_HomeY);
            this.Controls.Add(this.lbl_HomeX);
            this.Controls.Add(this.txt_BedSizeY);
            this.Controls.Add(this.lbl_BedSizeY);
            this.Controls.Add(this.txt_BedSizeX);
            this.Controls.Add(this.lbl_BedSizeX);
            this.Controls.Add(this.btnInputFile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GcodeManipulator";
            this.Text = "GcodeManipulator";
            this.Load += new System.EventHandler(this.GcodeManipulator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.Label lbl_BedSizeX;
        private System.Windows.Forms.TextBox txt_BedSizeX;
        private System.Windows.Forms.Label lbl_BedSizeY;
        private System.Windows.Forms.TextBox txt_BedSizeY;
        private System.Windows.Forms.Label lbl_HomeX;
        private System.Windows.Forms.Label lbl_HomeY;
        private System.Windows.Forms.TextBox txt_OffSetXPlus;
        private System.Windows.Forms.Label lbl_OffSetXMinus;
        private System.Windows.Forms.Label lbl_OffSetXPlus;
        private System.Windows.Forms.Label lbl_OffSetYPlus;
        private System.Windows.Forms.Label lbl_OffSetYMinus;
        private System.Windows.Forms.TextBox txt_OffSetYPlus;
        private System.Windows.Forms.TextBox txt_OffSetYMinus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_OffSetXMinus;
        private System.Windows.Forms.Panel DrawArea;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.CheckBox chk_OriginLeft;
        private System.Windows.Forms.CheckBox chk_OriginUp;
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
        private System.Windows.Forms.Label lbl_TopIdentifier;
        private System.Windows.Forms.TextBox txt_TopIdentifier;
    }
}

