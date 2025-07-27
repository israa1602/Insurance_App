namespace WinAssurance
{
    partial class Frm_Assurance
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
            this.btnEnreg = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtlib = new System.Windows.Forms.TextBox();
            this.cbojrs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbomois = new System.Windows.Forms.ComboBox();
            this.cboan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbocli = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtrech = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnreg
            // 
            this.btnEnreg.Location = new System.Drawing.Point(244, 234);
            this.btnEnreg.Name = "btnEnreg";
            this.btnEnreg.Size = new System.Drawing.Size(124, 24);
            this.btnEnreg.TabIndex = 0;
            this.btnEnreg.Text = "&Enregistrer";
            this.btnEnreg.UseVisualStyleBackColor = true;
            this.btnEnreg.Click += new System.EventHandler(this.btnEnreg_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(224, 95);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(156, 23);
            this.txtnum.TabIndex = 2;
            // 
            // txtlib
            // 
            this.txtlib.Location = new System.Drawing.Point(224, 125);
            this.txtlib.Name = "txtlib";
            this.txtlib.Size = new System.Drawing.Size(156, 23);
            this.txtlib.TabIndex = 3;
            // 
            // cbojrs
            // 
            this.cbojrs.FormattingEnabled = true;
            this.cbojrs.Location = new System.Drawing.Point(223, 159);
            this.cbojrs.Name = "cbojrs";
            this.cbojrs.Size = new System.Drawing.Size(50, 23);
            this.cbojrs.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Libellé:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date de Livraison:";
            // 
            // cbomois
            // 
            this.cbomois.FormattingEnabled = true;
            this.cbomois.Location = new System.Drawing.Point(279, 159);
            this.cbomois.Name = "cbomois";
            this.cbomois.Size = new System.Drawing.Size(80, 23);
            this.cbomois.TabIndex = 8;
            // 
            // cboan
            // 
            this.cboan.FormattingEnabled = true;
            this.cboan.Location = new System.Drawing.Point(365, 159);
            this.cboan.Name = "cboan";
            this.cboan.Size = new System.Drawing.Size(106, 23);
            this.cboan.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(468, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Recherche-Numero Assurance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(218, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Livraison D\'assurance";
            // 
            // cbocli
            // 
            this.cbocli.FormattingEnabled = true;
            this.cbocli.Location = new System.Drawing.Point(224, 188);
            this.cbocli.Name = "cbocli";
            this.cbocli.Size = new System.Drawing.Size(106, 23);
            this.cbocli.TabIndex = 16;
            this.cbocli.DropDown += new System.EventHandler(this.cbocli_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(69, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Client:";
            // 
            // txtrech
            // 
            this.txtrech.Location = new System.Drawing.Point(481, 51);
            this.txtrech.Name = "txtrech";
            this.txtrech.Size = new System.Drawing.Size(156, 23);
            this.txtrech.TabIndex = 18;
            this.txtrech.TextChanged += new System.EventHandler(this.txtrech_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 24);
            this.button1.TabIndex = 19;
            this.button1.Text = "Menu Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Assurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(675, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtrech);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbocli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboan);
            this.Controls.Add(this.cbomois);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbojrs);
            this.Controls.Add(this.txtlib);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnEnreg);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Assurance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Assurance";
            this.Load += new System.EventHandler(this.Frm_Assurance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnreg;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtlib;
        private System.Windows.Forms.ComboBox cbojrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbomois;
        private System.Windows.Forms.ComboBox cboan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbocli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtrech;
        private System.Windows.Forms.Button button1;
    }
}