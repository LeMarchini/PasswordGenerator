namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_Generate = new System.Windows.Forms.Button();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.tbr_size = new System.Windows.Forms.TrackBar();
            this.cbox_cLetter = new System.Windows.Forms.CheckBox();
            this.cbox_cNumber = new System.Windows.Forms.CheckBox();
            this.cbox_cSpecial = new System.Windows.Forms.CheckBox();
            this.txt_size = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.cbox_cStartUpper = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_size)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Generate
            // 
            this.bt_Generate.Location = new System.Drawing.Point(110, 286);
            this.bt_Generate.Name = "bt_Generate";
            this.bt_Generate.Size = new System.Drawing.Size(363, 55);
            this.bt_Generate.TabIndex = 0;
            this.bt_Generate.Text = "Generate";
            this.bt_Generate.UseVisualStyleBackColor = true;
            this.bt_Generate.Click += new System.EventHandler(this.bt_Generate_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pwd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_pwd.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pwd.Location = new System.Drawing.Point(12, 23);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(558, 43);
            this.txt_pwd.TabIndex = 1;
            this.txt_pwd.Text = "Click on Generate!";
            this.txt_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbr_size
            // 
            this.tbr_size.LargeChange = 11;
            this.tbr_size.Location = new System.Drawing.Point(110, 94);
            this.tbr_size.Name = "tbr_size";
            this.tbr_size.Size = new System.Drawing.Size(363, 56);
            this.tbr_size.TabIndex = 2;
            this.tbr_size.Scroll += new System.EventHandler(this.tbr_size_Scroll);
            // 
            // cbox_cLetter
            // 
            this.cbox_cLetter.AutoSize = true;
            this.cbox_cLetter.Checked = true;
            this.cbox_cLetter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbox_cLetter.Location = new System.Drawing.Point(54, 175);
            this.cbox_cLetter.Name = "cbox_cLetter";
            this.cbox_cLetter.Size = new System.Drawing.Size(130, 24);
            this.cbox_cLetter.TabIndex = 3;
            this.cbox_cLetter.Text = "Contain Letters";
            this.cbox_cLetter.UseVisualStyleBackColor = true;
            // 
            // cbox_cNumber
            // 
            this.cbox_cNumber.AutoSize = true;
            this.cbox_cNumber.Location = new System.Drawing.Point(54, 222);
            this.cbox_cNumber.Name = "cbox_cNumber";
            this.cbox_cNumber.Size = new System.Drawing.Size(140, 24);
            this.cbox_cNumber.TabIndex = 4;
            this.cbox_cNumber.Text = "Contain Number";
            this.cbox_cNumber.UseVisualStyleBackColor = true;
            // 
            // cbox_cSpecial
            // 
            this.cbox_cSpecial.AutoSize = true;
            this.cbox_cSpecial.Location = new System.Drawing.Point(345, 175);
            this.cbox_cSpecial.Name = "cbox_cSpecial";
            this.cbox_cSpecial.Size = new System.Drawing.Size(199, 24);
            this.cbox_cSpecial.TabIndex = 5;
            this.cbox_cSpecial.Text = "Contain Special Caracters";
            this.cbox_cSpecial.UseVisualStyleBackColor = true;
            // 
            // txt_size
            // 
            this.txt_size.AutoSize = true;
            this.txt_size.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_size.Location = new System.Drawing.Point(246, 153);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(47, 23);
            this.txt_size.TabIndex = 7;
            this.txt_size.Text = "Size:";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_size.Location = new System.Drawing.Point(291, 153);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(20, 23);
            this.lbl_size.TabIndex = 8;
            this.lbl_size.Text = "8";
            // 
            // cbox_cStartUpper
            // 
            this.cbox_cStartUpper.AutoSize = true;
            this.cbox_cStartUpper.Location = new System.Drawing.Point(345, 222);
            this.cbox_cStartUpper.Name = "cbox_cStartUpper";
            this.cbox_cStartUpper.Size = new System.Drawing.Size(170, 24);
            this.cbox_cStartUpper.TabIndex = 9;
            this.cbox_cStartUpper.Text = "Start with UpperCase";
            this.cbox_cStartUpper.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.cbox_cStartUpper);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.txt_size);
            this.Controls.Add(this.cbox_cSpecial);
            this.Controls.Add(this.cbox_cNumber);
            this.Controls.Add(this.cbox_cLetter);
            this.Controls.Add(this.tbr_size);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.bt_Generate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbr_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_Generate;
        private TextBox txt_pwd;
        private TrackBar tbr_size;
        private CheckBox cbox_cLetter;
        private CheckBox cbox_cNumber;
        private CheckBox cbox_cSpecial;
        private Label txt_size;
        private Label lbl_size;
        private CheckBox cbox_cStartUpper;
    }
}