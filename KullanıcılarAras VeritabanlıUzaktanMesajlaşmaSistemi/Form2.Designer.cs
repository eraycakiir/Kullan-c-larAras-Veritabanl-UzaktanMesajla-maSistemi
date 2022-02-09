
namespace KullanıcılarAras_VeritabanlıUzaktanMesajlaşmaSistemi
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtaGidenktsu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewGelen = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedAlıcı = new System.Windows.Forms.MaskedTextBox();
            this.richMesaj = new System.Windows.Forms.RichTextBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewPanel = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGidenktsu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGelen)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara :";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(174, 61);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(25, 13);
            this.lblNumara.TabIndex = 1;
            this.lblNumara.Text = "Null";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(327, 61);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(46, 13);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Null Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad-Soyad :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtaGidenktsu);
            this.groupBox1.Location = new System.Drawing.Point(426, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 237);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giden Kutusu";
            // 
            // dtaGidenktsu
            // 
            this.dtaGidenktsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGidenktsu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtaGidenktsu.Location = new System.Drawing.Point(3, 16);
            this.dtaGidenktsu.Name = "dtaGidenktsu";
            this.dtaGidenktsu.Size = new System.Drawing.Size(292, 218);
            this.dtaGidenktsu.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewGelen);
            this.groupBox2.Location = new System.Drawing.Point(78, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 237);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gelen Kutusu";
            // 
            // dataGridViewGelen
            // 
            this.dataGridViewGelen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGelen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGelen.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewGelen.Name = "dataGridViewGelen";
            this.dataGridViewGelen.Size = new System.Drawing.Size(292, 218);
            this.dataGridViewGelen.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGonder);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.maskedAlıcı);
            this.groupBox3.Controls.Add(this.richMesaj);
            this.groupBox3.Controls.Add(this.txtBaslik);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dataGridViewPanel);
            this.groupBox3.Location = new System.Drawing.Point(78, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(645, 127);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mesaj Paneli";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(61, 98);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(96, 21);
            this.btnGonder.TabIndex = 7;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mesaj :";
            // 
            // maskedAlıcı
            // 
            this.maskedAlıcı.Location = new System.Drawing.Point(100, 42);
            this.maskedAlıcı.Mask = "0000";
            this.maskedAlıcı.Name = "maskedAlıcı";
            this.maskedAlıcı.Size = new System.Drawing.Size(57, 20);
            this.maskedAlıcı.TabIndex = 5;
            this.maskedAlıcı.ValidatingType = typeof(int);
            // 
            // richMesaj
            // 
            this.richMesaj.Location = new System.Drawing.Point(321, 30);
            this.richMesaj.Name = "richMesaj";
            this.richMesaj.Size = new System.Drawing.Size(280, 79);
            this.richMesaj.TabIndex = 4;
            this.richMesaj.Text = "";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(99, 72);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(58, 20);
            this.txtBaslik.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Başlık";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Alıcı";
            // 
            // dataGridViewPanel
            // 
            this.dataGridViewPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPanel.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewPanel.Name = "dataGridViewPanel";
            this.dataGridViewPanel.Size = new System.Drawing.Size(639, 108);
            this.dataGridViewPanel.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 540);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblNumara);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGidenktsu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGelen)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtaGidenktsu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewGelen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedAlıcı;
        private System.Windows.Forms.RichTextBox richMesaj;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewPanel;
    }
}