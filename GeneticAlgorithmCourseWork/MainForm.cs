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
    public partial class MainForm : Form
    {
        List<TextBox> _radiusTextBox;
        public MainForm()
        {
            InitializeComponent();
            SpaceToAccommodate.Width = SingleSpaceParams.getInstance().Width;
            SpaceToAccommodate.Height = SingleSpaceParams.getInstance().Height;

            if (this.Width < SpaceToAccommodate.Width)
            {  this.Width += (SpaceToAccommodate.Width / 2); }

            if (this.Height < SpaceToAccommodate.Height)
            { this.Height += (SpaceToAccommodate.Height / 2); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void SetCountOfDeviceButton_Click(object sender, EventArgs e)
        {
            if (CountOfDeviceUpDown.Value > 0)
            {
                 _radiusTextBox= new List<TextBox>();

                for (int i=0; i< CountOfDeviceUpDown.Value; i++)
                {
                    TextBox textbox = new TextBox();
                    textbox.Location = new Point(16, 73+(30*i));
                    textbox.Name = "textbox"+i;
                
                    BoxForElementsOfControl.Controls.Add(textbox);
                    _radiusTextBox.Add(textbox);
                    
                 
                    
                }
            }
        }
    }
}
