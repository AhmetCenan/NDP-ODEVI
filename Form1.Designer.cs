namespace NPD_Deneme
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
            this.listAraclar = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.lblSayac = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.BtnFiyat = new System.Windows.Forms.Button();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.listSure = new System.Windows.Forms.ListBox();
            this.listPlaka2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTOPLAM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAraclar
            // 
            this.listAraclar.FormattingEnabled = true;
            this.listAraclar.ItemHeight = 16;
            this.listAraclar.Location = new System.Drawing.Point(10, 10);
            this.listAraclar.Name = "listAraclar";
            this.listAraclar.Size = new System.Drawing.Size(110, 708);
            this.listAraclar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.lblSayac);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(230, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(200, 148);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(141, 54);
            this.BtnSil.TabIndex = 5;
            this.BtnSil.Text = "Listeden Çıkar";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnFiyatgor_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(43, 148);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(141, 54);
            this.BtnEkle.TabIndex = 4;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(116, 90);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(151, 22);
            this.txtPlaka.TabIndex = 3;
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(363, 18);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(17, 17);
            this.lblSayac.TabIndex = 2;
            this.lblSayac.Text = "?";
            this.lblSayac.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(276, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Araç Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(132, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARACIN PLAKASI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSure);
            this.groupBox2.Controls.Add(this.BtnFiyat);
            this.groupBox2.Controls.Add(this.lblFiyat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(621, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 240);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(59, 175);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(52, 22);
            this.txtSure.TabIndex = 7;
            this.txtSure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSure_KeyPress);
            // 
            // BtnFiyat
            // 
            this.BtnFiyat.Location = new System.Drawing.Point(175, 159);
            this.BtnFiyat.Name = "BtnFiyat";
            this.BtnFiyat.Size = new System.Drawing.Size(141, 54);
            this.BtnFiyat.TabIndex = 6;
            this.BtnFiyat.Text = "Fiyat Gör";
            this.BtnFiyat.UseVisualStyleBackColor = true;
            this.BtnFiyat.Click += new System.EventHandler(this.BtnFiyat_Click);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(170, 90);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(27, 25);
            this.lblFiyat.TabIndex = 1;
            this.lblFiyat.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(144, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "FİYAT";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(853, 655);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(141, 54);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // listSure
            // 
            this.listSure.FormattingEnabled = true;
            this.listSure.ItemHeight = 16;
            this.listSure.Location = new System.Drawing.Point(126, 10);
            this.listSure.Name = "listSure";
            this.listSure.Size = new System.Drawing.Size(98, 708);
            this.listSure.TabIndex = 7;
            // 
            // listPlaka2
            // 
            this.listPlaka2.FormattingEnabled = true;
            this.listPlaka2.ItemHeight = 16;
            this.listPlaka2.Location = new System.Drawing.Point(230, 250);
            this.listPlaka2.Name = "listPlaka2";
            this.listPlaka2.Size = new System.Drawing.Size(184, 468);
            this.listPlaka2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "DAKİKA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(503, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "TOPLAM SATIŞ...:";
            // 
            // lblTOPLAM
            // 
            this.lblTOPLAM.AutoSize = true;
            this.lblTOPLAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTOPLAM.Location = new System.Drawing.Point(776, 443);
            this.lblTOPLAM.Name = "lblTOPLAM";
            this.lblTOPLAM.Size = new System.Drawing.Size(32, 32);
            this.lblTOPLAM.TabIndex = 10;
            this.lblTOPLAM.Text = "0";
            this.lblTOPLAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(847, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTOPLAM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listPlaka2);
            this.Controls.Add(this.listSure);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listAraclar);
            this.Name = "Form1";
            this.Text = "Otopark Uygulaması";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listAraclar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ListBox listSure;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button BtnFiyat;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.ListBox listPlaka2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTOPLAM;
        private System.Windows.Forms.Label label6;
    }
}