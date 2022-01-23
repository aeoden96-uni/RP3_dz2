namespace Zadaca02
{
    partial class vremenski_raspon
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datum1 = new Zadaca02.datum();
            this.datum2 = new Zadaca02.datum();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kraj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Početak";
            // 
            // datum1
            // 
            this.datum1.Location = new System.Drawing.Point(56, 5);
            this.datum1.Name = "datum1";
            this.datum1.Size = new System.Drawing.Size(194, 29);
            this.datum1.TabIndex = 4;
            this.datum1.vrijednost = new System.DateTime(2022, 1, 22, 0, 0, 0, 0);
            this.datum1.Load += new System.EventHandler(this.datum1_Load);
            // 
            // datum2
            // 
            this.datum2.Location = new System.Drawing.Point(291, 5);
            this.datum2.Name = "datum2";
            this.datum2.Size = new System.Drawing.Size(194, 29);
            this.datum2.TabIndex = 5;
            this.datum2.vrijednost = new System.DateTime(2022, 1, 22, 0, 0, 0, 0);
            // 
            // vremenski_raspon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datum2);
            this.Controls.Add(this.datum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "vremenski_raspon";
            this.Size = new System.Drawing.Size(487, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private datum datum1;
        private datum datum2;
    }
}
