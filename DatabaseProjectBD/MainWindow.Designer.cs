namespace DatabaseProjectBD
{
    partial class MainWindow
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
            this.lblState = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.tboxCautare = new System.Windows.Forms.TextBox();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnComenzi = new System.Windows.Forms.Button();
            this.btnProduse = new System.Windows.Forms.Button();
            this.btnSisteme = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(361, 20);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(106, 26);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "COMENZI";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(31, 89);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(764, 229);
            this.dataGridView.TabIndex = 1;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(31, 336);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(116, 49);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "ADAUGA";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(448, 59);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(198, 24);
            this.btnCauta.TabIndex = 3;
            this.btnCauta.Text = "Cauta Comanda";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // tboxCautare
            // 
            this.tboxCautare.Location = new System.Drawing.Point(63, 63);
            this.tboxCautare.Name = "tboxCautare";
            this.tboxCautare.Size = new System.Drawing.Size(364, 20);
            this.tboxCautare.TabIndex = 4;
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(164, 336);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(116, 49);
            this.btnSterge.TabIndex = 5;
            this.btnSterge.Text = "STERGE";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnComenzi
            // 
            this.btnComenzi.Location = new System.Drawing.Point(-2, 416);
            this.btnComenzi.Name = "btnComenzi";
            this.btnComenzi.Size = new System.Drawing.Size(212, 50);
            this.btnComenzi.TabIndex = 6;
            this.btnComenzi.Text = "COMENZI";
            this.btnComenzi.UseVisualStyleBackColor = true;
            // 
            // btnProduse
            // 
            this.btnProduse.Location = new System.Drawing.Point(413, 416);
            this.btnProduse.Name = "btnProduse";
            this.btnProduse.Size = new System.Drawing.Size(212, 50);
            this.btnProduse.TabIndex = 8;
            this.btnProduse.Text = "PRODUSE";
            this.btnProduse.UseVisualStyleBackColor = true;
            // 
            // btnSisteme
            // 
            this.btnSisteme.Location = new System.Drawing.Point(622, 416);
            this.btnSisteme.Name = "btnSisteme";
            this.btnSisteme.Size = new System.Drawing.Size(212, 50);
            this.btnSisteme.TabIndex = 9;
            this.btnSisteme.Text = "SISTEME";
            this.btnSisteme.UseVisualStyleBackColor = true;
            // 
            // btnClienti
            // 
            this.btnClienti.Location = new System.Drawing.Point(204, 416);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(212, 50);
            this.btnClienti.TabIndex = 7;
            this.btnClienti.Text = "CLIENTI";
            this.btnClienti.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.btnSisteme);
            this.Controls.Add(this.btnProduse);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.btnComenzi);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.tboxCautare);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblState);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemDatabase - Comenzi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.TextBox tboxCautare;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnComenzi;
        private System.Windows.Forms.Button btnProduse;
        private System.Windows.Forms.Button btnSisteme;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnClienti;
    }
}

