
namespace WindowsFormsApp1
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
            this.tbxAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.checkBoxEko = new System.Windows.Forms.CheckBox();
            this.checkBoxBusiness = new System.Windows.Forms.CheckBox();
            this.cbxNereden = new System.Windows.Forms.ComboBox();
            this.cbxNereye = new System.Windows.Forms.ComboBox();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.tbxAdet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxAdSoyad
            // 
            this.tbxAdSoyad.Location = new System.Drawing.Point(256, 39);
            this.tbxAdSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxAdSoyad.Name = "tbxAdSoyad";
            this.tbxAdSoyad.Size = new System.Drawing.Size(218, 26);
            this.tbxAdSoyad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nereden:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nereye:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(262, 220);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(45, 18);
            this.lblFiyat.TabIndex = 6;
            this.lblFiyat.Text = "Fiyat";
            // 
            // checkBoxEko
            // 
            this.checkBoxEko.AutoSize = true;
            this.checkBoxEko.Location = new System.Drawing.Point(522, 58);
            this.checkBoxEko.Name = "checkBoxEko";
            this.checkBoxEko.Size = new System.Drawing.Size(98, 22);
            this.checkBoxEko.TabIndex = 7;
            this.checkBoxEko.Text = "Ekonomik";
            this.checkBoxEko.UseVisualStyleBackColor = true;
            // 
            // checkBoxBusiness
            // 
            this.checkBoxBusiness.AutoSize = true;
            this.checkBoxBusiness.Location = new System.Drawing.Point(522, 86);
            this.checkBoxBusiness.Name = "checkBoxBusiness";
            this.checkBoxBusiness.Size = new System.Drawing.Size(88, 22);
            this.checkBoxBusiness.TabIndex = 8;
            this.checkBoxBusiness.Text = "Business";
            this.checkBoxBusiness.UseVisualStyleBackColor = true;
            // 
            // cbxNereden
            // 
            this.cbxNereden.FormattingEnabled = true;
            this.cbxNereden.Items.AddRange(new object[] {
            "Istanbul"});
            this.cbxNereden.Location = new System.Drawing.Point(256, 75);
            this.cbxNereden.Name = "cbxNereden";
            this.cbxNereden.Size = new System.Drawing.Size(218, 26);
            this.cbxNereden.TabIndex = 9;
            // 
            // cbxNereye
            // 
            this.cbxNereye.FormattingEnabled = true;
            this.cbxNereye.Items.AddRange(new object[] {
            "Boston",
            "Londra",
            "NewYork"});
            this.cbxNereye.Location = new System.Drawing.Point(256, 112);
            this.cbxNereye.Name = "cbxNereye";
            this.cbxNereye.Size = new System.Drawing.Size(218, 26);
            this.cbxNereye.TabIndex = 10;
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Location = new System.Drawing.Point(358, 207);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(116, 44);
            this.btnSatinAl.TabIndex = 11;
            this.btnSatinAl.Text = "Satin Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // tbxAdet
            // 
            this.tbxAdet.Location = new System.Drawing.Point(256, 150);
            this.tbxAdet.Name = "tbxAdet";
            this.tbxAdet.Size = new System.Drawing.Size(218, 26);
            this.tbxAdet.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adet:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxAdet);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.cbxNereye);
            this.Controls.Add(this.cbxNereden);
            this.Controls.Add(this.checkBoxBusiness);
            this.Controls.Add(this.checkBoxEko);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAdSoyad);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.CheckBox checkBoxEko;
        private System.Windows.Forms.CheckBox checkBoxBusiness;
        private System.Windows.Forms.ComboBox cbxNereden;
        private System.Windows.Forms.ComboBox cbxNereye;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.TextBox tbxAdet;
        private System.Windows.Forms.Label label5;
    }
}

