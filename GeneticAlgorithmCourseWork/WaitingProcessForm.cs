using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithmCourseWork
{
    public partial class WaitingProcessForm : Form
    {
        public WaitingProcessForm()
        {
            InitializeComponent();

            
        }

        private void WaitingProcessForm_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1;
            progressBar1.Step = 1;

            int count = progressBar1.Maximum;
            progressBar1.Maximum *= 1000;

            if (count == 0)
                return;

            while (true)
            {
                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        progressBar1.PerformStep();

                        Thread.Sleep(1);
                    }
                }

                progressBar1.Value = 0;

                Thread.Sleep(2000);
            }

        }
    }
}
