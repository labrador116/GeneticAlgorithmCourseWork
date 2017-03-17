namespace GeneticAlgorithmCourseWork
{
    partial class FormForCheckResult
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
            this.CheckResultPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CheckResultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckResultPictureBox
            // 
            this.CheckResultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckResultPictureBox.Location = new System.Drawing.Point(35, 48);
            this.CheckResultPictureBox.Name = "CheckResultPictureBox";
            this.CheckResultPictureBox.Size = new System.Drawing.Size(837, 434);
            this.CheckResultPictureBox.TabIndex = 0;
            this.CheckResultPictureBox.TabStop = false;
            this.CheckResultPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckResultPictureBox_Paint);
            // 
            // FormForCheckResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 522);
            this.Controls.Add(this.CheckResultPictureBox);
            this.Name = "FormForCheckResult";
            this.Text = "FormForCheckResult";
            this.Load += new System.EventHandler(this.FormForCheckResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckResultPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CheckResultPictureBox;
    }
}