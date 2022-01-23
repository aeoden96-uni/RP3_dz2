namespace Zadaca02
{
    partial class datum
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pocetak_3 = new System.Windows.Forms.NumericUpDown();
            this.pocetak_2 = new System.Windows.Forms.NumericUpDown();
            this.pocetak_1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pocetak_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocetak_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocetak_1)).BeginInit();
            this.SuspendLayout();
            // 
            // pocetak_3
            // 
            this.pocetak_3.Location = new System.Drawing.Point(129, 3);
            this.pocetak_3.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.pocetak_3.Name = "pocetak_3";
            this.pocetak_3.Size = new System.Drawing.Size(57, 20);
            this.pocetak_3.TabIndex = 4;
            this.pocetak_3.ValueChanged += new System.EventHandler(this.pocetak_3_ValueChanged);
            // 
            // pocetak_2
            // 
            this.pocetak_2.Location = new System.Drawing.Point(66, 3);
            this.pocetak_2.Name = "pocetak_2";
            this.pocetak_2.Size = new System.Drawing.Size(57, 20);
            this.pocetak_2.TabIndex = 5;
            this.pocetak_2.ValueChanged += new System.EventHandler(this.pocetak_2_ValueChanged);
            // 
            // pocetak_1
            // 
            this.pocetak_1.Location = new System.Drawing.Point(3, 3);
            this.pocetak_1.Name = "pocetak_1";
            this.pocetak_1.Size = new System.Drawing.Size(57, 20);
            this.pocetak_1.TabIndex = 6;
            this.pocetak_1.ValueChanged += new System.EventHandler(this.pocetak_1_ValueChanged);
            // 
            // datum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pocetak_3);
            this.Controls.Add(this.pocetak_2);
            this.Controls.Add(this.pocetak_1);
            this.Name = "datum";
            this.Size = new System.Drawing.Size(194, 29);
            ((System.ComponentModel.ISupportInitialize)(this.pocetak_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocetak_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocetak_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pocetak_3;
        private System.Windows.Forms.NumericUpDown pocetak_2;
        private System.Windows.Forms.NumericUpDown pocetak_1;
    }
}
