namespace WinAssurance
{
    partial class frm_plainte
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbocateg = new System.Windows.Forms.ComboBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnenreg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboms = new System.Windows.Forms.ComboBox();
            this.cbojrs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboan = new System.Windows.Forms.ComboBox();
            this.txtnumpl = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Modif = new System.Windows.Forms.Button();
            this.Btn_Enreg = new System.Windows.Forms.Button();
            this.cboclient = new System.Windows.Forms.ComboBox();
            this.RtxtMsg = new System.Windows.Forms.RichTextBox();
            this.txtnumpres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbocateg);
            this.groupBox1.Controls.Add(this.btnModif);
            this.groupBox1.Controls.Add(this.btnenreg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboms);
            this.groupBox1.Controls.Add(this.cbojrs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboan);
            this.groupBox1.Controls.Add(this.txtnumpl);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.groupBox1.Location = new System.Drawing.Point(76, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposition D\'une Plainte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Categorie:";
            // 
            // cbocateg
            // 
            this.cbocateg.FormattingEnabled = true;
            this.cbocateg.Location = new System.Drawing.Point(112, 151);
            this.cbocateg.Name = "cbocateg";
            this.cbocateg.Size = new System.Drawing.Size(114, 23);
            this.cbocateg.TabIndex = 14;
            this.cbocateg.DropDown += new System.EventHandler(this.cbocateg_DropDown);
            this.cbocateg.SelectedIndexChanged += new System.EventHandler(this.cbocateg_SelectedIndexChanged);
            // 
            // btnModif
            // 
            this.btnModif.BackColor = System.Drawing.Color.Gray;
            this.btnModif.ForeColor = System.Drawing.Color.Transparent;
            this.btnModif.Location = new System.Drawing.Point(175, 200);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(117, 23);
            this.btnModif.TabIndex = 13;
            this.btnModif.Text = "&Modifier";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnenreg
            // 
            this.btnenreg.BackColor = System.Drawing.Color.Gray;
            this.btnenreg.ForeColor = System.Drawing.Color.Transparent;
            this.btnenreg.Location = new System.Drawing.Point(43, 200);
            this.btnenreg.Name = "btnenreg";
            this.btnenreg.Size = new System.Drawing.Size(117, 23);
            this.btnenreg.TabIndex = 1;
            this.btnenreg.Text = "&Enregistrer";
            this.btnenreg.UseVisualStyleBackColor = false;
            this.btnenreg.Click += new System.EventHandler(this.btnenreg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Année depot:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mois depot:";
            // 
            // cboms
            // 
            this.cboms.FormattingEnabled = true;
            this.cboms.Location = new System.Drawing.Point(112, 93);
            this.cboms.Name = "cboms";
            this.cboms.Size = new System.Drawing.Size(114, 23);
            this.cboms.TabIndex = 10;
            // 
            // cbojrs
            // 
            this.cbojrs.FormattingEnabled = true;
            this.cbojrs.Location = new System.Drawing.Point(112, 64);
            this.cbojrs.Name = "cbojrs";
            this.cbojrs.Size = new System.Drawing.Size(114, 23);
            this.cbojrs.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Jour depot:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero:";
            // 
            // cboan
            // 
            this.cboan.FormattingEnabled = true;
            this.cboan.Location = new System.Drawing.Point(112, 122);
            this.cboan.Name = "cboan";
            this.cboan.Size = new System.Drawing.Size(114, 23);
            this.cboan.TabIndex = 7;
            // 
            // txtnumpl
            // 
            this.txtnumpl.Location = new System.Drawing.Point(112, 35);
            this.txtnumpl.Name = "txtnumpl";
            this.txtnumpl.Size = new System.Drawing.Size(133, 23);
            this.txtnumpl.TabIndex = 4;
            this.txtnumpl.TextChanged += new System.EventHandler(this.txtnumpl_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Btn_Modif);
            this.groupBox2.Controls.Add(this.Btn_Enreg);
            this.groupBox2.Controls.Add(this.cboclient);
            this.groupBox2.Controls.Add(this.RtxtMsg);
            this.groupBox2.Controls.Add(this.txtnumpres);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(422, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Presentation de la Plainte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(207, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Client Plaintif";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Numero Presentaion:";
            // 
            // Btn_Modif
            // 
            this.Btn_Modif.BackColor = System.Drawing.Color.Gray;
            this.Btn_Modif.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Modif.Location = new System.Drawing.Point(194, 200);
            this.Btn_Modif.Name = "Btn_Modif";
            this.Btn_Modif.Size = new System.Drawing.Size(117, 23);
            this.Btn_Modif.TabIndex = 16;
            this.Btn_Modif.Text = "&Modifier";
            this.Btn_Modif.UseVisualStyleBackColor = false;
            this.Btn_Modif.Click += new System.EventHandler(this.Btn_Modif_Click);
            // 
            // Btn_Enreg
            // 
            this.Btn_Enreg.BackColor = System.Drawing.Color.Gray;
            this.Btn_Enreg.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Enreg.Location = new System.Drawing.Point(71, 200);
            this.Btn_Enreg.Name = "Btn_Enreg";
            this.Btn_Enreg.Size = new System.Drawing.Size(117, 23);
            this.Btn_Enreg.TabIndex = 16;
            this.Btn_Enreg.Text = "&Enregistrer";
            this.Btn_Enreg.UseVisualStyleBackColor = false;
            this.Btn_Enreg.Click += new System.EventHandler(this.Btn_Enreg_Click);
            // 
            // cboclient
            // 
            this.cboclient.FormattingEnabled = true;
            this.cboclient.Location = new System.Drawing.Point(189, 47);
            this.cboclient.Name = "cboclient";
            this.cboclient.Size = new System.Drawing.Size(122, 23);
            this.cboclient.TabIndex = 16;
            this.cboclient.DropDown += new System.EventHandler(this.cboclient_DropDown);
            // 
            // RtxtMsg
            // 
            this.RtxtMsg.Location = new System.Drawing.Point(50, 90);
            this.RtxtMsg.Name = "RtxtMsg";
            this.RtxtMsg.Size = new System.Drawing.Size(261, 84);
            this.RtxtMsg.TabIndex = 1;
            this.RtxtMsg.Text = "";
            // 
            // txtnumpres
            // 
            this.txtnumpres.Location = new System.Drawing.Point(36, 47);
            this.txtnumpres.Name = "txtnumpres";
            this.txtnumpres.Size = new System.Drawing.Size(131, 23);
            this.txtnumpres.TabIndex = 0;
            this.txtnumpres.TextChanged += new System.EventHandler(this.txtnumpres_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(244, -3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(398, 37);
            this.label8.TabIndex = 2;
            this.label8.Text = "Problematique de la Clientèle";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(652, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Menu Principal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_plainte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(804, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_plainte";
            this.Text = "frm_plainte";
            this.Load += new System.EventHandler(this.frm_plainte_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnenreg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboms;
        private System.Windows.Forms.ComboBox cbojrs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboan;
        private System.Windows.Forms.TextBox txtnumpl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbocateg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Modif;
        private System.Windows.Forms.Button Btn_Enreg;
        private System.Windows.Forms.ComboBox cboclient;
        private System.Windows.Forms.RichTextBox RtxtMsg;
        private System.Windows.Forms.TextBox txtnumpres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}