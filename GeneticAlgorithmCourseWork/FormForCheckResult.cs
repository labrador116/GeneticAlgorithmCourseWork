using GeneticAlgorithmCourseWork.ChromosomeModel;
using GeneticAlgorithmCourseWork.Container;
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
    public partial class FormForCheckResult : Form
    {
        Chromosome _chromosome;

        public FormForCheckResult(Chromosome chromosome)
        {
            InitializeComponent();
            _chromosome = chromosome;
        }

        private void FormForCheckResult_Load(object sender, EventArgs e)
        {
            
        }

        private void CheckResultPictureBox_Paint(object sender, PaintEventArgs e)
        {
          
            CheckResultPictureBox.Width = SingleSpaceParams.getInstance().Width;
            CheckResultPictureBox.Height = SingleSpaceParams.getInstance().Height;
            int count = 0;
            foreach (Gene gene in _chromosome.Container)
            {
                double x;
                double y;

                for (double i = 0; i < Math.PI*2; i=i+0.01)
                {
                    x = Convert.ToDouble(gene.OX) + Convert.ToDouble(gene.Radius) * Math.Cos(i);
                    y = Convert.ToDouble(gene.OY) + Convert.ToDouble(gene.Radius) * Math.Sin(i);

                   int x2 = Convert.ToInt32(x);
                   int y2 = Convert.ToInt32(y);
                    e.Graphics.DrawLine(new Pen(Color.Black), new Point(x2, y2), new Point(x2 + 1, y2));
                    e.Graphics.Save();
                }
                Label label = new Label();
                label.Name = "label" + count;
                label.Text = count.ToString(); 
                label.Width = 10;
                label.Height = 13;
                label.Location = new Point(gene.OX, gene.OY);
                CheckResultPictureBox.Controls.Add(label);
                count++;
            }
        }
    }
}
