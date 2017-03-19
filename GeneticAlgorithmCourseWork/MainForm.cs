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

        List<int> TEST_PARAM;
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
            /*TEST PARAMS*/
            TEST_PARAM = new List<int>();
            TEST_PARAM.Add(40);
            TEST_PARAM.Add(32);
            TEST_PARAM.Add(53);
            TEST_PARAM.Add(33);
            TEST_PARAM.Add(62);
            TEST_PARAM.Add(44);
            TEST_PARAM.Add(28);
            TEST_PARAM.Add(70);

            CountOfDeviceUpDown.Value = 8;
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
                    /*TEST PARAMS*/
                    textbox.Text = TEST_PARAM.ElementAt(i).ToString();
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
            service.WrongParams += Service_WrongParams;
            service.callback += Service_callback;
           // service.Start();
            Parallel.Invoke(()=> service.Start());
            
           // WaitingProcessForm processForm = new WaitingProcessForm();
           // processForm.Show();
            BoxForElementsOfControl.Controls.Remove((Button)sender);

            // this.Hide();
        }

        private void Service_callback(Population population)
        {
            foreach (Chromosome chromosome in population.GetSetPopulationContainer)
            {
                FormForCheckResult formCheck = new FormForCheckResult(chromosome);
                formCheck.Show();
            }
            //Chromosome chromosome = population.GetSetPopulationContainer.ElementAt(0);
        }

        private void Service_WrongParams(object sender, EventArgs e)
        {
            MessageBox.Show("Не корректные входные параметры! Площадь пространства должна быть не менее, чем в два раза больше площади покрытия всеми устройствами.");
        }
    }
}
