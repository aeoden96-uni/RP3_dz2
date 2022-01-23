namespace Zadaca02
{
    partial class graf
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
            this.graphCanvas = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // graphCanvas
            // 
            this.graphCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphCanvas.Location = new System.Drawing.Point(15, 21);
            this.graphCanvas.Name = "graphCanvas";
            this.graphCanvas.Size = new System.Drawing.Size(479, 346);
            this.graphCanvas.TabIndex = 5;
            this.graphCanvas.TabStop = false;
            // 
            // graf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.graphCanvas);
            this.Name = "graf";
            this.Size = new System.Drawing.Size(512, 386);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox graphCanvas;
    }
}
