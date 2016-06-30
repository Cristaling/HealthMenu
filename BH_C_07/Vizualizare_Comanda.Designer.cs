namespace HealthMenu
{
    partial class Vizualizare_Comanda
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
            this.Comanda_DataGridView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Comanda_text3 = new System.Windows.Forms.TextBox();
            this.Comanda_text2 = new System.Windows.Forms.TextBox();
            this.Comanda_text1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Comanda_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Comanda_DataGridView
            // 
            this.Comanda_DataGridView.AllowUserToAddRows = false;
            this.Comanda_DataGridView.AllowUserToDeleteRows = false;
            this.Comanda_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Comanda_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Comanda_DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.Comanda_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Comanda_DataGridView.Name = "Comanda_DataGridView";
            this.Comanda_DataGridView.Size = new System.Drawing.Size(787, 363);
            this.Comanda_DataGridView.TabIndex = 0;
            this.Comanda_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Comanda_DataGridView_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(410, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Pret Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total Kcal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Necesar zilnic";
            // 
            // Comanda_text3
            // 
            this.Comanda_text3.Location = new System.Drawing.Point(410, 423);
            this.Comanda_text3.Name = "Comanda_text3";
            this.Comanda_text3.ReadOnly = true;
            this.Comanda_text3.Size = new System.Drawing.Size(193, 20);
            this.Comanda_text3.TabIndex = 10;
            this.Comanda_text3.Text = "0";
            // 
            // Comanda_text2
            // 
            this.Comanda_text2.Location = new System.Drawing.Point(211, 423);
            this.Comanda_text2.Name = "Comanda_text2";
            this.Comanda_text2.ReadOnly = true;
            this.Comanda_text2.Size = new System.Drawing.Size(193, 20);
            this.Comanda_text2.TabIndex = 9;
            this.Comanda_text2.Text = "0";
            // 
            // Comanda_text1
            // 
            this.Comanda_text1.Location = new System.Drawing.Point(12, 423);
            this.Comanda_text1.Name = "Comanda_text1";
            this.Comanda_text1.ReadOnly = true;
            this.Comanda_text1.Size = new System.Drawing.Size(193, 20);
            this.Comanda_text1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 100);
            this.button1.TabIndex = 14;
            this.button1.Text = "Finalizare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nume Produs";
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kcal";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Pret";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantitate";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Elimina";
            this.Column5.Name = "Column5";
            this.Column5.Width = 140;
            // 
            // Vizualizare_Comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Comanda_text3);
            this.Controls.Add(this.Comanda_text2);
            this.Controls.Add(this.Comanda_text1);
            this.Controls.Add(this.Comanda_DataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vizualizare_Comanda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizare Comanda";
            this.Load += new System.EventHandler(this.Vizualizare_Comanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Comanda_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Comanda_DataGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Comanda_text3;
        private System.Windows.Forms.TextBox Comanda_text2;
        private System.Windows.Forms.TextBox Comanda_text1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}