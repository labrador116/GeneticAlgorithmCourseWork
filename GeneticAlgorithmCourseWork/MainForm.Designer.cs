namespace GeneticAlgorithmCourseWork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoxForElementsOfControl = new System.Windows.Forms.GroupBox();
            this.SetCountOfDeviceButton = new System.Windows.Forms.Button();
            this.CountOFDeviceLabel = new System.Windows.Forms.Label();
            this.CountOfDeviceUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpaceToAccommodate = new System.Windows.Forms.PictureBox();
            this.BoxForElementsOfControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfDeviceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceToAccommodate)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxForElementsOfControl
            // 
            this.BoxForElementsOfControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxForElementsOfControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BoxForElementsOfControl.Controls.Add(this.SetCountOfDeviceButton);
            this.BoxForElementsOfControl.Controls.Add(this.CountOFDeviceLabel);
            this.BoxForElementsOfControl.Controls.Add(this.CountOfDeviceUpDown);
            this.BoxForElementsOfControl.Location = new System.Drawing.Point(709, 0);
            this.BoxForElementsOfControl.Name = "BoxForElementsOfControl";
            this.BoxForElementsOfControl.Size = new System.Drawing.Size(409, 647);
            this.BoxForElementsOfControl.TabIndex = 1;
            this.BoxForElementsOfControl.TabStop = false;
            this.BoxForElementsOfControl.Text = "Элементы упраления";
            // 
            // SetCountOfDeviceButton
            // 
            this.SetCountOfDeviceButton.Location = new System.Drawing.Point(209, 40);
            this.SetCountOfDeviceButton.Name = "SetCountOfDeviceButton";
            this.SetCountOfDeviceButton.Size = new System.Drawing.Size(75, 23);
            this.SetCountOfDeviceButton.TabIndex = 2;
            this.SetCountOfDeviceButton.Text = "Задать";
            this.SetCountOfDeviceButton.UseVisualStyleBackColor = true;
            this.SetCountOfDeviceButton.Click += new System.EventHandler(this.SetCountOfDeviceButton_Click);
            // 
            // CountOFDeviceLabel
            // 
            this.CountOFDeviceLabel.AutoSize = true;
            this.CountOFDeviceLabel.Location = new System.Drawing.Point(6, 27);
            this.CountOFDeviceLabel.Name = "CountOFDeviceLabel";
            this.CountOFDeviceLabel.Size = new System.Drawing.Size(278, 13);
            this.CountOFDeviceLabel.TabIndex = 1;
            this.CountOFDeviceLabel.Text = "Задайте колисчество устройств беспроводной связи";
            // 
            // CountOfDeviceUpDown
            // 
            this.CountOfDeviceUpDown.Location = new System.Drawing.Point(6, 43);
            this.CountOfDeviceUpDown.Name = "CountOfDeviceUpDown";
            this.CountOfDeviceUpDown.Size = new System.Drawing.Size(120, 20);
            this.CountOfDeviceUpDown.TabIndex = 0;
            // 
            // SpaceToAccommodate
            // 
            this.SpaceToAccommodate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpaceToAccommodate.Location = new System.Drawing.Point(0, 0);
            this.SpaceToAccommodate.Name = "SpaceToAccommodate";
            this.SpaceToAccommodate.Size = new System.Drawing.Size(703, 647);
            this.SpaceToAccommodate.TabIndex = 2;
            this.SpaceToAccommodate.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 647);
            this.Controls.Add(this.SpaceToAccommodate);
            this.Controls.Add(this.BoxForElementsOfControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BoxForElementsOfControl.ResumeLayout(false);
            this.BoxForElementsOfControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfDeviceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceToAccommodate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxForElementsOfControl;
        private System.Windows.Forms.Button SetCountOfDeviceButton;
        private System.Windows.Forms.Label CountOFDeviceLabel;
        private System.Windows.Forms.NumericUpDown CountOfDeviceUpDown;
        private System.Windows.Forms.PictureBox SpaceToAccommodate;
    }
}

