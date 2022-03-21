namespace W5_Pratikum
{
    partial class FormMateri
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
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lblHasil = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.rad_Btn_Blue = new System.Windows.Forms.RadioButton();
            this.rad_Btn_Red = new System.Windows.Forms.RadioButton();
            this.chk_Box_Aktif = new System.Windows.Forms.CheckBox();
            this.lbl_Setting = new System.Windows.Forms.Label();
            this.lbl_Koleksi = new System.Windows.Forms.Label();
            this.listBoxCollection = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(318, 500);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(272, 27);
            this.btn_Clear.TabIndex = 23;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHasil.Location = new System.Drawing.Point(318, 299);
            this.lblHasil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(0, 62);
            this.lblHasil.TabIndex = 22;
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Location = new System.Drawing.Point(318, 220);
            this.lbl_Output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(62, 20);
            this.lbl_Output.TabIndex = 21;
            this.lbl_Output.Text = "Output :";
            // 
            // rad_Btn_Blue
            // 
            this.rad_Btn_Blue.AutoSize = true;
            this.rad_Btn_Blue.Location = new System.Drawing.Point(358, 143);
            this.rad_Btn_Blue.Margin = new System.Windows.Forms.Padding(2);
            this.rad_Btn_Blue.Name = "rad_Btn_Blue";
            this.rad_Btn_Blue.Size = new System.Drawing.Size(102, 24);
            this.rad_Btn_Blue.TabIndex = 20;
            this.rad_Btn_Blue.TabStop = true;
            this.rad_Btn_Blue.Text = "Warna Biru";
            this.rad_Btn_Blue.UseVisualStyleBackColor = true;
            this.rad_Btn_Blue.CheckedChanged += new System.EventHandler(this.rad_Btn_Blue_CheckedChanged);
            // 
            // rad_Btn_Red
            // 
            this.rad_Btn_Red.AutoSize = true;
            this.rad_Btn_Red.Location = new System.Drawing.Point(358, 107);
            this.rad_Btn_Red.Margin = new System.Windows.Forms.Padding(2);
            this.rad_Btn_Red.Name = "rad_Btn_Red";
            this.rad_Btn_Red.Size = new System.Drawing.Size(118, 24);
            this.rad_Btn_Red.TabIndex = 19;
            this.rad_Btn_Red.TabStop = true;
            this.rad_Btn_Red.Text = "Warna Merah";
            this.rad_Btn_Red.UseVisualStyleBackColor = true;
            this.rad_Btn_Red.CheckedChanged += new System.EventHandler(this.rad_Btn_Red_CheckedChanged);
            // 
            // chk_Box_Aktif
            // 
            this.chk_Box_Aktif.AutoSize = true;
            this.chk_Box_Aktif.Location = new System.Drawing.Point(393, 70);
            this.chk_Box_Aktif.Margin = new System.Windows.Forms.Padding(2);
            this.chk_Box_Aktif.Name = "chk_Box_Aktif";
            this.chk_Box_Aktif.Size = new System.Drawing.Size(62, 24);
            this.chk_Box_Aktif.TabIndex = 18;
            this.chk_Box_Aktif.Text = "Aktif";
            this.chk_Box_Aktif.UseVisualStyleBackColor = true;
            // 
            // lbl_Setting
            // 
            this.lbl_Setting.AutoSize = true;
            this.lbl_Setting.Location = new System.Drawing.Point(318, 70);
            this.lbl_Setting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Setting.Name = "lbl_Setting";
            this.lbl_Setting.Size = new System.Drawing.Size(63, 20);
            this.lbl_Setting.TabIndex = 17;
            this.lbl_Setting.Text = "Setting :";
            // 
            // lbl_Koleksi
            // 
            this.lbl_Koleksi.AutoSize = true;
            this.lbl_Koleksi.Location = new System.Drawing.Point(36, 70);
            this.lbl_Koleksi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Koleksi.Name = "lbl_Koleksi";
            this.lbl_Koleksi.Size = new System.Drawing.Size(63, 20);
            this.lbl_Koleksi.TabIndex = 16;
            this.lbl_Koleksi.Text = "Koleksi :";
            // 
            // listBoxCollection
            // 
            this.listBoxCollection.FormattingEnabled = true;
            this.listBoxCollection.ItemHeight = 20;
            this.listBoxCollection.Location = new System.Drawing.Point(36, 104);
            this.listBoxCollection.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCollection.Name = "listBoxCollection";
            this.listBoxCollection.Size = new System.Drawing.Size(223, 424);
            this.listBoxCollection.TabIndex = 15;
            this.listBoxCollection.SelectedIndexChanged += new System.EventHandler(this.listBoxCollection_SelectedIndexChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(472, 14);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(90, 27);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(88, 16);
            this.txtBoxInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(367, 27);
            this.txtBoxInput.TabIndex = 13;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(36, 16);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(48, 20);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data :";
            // 
            // FormMateri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 542);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.rad_Btn_Blue);
            this.Controls.Add(this.rad_Btn_Red);
            this.Controls.Add(this.chk_Box_Aktif);
            this.Controls.Add(this.lbl_Setting);
            this.Controls.Add(this.lbl_Koleksi);
            this.Controls.Add(this.listBoxCollection);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.lblData);
            this.Name = "FormMateri";
            this.Text = "Form Materi ";
            this.Load += new System.EventHandler(this.FormMateri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.RadioButton rad_Btn_Blue;
        private System.Windows.Forms.RadioButton rad_Btn_Red;
        private System.Windows.Forms.CheckBox chk_Box_Aktif;
        private System.Windows.Forms.Label lbl_Setting;
        private System.Windows.Forms.Label lbl_Koleksi;
        private System.Windows.Forms.ListBox listBoxCollection;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Label lblData;
    }
}
