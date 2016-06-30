namespace HealthMenu
{
    partial class Start
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gooD_FOODDataSet1 = new HealthMenu.GOOD_FOODDataSet();
            this.clientiTableAdapter = new HealthMenu.GOOD_FOODDataSetTableAdapters.ClientiTableAdapter();
            this.comenziTableAdapter = new HealthMenu.GOOD_FOODDataSetTableAdapters.ComenziTableAdapter();
            this.meniuTableAdapter = new HealthMenu.GOOD_FOODDataSetTableAdapters.MeniuTableAdapter();
            this.subcomenziTableAdapter = new HealthMenu.GOOD_FOODDataSetTableAdapters.SubcomenziTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gooD_FOODDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Autentificare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Inregistrare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meniuri diverse caracterizate prin transparenta is excelenta!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HealthMenu.Properties.Resources.good_food_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // gooD_FOODDataSet1
            // 
            this.gooD_FOODDataSet1.DataSetName = "GOOD_FOODDataSet";
            this.gooD_FOODDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // comenziTableAdapter
            // 
            this.comenziTableAdapter.ClearBeforeFill = true;
            // 
            // meniuTableAdapter
            // 
            this.meniuTableAdapter.ClearBeforeFill = true;
            // 
            // subcomenziTableAdapter
            // 
            this.subcomenziTableAdapter.ClearBeforeFill = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Start";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gooD_FOODDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GOOD_FOODDataSet gooD_FOODDataSet1;
        private GOOD_FOODDataSetTableAdapters.ClientiTableAdapter clientiTableAdapter;
        private GOOD_FOODDataSetTableAdapters.ComenziTableAdapter comenziTableAdapter;
        private GOOD_FOODDataSetTableAdapters.MeniuTableAdapter meniuTableAdapter;
        private GOOD_FOODDataSetTableAdapters.SubcomenziTableAdapter subcomenziTableAdapter;
    }
}

