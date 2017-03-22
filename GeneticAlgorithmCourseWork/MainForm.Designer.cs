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
            this.FirstContainerForElements = new System.Windows.Forms.GroupBox();
            this.SecondContainerForElements = new System.Windows.Forms.GroupBox();
            this.VariantsToEndAlgorithmListBox = new System.Windows.Forms.ComboBox();
            this.MutationTextBox = new System.Windows.Forms.TextBox();
            this.MutationLabel = new System.Windows.Forms.Label();
            this.SumChromosomeLabel = new System.Windows.Forms.Label();
            this.ConditionOfEndWorkAlgTextBox = new System.Windows.Forms.Label();
            this.SumChromosomeTextBox = new System.Windows.Forms.TextBox();
            this.SetCountOfDeviceButton = new System.Windows.Forms.Button();
            this.CountOFDeviceLabel = new System.Windows.Forms.Label();
            this.CountOfDeviceUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpaceToAccommodate = new System.Windows.Forms.PictureBox();
            this.BoxForElementsOfControl.SuspendLayout();
            this.FirstContainerForElements.SuspendLayout();
            this.SecondContainerForElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfDeviceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceToAccommodate)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxForElementsOfControl
            // 
            this.BoxForElementsOfControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxForElementsOfControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BoxForElementsOfControl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BoxForElementsOfControl.Controls.Add(this.FirstContainerForElements);
            this.BoxForElementsOfControl.Controls.Add(this.SetCountOfDeviceButton);
            this.BoxForElementsOfControl.Controls.Add(this.CountOFDeviceLabel);
            this.BoxForElementsOfControl.Controls.Add(this.CountOfDeviceUpDown);
            this.BoxForElementsOfControl.Location = new System.Drawing.Point(904, 0);
            this.BoxForElementsOfControl.Name = "BoxForElementsOfControl";
            this.BoxForElementsOfControl.Size = new System.Drawing.Size(500, 647);
            this.BoxForElementsOfControl.TabIndex = 1;
            this.BoxForElementsOfControl.TabStop = false;
            // 
            // FirstContainerForElements
            // 
            this.FirstContainerForElements.Controls.Add(this.SecondContainerForElements);
            this.FirstContainerForElements.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FirstContainerForElements.Location = new System.Drawing.Point(222, 69);
            this.FirstContainerForElements.Name = "FirstContainerForElements";
            this.FirstContainerForElements.Padding = new System.Windows.Forms.Padding(0);
            this.FirstContainerForElements.Size = new System.Drawing.Size(272, 553);
            this.FirstContainerForElements.TabIndex = 11;
            this.FirstContainerForElements.TabStop = false;
            this.FirstContainerForElements.Visible = false;
            // 
            // SecondContainerForElements
            // 
            this.SecondContainerForElements.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SecondContainerForElements.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SecondContainerForElements.Controls.Add(this.VariantsToEndAlgorithmListBox);
            this.SecondContainerForElements.Controls.Add(this.MutationTextBox);
            this.SecondContainerForElements.Controls.Add(this.MutationLabel);
            this.SecondContainerForElements.Controls.Add(this.SumChromosomeLabel);
            this.SecondContainerForElements.Controls.Add(this.ConditionOfEndWorkAlgTextBox);
            this.SecondContainerForElements.Controls.Add(this.SumChromosomeTextBox);
            this.SecondContainerForElements.Dock = System.Windows.Forms.DockStyle.Right;
            this.SecondContainerForElements.Location = new System.Drawing.Point(0, 13);
            this.SecondContainerForElements.Margin = new System.Windows.Forms.Padding(0);
            this.SecondContainerForElements.Name = "SecondContainerForElements";
            this.SecondContainerForElements.Size = new System.Drawing.Size(272, 540);
            this.SecondContainerForElements.TabIndex = 10;
            this.SecondContainerForElements.TabStop = false;
            // 
            // VariantsToEndAlgorithmListBox
            // 
            this.VariantsToEndAlgorithmListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariantsToEndAlgorithmListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VariantsToEndAlgorithmListBox.FormattingEnabled = true;
            this.VariantsToEndAlgorithmListBox.Location = new System.Drawing.Point(145, 34);
            this.VariantsToEndAlgorithmListBox.Name = "VariantsToEndAlgorithmListBox";
            this.VariantsToEndAlgorithmListBox.Size = new System.Drawing.Size(121, 21);
            this.VariantsToEndAlgorithmListBox.TabIndex = 4;
            this.VariantsToEndAlgorithmListBox.SelectedValueChanged += new System.EventHandler(this.VariantsToEndAlgorithmListBox_SelectedValueChanged);
            // 
            // MutationTextBox
            // 
            this.MutationTextBox.Location = new System.Drawing.Point(166, 166);
            this.MutationTextBox.Name = "MutationTextBox";
            this.MutationTextBox.Size = new System.Drawing.Size(100, 20);
            this.MutationTextBox.TabIndex = 7;
            this.MutationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MutationTextBox_KeyPress);
            // 
            // MutationLabel
            // 
            this.MutationLabel.AutoSize = true;
            this.MutationLabel.Location = new System.Drawing.Point(96, 150);
            this.MutationLabel.Name = "MutationLabel";
            this.MutationLabel.Size = new System.Drawing.Size(170, 13);
            this.MutationLabel.TabIndex = 6;
            this.MutationLabel.Text = "Вероятность мутации (от 0 до 1)";
            // 
            // SumChromosomeLabel
            // 
            this.SumChromosomeLabel.AutoSize = true;
            this.SumChromosomeLabel.Location = new System.Drawing.Point(73, 111);
            this.SumChromosomeLabel.Name = "SumChromosomeLabel";
            this.SumChromosomeLabel.Size = new System.Drawing.Size(193, 13);
            this.SumChromosomeLabel.TabIndex = 8;
            this.SumChromosomeLabel.Text = "Количество хромомсом в популяции";
            // 
            // ConditionOfEndWorkAlgTextBox
            // 
            this.ConditionOfEndWorkAlgTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConditionOfEndWorkAlgTextBox.AutoSize = true;
            this.ConditionOfEndWorkAlgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConditionOfEndWorkAlgTextBox.Location = new System.Drawing.Point(23, 16);
            this.ConditionOfEndWorkAlgTextBox.Name = "ConditionOfEndWorkAlgTextBox";
            this.ConditionOfEndWorkAlgTextBox.Size = new System.Drawing.Size(243, 15);
            this.ConditionOfEndWorkAlgTextBox.TabIndex = 5;
            this.ConditionOfEndWorkAlgTextBox.Text = "Условие завершения работы алгоритма";
            // 
            // SumChromosomeTextBox
            // 
            this.SumChromosomeTextBox.Location = new System.Drawing.Point(166, 127);
            this.SumChromosomeTextBox.Name = "SumChromosomeTextBox";
            this.SumChromosomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumChromosomeTextBox.TabIndex = 9;
            this.SumChromosomeTextBox.TextChanged += new System.EventHandler(this.SumChromosomeTextBox_TextChanged);
            // 
            // SetCountOfDeviceButton
            // 
            this.SetCountOfDeviceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetCountOfDeviceButton.Location = new System.Drawing.Point(148, 43);
            this.SetCountOfDeviceButton.Name = "SetCountOfDeviceButton";
            this.SetCountOfDeviceButton.Size = new System.Drawing.Size(232, 23);
            this.SetCountOfDeviceButton.TabIndex = 2;
            this.SetCountOfDeviceButton.Text = "Задать";
            this.SetCountOfDeviceButton.UseVisualStyleBackColor = true;
            this.SetCountOfDeviceButton.Click += new System.EventHandler(this.SetCountOfDeviceButton_Click);
            // 
            // CountOFDeviceLabel
            // 
            this.CountOFDeviceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CountOFDeviceLabel.AutoSize = true;
            this.CountOFDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOFDeviceLabel.Location = new System.Drawing.Point(2, 13);
            this.CountOFDeviceLabel.Name = "CountOFDeviceLabel";
            this.CountOFDeviceLabel.Size = new System.Drawing.Size(447, 22);
            this.CountOFDeviceLabel.TabIndex = 1;
            this.CountOFDeviceLabel.Text = "Задайте количество устройств беспроводной связи";
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
            this.SpaceToAccommodate.Size = new System.Drawing.Size(594, 647);
            this.SpaceToAccommodate.TabIndex = 2;
            this.SpaceToAccommodate.TabStop = false;
            this.SpaceToAccommodate.Paint += new System.Windows.Forms.PaintEventHandler(this.SpaceToAccommodate_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 647);
            this.Controls.Add(this.SpaceToAccommodate);
            this.Controls.Add(this.BoxForElementsOfControl);
            this.Name = "MainForm";
            this.Text = "Рабочая область";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BoxForElementsOfControl.ResumeLayout(false);
            this.BoxForElementsOfControl.PerformLayout();
            this.FirstContainerForElements.ResumeLayout(false);
            this.SecondContainerForElements.ResumeLayout(false);
            this.SecondContainerForElements.PerformLayout();
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
        private System.Windows.Forms.ComboBox VariantsToEndAlgorithmListBox;
        private System.Windows.Forms.Label ConditionOfEndWorkAlgTextBox;
        private System.Windows.Forms.TextBox MutationTextBox;
        private System.Windows.Forms.Label MutationLabel;
        private System.Windows.Forms.GroupBox FirstContainerForElements;
        private System.Windows.Forms.GroupBox SecondContainerForElements;
        private System.Windows.Forms.Label SumChromosomeLabel;
        private System.Windows.Forms.TextBox SumChromosomeTextBox;
    }
}

