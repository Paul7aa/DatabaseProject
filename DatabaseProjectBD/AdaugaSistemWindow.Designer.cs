namespace DatabaseProjectBD
{
    partial class AdaugaSistemWindow
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
            this.btnAnulare = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxSistemID = new System.Windows.Forms.TextBox();
            this.cBoxTip = new System.Windows.Forms.ComboBox();
            this.tBoxProducator = new System.Windows.Forms.TextBox();
            this.tBoxSerie = new System.Windows.Forms.TextBox();
            this.cBoxAnAparitie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(212, 274);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(108, 44);
            this.btnAnulare.TabIndex = 29;
            this.btnAnulare.Text = "ANULARE";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(83, 274);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(108, 44);
            this.btnAdauga.TabIndex = 28;
            this.btnAdauga.Text = "ADAUGA";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "ADAUGA SISTEM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "An aparitie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Producator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "SistemID";
            // 
            // tboxSistemID
            // 
            this.tboxSistemID.Location = new System.Drawing.Point(114, 72);
            this.tboxSistemID.Name = "tboxSistemID";
            this.tboxSistemID.ReadOnly = true;
            this.tboxSistemID.Size = new System.Drawing.Size(259, 20);
            this.tboxSistemID.TabIndex = 30;
            // 
            // cBoxTip
            // 
            this.cBoxTip.FormattingEnabled = true;
            this.cBoxTip.Items.AddRange(new object[] {
            "Desktop",
            "Laptop"});
            this.cBoxTip.Location = new System.Drawing.Point(114, 105);
            this.cBoxTip.Name = "cBoxTip";
            this.cBoxTip.Size = new System.Drawing.Size(259, 21);
            this.cBoxTip.TabIndex = 31;
            // 
            // tBoxProducator
            // 
            this.tBoxProducator.Location = new System.Drawing.Point(114, 140);
            this.tBoxProducator.Name = "tBoxProducator";
            this.tBoxProducator.Size = new System.Drawing.Size(259, 20);
            this.tBoxProducator.TabIndex = 32;
            // 
            // tBoxSerie
            // 
            this.tBoxSerie.Location = new System.Drawing.Point(114, 175);
            this.tBoxSerie.Name = "tBoxSerie";
            this.tBoxSerie.Size = new System.Drawing.Size(259, 20);
            this.tBoxSerie.TabIndex = 33;
            // 
            // cBoxAnAparitie
            // 
            this.cBoxAnAparitie.FormattingEnabled = true;
            this.cBoxAnAparitie.Location = new System.Drawing.Point(114, 213);
            this.cBoxAnAparitie.Name = "cBoxAnAparitie";
            this.cBoxAnAparitie.Size = new System.Drawing.Size(77, 21);
            this.cBoxAnAparitie.TabIndex = 34;
            // 
            // AdaugaSistemWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(397, 354);
            this.Controls.Add(this.cBoxAnAparitie);
            this.Controls.Add(this.tBoxSerie);
            this.Controls.Add(this.tBoxProducator);
            this.Controls.Add(this.cBoxTip);
            this.Controls.Add(this.tboxSistemID);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaSistemWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemDatabase - Adauga Sistem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxSistemID;
        private System.Windows.Forms.ComboBox cBoxTip;
        private System.Windows.Forms.TextBox tBoxProducator;
        private System.Windows.Forms.TextBox tBoxSerie;
        private System.Windows.Forms.ComboBox cBoxAnAparitie;
    }
}