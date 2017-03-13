using GeneticAlgorithmCourseWork.Container;
using GeneticAlgorithmCourseWork.Service;
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
        List<int> _radiusContainer;
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
                    textbox.Location = new Point(Properties.Settings.Default.constX,
                        Properties.Settings.Default.constY + (30*i));

                    textbox.Name = "textbox"+i;
                    textbox.KeyPress += Textbox_KeyPress;
                
                    BoxForElementsOfControl.Controls.Add(textbox);
                    _radiusTextBox.Add(textbox);
                }

                Button setDevicesValues = new Button();
                setDevicesValues.Text = Properties.Settings.Default.setDivicesText;
                setDevicesValues.AutoSize = true;
                setDevicesValues.Location = new Point(Properties.Settings.Default.constX, 
                    Properties.Settings.Default.constY + (30 * (_radiusTextBox.Count+1)));
                setDevicesValues.Click += new EventHandler(setDeviceButtonHandler);
                BoxForElementsOfControl.Controls.Add(setDevicesValues);
            }
        }

        private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void setDeviceButtonHandler(object sender, EventArgs e)
        {
             _radiusContainer = new List<int>(); 
            foreach (TextBox item in _radiusTextBox)
            {
                if (item.Text != String.Empty)
                {
                    _radiusContainer.Add(int.Parse(item.Text));
                }
                else
                {
                    item.BackColor = Color.Red;
                    return;
                }
            }

            foreach (TextBox item in _radiusTextBox)
            {
                BoxForElementsOfControl.Controls.Remove(item);
            }

            ExecuteService service = new ExecuteService(_radiusContainer);
            service.Start();
            
            WaitingProcessForm processForm = new WaitingProcessForm();
            processForm.Show();
            BoxForElementsOfControl.Controls.Remove((Button)sender);

            // this.Hide();
        }
        
    }
}
