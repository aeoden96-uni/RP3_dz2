namespace Zadaca02
{
    partial class Sinus
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
            this.pocetak_1 = new System.Windows.Forms.NumericUpDown();
            this.pocetak_2 = new System.Windows.Forms.NumericUpDown();
            this.pocetak_3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.kraj_1 = new System.Windows.Forms.NumericUpDown();
            this.kraj_2 = new System.Windows.Forms.NumericUpDown();
            this.kraj_3 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datum1 = new Zadaca02.datum();
            this.vremenski_raspon1 = new Zadaca02.vremenski_raspon();
            ((System.ComponentModel.ISupportInitialize)(this.pocetak_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocetak_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocetak_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kraj_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kraj_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kraj_3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Početak";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pocetak_1
            // 
            this.pocetak_1.Location = new System.Drawing.Point(65, 12);
            this.pocetak_1.Name = "pocetak_1";
            this.pocetak_1.Size = new System.Drawing.Size(57, 20);
            this.pocetak_1.TabIndex = 2;
            // 
            // pocetak_2
            // 
            this.pocetak_2.Location = new System.Drawing.Point(128, 12);
            this.pocetak_2.Name = "pocetak_2";
            this.pocetak_2.Size = new System.Drawing.Size(57, 20);
            this.pocetak_2.TabIndex = 2;
            // 
            // pocetak_3
            // 
            this.pocetak_3.Location = new System.Drawing.Point(191, 12);
            this.pocetak_3.Name = "pocetak_3";
            this.pocetak_3.Size = new System.Drawing.Size(57, 20);
            this.pocetak_3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kraj";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // kraj_1
            // 
            this.kraj_1.Location = new System.Drawing.Point(321, 12);
            this.kraj_1.Name = "kraj_1";
            this.kraj_1.Size = new System.Drawing.Size(57, 20);
            this.kraj_1.TabIndex = 2;
            this.kraj_1.ValueChanged += new System.EventHandler(this.kraj_1_ValueChanged);
            // 
            // kraj_2
            // 
            this.kraj_2.Location = new System.Drawing.Point(384, 12);
            this.kraj_2.Name = "kraj_2";
            this.kraj_2.Size = new System.Drawing.Size(57, 20);
            this.kraj_2.TabIndex = 2;
            // 
            // kraj_3
            // 
            this.kraj_3.Location = new System.Drawing.Point(447, 12);
            this.kraj_3.Name = "kraj_3";
            this.kraj_3.Size = new System.Drawing.Size(57, 20);
            this.kraj_3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 378);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(806, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(809, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // datum1
            // 
            this.datum1.Location = new System.Drawing.Point(128, 476);
            this.datum1.Name = "datum1";
            this.datum1.Size = new System.Drawing.Size(194, 29);
            this.datum1.TabIndex = 8;
            this.datum1.vrijednost = new System.DateTime(2022, 1, 23, 0, 0, 0, 0);
            // 
            // vremenski_raspon1
            // 
            this.vremenski_raspon1.Location = new System.Drawing.Point(321, 445);
            this.vremenski_raspon1.Name = "vremenski_raspon1";
            this.vremenski_raspon1.Size = new System.Drawing.Size(487, 34);
            this.vremenski_raspon1.TabIndex = 9;
            // 
            // Sinus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 544);
            this.Controls.Add(this.vremenski_raspon1);
            this.Controls.Add(this.datum1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kraj_3);
            this.Controls.Add(this.pocetak_3);
            this.Controls.Add(this.kraj_2);
            this.Controls.Add(this.kraj_1);
            this.Controls.Add(this.pocetak_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pocetak_1);
            this.Controls.Add(this.label1);
            this.Name = "Sinus";
            this.Text = "Form1";
            this.ResizeBegin += new System.EventHandler(this.resize_begin);
            this.ResizeEnd += new System.EventHandler(this.resize_end);
            ((System.ComponentModel.ISupportInitialize)(this.pocetak_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocetak_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocetak_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kraj_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kraj_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kraj_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown pocetak_1;
        private System.Windows.Forms.NumericUpDown pocetak_2;
        private System.Windows.Forms.NumericUpDown pocetak_3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown kraj_1;
        private System.Windows.Forms.NumericUpDown kraj_2;
        private System.Windows.Forms.NumericUpDown kraj_3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private datum datum1;
        private vremenski_raspon vremenski_raspon1;
    }
}

