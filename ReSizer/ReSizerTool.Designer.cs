namespace ReSizer
{
    partial class ReSizerTool
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.chkUwp = new System.Windows.Forms.CheckBox();
            this.chkAndroid = new System.Windows.Forms.CheckBox();
            this.chkiOS = new System.Windows.Forms.CheckBox();
            this.lblUWPValues = new System.Windows.Forms.Label();
            this.lblUWPTitle = new System.Windows.Forms.Label();
            this.lblAndroidValue = new System.Windows.Forms.Label();
            this.lblAndroid = new System.Windows.Forms.Label();
            this.lbliOSValue = new System.Windows.Forms.Label();
            this.lbliOSTitle = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.lblBaseImagePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpiOS = new System.Windows.Forms.GroupBox();
            this.chkLstiOS = new System.Windows.Forms.CheckedListBox();
            this.chlLstAndroid = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkLstUwp = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNewImagePathValue = new System.Windows.Forms.Label();
            this.lblNewImagePath = new System.Windows.Forms.Label();
            this.txtCusomHeight = new System.Windows.Forms.TextBox();
            this.txtCustomWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomImgPath = new System.Windows.Forms.Label();
            this.btnReSizeCustom = new System.Windows.Forms.Button();
            this.btnSelectCustomImage = new System.Windows.Forms.Button();
            this.ckbHeight = new System.Windows.Forms.CheckBox();
            this.ckbWidth = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grpiOS.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbHeight);
            this.groupBox1.Controls.Add(this.ckbWidth);
            this.groupBox1.Controls.Add(this.btnResize);
            this.groupBox1.Controls.Add(this.chkUwp);
            this.groupBox1.Controls.Add(this.chkAndroid);
            this.groupBox1.Controls.Add(this.chkiOS);
            this.groupBox1.Controls.Add(this.lblUWPValues);
            this.groupBox1.Controls.Add(this.lblUWPTitle);
            this.groupBox1.Controls.Add(this.lblAndroidValue);
            this.groupBox1.Controls.Add(this.lblAndroid);
            this.groupBox1.Controls.Add(this.lbliOSValue);
            this.groupBox1.Controls.Add(this.lbliOSTitle);
            this.groupBox1.Controls.Add(this.btnSelectImage);
            this.groupBox1.Controls.Add(this.lblBaseImagePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(260, 15);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(104, 23);
            this.btnResize.TabIndex = 12;
            this.btnResize.Text = "Re-Size";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // chkUwp
            // 
            this.chkUwp.AutoSize = true;
            this.chkUwp.Location = new System.Drawing.Point(269, 71);
            this.chkUwp.Name = "chkUwp";
            this.chkUwp.Size = new System.Drawing.Size(52, 17);
            this.chkUwp.TabIndex = 11;
            this.chkUwp.Text = "UWP";
            this.chkUwp.UseVisualStyleBackColor = true;
            // 
            // chkAndroid
            // 
            this.chkAndroid.AutoSize = true;
            this.chkAndroid.Location = new System.Drawing.Point(201, 71);
            this.chkAndroid.Name = "chkAndroid";
            this.chkAndroid.Size = new System.Drawing.Size(62, 17);
            this.chkAndroid.TabIndex = 10;
            this.chkAndroid.Text = "Android";
            this.chkAndroid.UseVisualStyleBackColor = true;
            // 
            // chkiOS
            // 
            this.chkiOS.AutoSize = true;
            this.chkiOS.Location = new System.Drawing.Point(152, 71);
            this.chkiOS.Name = "chkiOS";
            this.chkiOS.Size = new System.Drawing.Size(43, 17);
            this.chkiOS.TabIndex = 9;
            this.chkiOS.Text = "iOS";
            this.chkiOS.UseVisualStyleBackColor = true;
            // 
            // lblUWPValues
            // 
            this.lblUWPValues.AutoSize = true;
            this.lblUWPValues.Location = new System.Drawing.Point(149, 147);
            this.lblUWPValues.Name = "lblUWPValues";
            this.lblUWPValues.Size = new System.Drawing.Size(118, 13);
            this.lblUWPValues.TabIndex = 8;
            this.lblUWPValues.Text = "Base Image Path Value";
            this.lblUWPValues.Visible = false;
            // 
            // lblUWPTitle
            // 
            this.lblUWPTitle.AutoSize = true;
            this.lblUWPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUWPTitle.Location = new System.Drawing.Point(9, 147);
            this.lblUWPTitle.Name = "lblUWPTitle";
            this.lblUWPTitle.Size = new System.Drawing.Size(122, 13);
            this.lblUWPTitle.TabIndex = 7;
            this.lblUWPTitle.Text = "UWP Images Path : ";
            this.lblUWPTitle.Visible = false;
            // 
            // lblAndroidValue
            // 
            this.lblAndroidValue.AutoSize = true;
            this.lblAndroidValue.Location = new System.Drawing.Point(149, 124);
            this.lblAndroidValue.Name = "lblAndroidValue";
            this.lblAndroidValue.Size = new System.Drawing.Size(118, 13);
            this.lblAndroidValue.TabIndex = 6;
            this.lblAndroidValue.Text = "Base Image Path Value";
            this.lblAndroidValue.Visible = false;
            // 
            // lblAndroid
            // 
            this.lblAndroid.AutoSize = true;
            this.lblAndroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndroid.Location = new System.Drawing.Point(9, 124);
            this.lblAndroid.Name = "lblAndroid";
            this.lblAndroid.Size = new System.Drawing.Size(136, 13);
            this.lblAndroid.TabIndex = 5;
            this.lblAndroid.Text = "Android Images Path : ";
            this.lblAndroid.Visible = false;
            // 
            // lbliOSValue
            // 
            this.lbliOSValue.AutoSize = true;
            this.lbliOSValue.Location = new System.Drawing.Point(149, 101);
            this.lbliOSValue.Name = "lbliOSValue";
            this.lbliOSValue.Size = new System.Drawing.Size(118, 13);
            this.lbliOSValue.TabIndex = 4;
            this.lbliOSValue.Text = "Base Image Path Value";
            this.lbliOSValue.Visible = false;
            // 
            // lbliOSTitle
            // 
            this.lbliOSTitle.AutoSize = true;
            this.lbliOSTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliOSTitle.Location = new System.Drawing.Point(9, 101);
            this.lbliOSTitle.Name = "lbliOSTitle";
            this.lbliOSTitle.Size = new System.Drawing.Size(113, 13);
            this.lbliOSTitle.TabIndex = 3;
            this.lbliOSTitle.Text = "iOS Images Path : ";
            this.lbliOSTitle.Visible = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(150, 15);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(104, 23);
            this.btnSelectImage.TabIndex = 2;
            this.btnSelectImage.Text = "Select Base Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // lblBaseImagePath
            // 
            this.lblBaseImagePath.AutoSize = true;
            this.lblBaseImagePath.Location = new System.Drawing.Point(149, 46);
            this.lblBaseImagePath.Name = "lblBaseImagePath";
            this.lblBaseImagePath.Size = new System.Drawing.Size(0, 13);
            this.lblBaseImagePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Image : ";
            // 
            // grpiOS
            // 
            this.grpiOS.Controls.Add(this.chkLstiOS);
            this.grpiOS.Location = new System.Drawing.Point(13, 193);
            this.grpiOS.Margin = new System.Windows.Forms.Padding(2);
            this.grpiOS.Name = "grpiOS";
            this.grpiOS.Padding = new System.Windows.Forms.Padding(2);
            this.grpiOS.Size = new System.Drawing.Size(219, 286);
            this.grpiOS.TabIndex = 1;
            this.grpiOS.TabStop = false;
            this.grpiOS.Text = "iOS Image Sizes";
            // 
            // chkLstiOS
            // 
            this.chkLstiOS.FormattingEnabled = true;
            this.chkLstiOS.Location = new System.Drawing.Point(10, 15);
            this.chkLstiOS.Margin = new System.Windows.Forms.Padding(2);
            this.chkLstiOS.Name = "chkLstiOS";
            this.chkLstiOS.Size = new System.Drawing.Size(199, 259);
            this.chkLstiOS.TabIndex = 0;
            // 
            // chlLstAndroid
            // 
            this.chlLstAndroid.FormattingEnabled = true;
            this.chlLstAndroid.Location = new System.Drawing.Point(10, 16);
            this.chlLstAndroid.Margin = new System.Windows.Forms.Padding(2);
            this.chlLstAndroid.Name = "chlLstAndroid";
            this.chlLstAndroid.Size = new System.Drawing.Size(199, 259);
            this.chlLstAndroid.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chlLstAndroid);
            this.groupBox3.Location = new System.Drawing.Point(241, 193);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(219, 286);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Android Image Sizes";
            // 
            // chkLstUwp
            // 
            this.chkLstUwp.FormattingEnabled = true;
            this.chkLstUwp.Location = new System.Drawing.Point(10, 15);
            this.chkLstUwp.Margin = new System.Windows.Forms.Padding(2);
            this.chkLstUwp.Name = "chkLstUwp";
            this.chkLstUwp.Size = new System.Drawing.Size(199, 259);
            this.chkLstUwp.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkLstUwp);
            this.groupBox4.Location = new System.Drawing.Point(471, 193);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(219, 286);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UWP Image Sizes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNewImagePathValue);
            this.groupBox2.Controls.Add(this.lblNewImagePath);
            this.groupBox2.Controls.Add(this.txtCusomHeight);
            this.groupBox2.Controls.Add(this.txtCustomWidth);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblCustomImgPath);
            this.groupBox2.Controls.Add(this.btnReSizeCustom);
            this.groupBox2.Controls.Add(this.btnSelectCustomImage);
            this.groupBox2.Location = new System.Drawing.Point(392, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(298, 168);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Custom Size Icon";
            // 
            // lblNewImagePathValue
            // 
            this.lblNewImagePathValue.AutoSize = true;
            this.lblNewImagePathValue.Location = new System.Drawing.Point(111, 104);
            this.lblNewImagePathValue.Name = "lblNewImagePathValue";
            this.lblNewImagePathValue.Size = new System.Drawing.Size(118, 13);
            this.lblNewImagePathValue.TabIndex = 20;
            this.lblNewImagePathValue.Text = "Base Image Path Value";
            this.lblNewImagePathValue.Visible = false;
            // 
            // lblNewImagePath
            // 
            this.lblNewImagePath.AutoSize = true;
            this.lblNewImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewImagePath.Location = new System.Drawing.Point(6, 104);
            this.lblNewImagePath.Name = "lblNewImagePath";
            this.lblNewImagePath.Size = new System.Drawing.Size(112, 13);
            this.lblNewImagePath.TabIndex = 13;
            this.lblNewImagePath.Text = "New Image Path : ";
            this.lblNewImagePath.Visible = false;
            // 
            // txtCusomHeight
            // 
            this.txtCusomHeight.Location = new System.Drawing.Point(226, 73);
            this.txtCusomHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusomHeight.Name = "txtCusomHeight";
            this.txtCusomHeight.Size = new System.Drawing.Size(63, 20);
            this.txtCusomHeight.TabIndex = 18;
            // 
            // txtCustomWidth
            // 
            this.txtCustomWidth.Location = new System.Drawing.Point(80, 73);
            this.txtCustomWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomWidth.Name = "txtCustomWidth";
            this.txtCustomWidth.Size = new System.Drawing.Size(69, 20);
            this.txtCustomWidth.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "New Height : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "New Width : ";
            // 
            // lblCustomImgPath
            // 
            this.lblCustomImgPath.AutoSize = true;
            this.lblCustomImgPath.Location = new System.Drawing.Point(6, 48);
            this.lblCustomImgPath.Name = "lblCustomImgPath";
            this.lblCustomImgPath.Size = new System.Drawing.Size(0, 13);
            this.lblCustomImgPath.TabIndex = 15;
            // 
            // btnReSizeCustom
            // 
            this.btnReSizeCustom.Location = new System.Drawing.Point(8, 136);
            this.btnReSizeCustom.Name = "btnReSizeCustom";
            this.btnReSizeCustom.Size = new System.Drawing.Size(278, 23);
            this.btnReSizeCustom.TabIndex = 14;
            this.btnReSizeCustom.Text = "Create Custom Size Icon";
            this.btnReSizeCustom.UseVisualStyleBackColor = true;
            this.btnReSizeCustom.Click += new System.EventHandler(this.btnReSizeCustom_Click);
            // 
            // btnSelectCustomImage
            // 
            this.btnSelectCustomImage.Location = new System.Drawing.Point(8, 17);
            this.btnSelectCustomImage.Name = "btnSelectCustomImage";
            this.btnSelectCustomImage.Size = new System.Drawing.Size(278, 23);
            this.btnSelectCustomImage.TabIndex = 13;
            this.btnSelectCustomImage.Text = "Select Base Image for Custom ReSize";
            this.btnSelectCustomImage.UseVisualStyleBackColor = true;
            this.btnSelectCustomImage.Click += new System.EventHandler(this.btnSelectCustomImage_Click);
            // 
            // ckbHeight
            // 
            this.ckbHeight.AutoSize = true;
            this.ckbHeight.Location = new System.Drawing.Point(11, 65);
            this.ckbHeight.Name = "ckbHeight";
            this.ckbHeight.Size = new System.Drawing.Size(85, 17);
            this.ckbHeight.TabIndex = 14;
            this.ckbHeight.Text = "Keep Height";
            this.ckbHeight.UseVisualStyleBackColor = true;
            // 
            // ckbWidth
            // 
            this.ckbWidth.AutoSize = true;
            this.ckbWidth.Checked = true;
            this.ckbWidth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbWidth.Location = new System.Drawing.Point(11, 42);
            this.ckbWidth.Name = "ckbWidth";
            this.ckbWidth.Size = new System.Drawing.Size(82, 17);
            this.ckbWidth.TabIndex = 13;
            this.ckbWidth.Text = "Keep Width";
            this.ckbWidth.UseVisualStyleBackColor = true;
            // 
            // ReSizerTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpiOS);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ReSizerTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Image ReSizer";
            this.Load += new System.EventHandler(this.ReSizerTool_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpiOS.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label lblBaseImagePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkUwp;
        private System.Windows.Forms.CheckBox chkAndroid;
        private System.Windows.Forms.CheckBox chkiOS;
        private System.Windows.Forms.Label lblUWPValues;
        private System.Windows.Forms.Label lblUWPTitle;
        private System.Windows.Forms.Label lblAndroidValue;
        private System.Windows.Forms.Label lblAndroid;
        private System.Windows.Forms.Label lbliOSValue;
        private System.Windows.Forms.Label lbliOSTitle;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.GroupBox grpiOS;
        private System.Windows.Forms.CheckedListBox chkLstiOS;
        private System.Windows.Forms.CheckedListBox chlLstAndroid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox chkLstUwp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReSizeCustom;
        private System.Windows.Forms.Button btnSelectCustomImage;
        private System.Windows.Forms.Label lblNewImagePathValue;
        private System.Windows.Forms.Label lblNewImagePath;
        private System.Windows.Forms.TextBox txtCusomHeight;
        private System.Windows.Forms.TextBox txtCustomWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomImgPath;
        private System.Windows.Forms.CheckBox ckbHeight;
        private System.Windows.Forms.CheckBox ckbWidth;
    }
}

