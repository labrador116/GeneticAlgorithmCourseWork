using GeneticAlgorithmCourseWork.SpaceParam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithmCourseWork
{
    public partial class SetSizeForRoomDialog : Form
    {
        private int _width;
        private int _height;
        public SetSizeForRoomDialog()
        {
            InitializeComponent();
        }

        private void SetSizeForRoomDialog_Load(object sender, EventArgs e)
        {

        }

        private void SetSizeButton_Click(object sender, EventArgs e)
        {
            if (WidthTextBox.Text != String.Empty && HeightTextBox.Text != String.Empty)
            {
                _width = int.Parse(WidthTextBox.Text);
                _height = int.Parse(HeightTextBox.Text);

                SingleSpaceParams spaceParams = SingleSpaceParams.getInstance(_height, _height);

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }

        private void WidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
