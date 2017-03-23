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
    public partial class GraphicWithDataOfChromosomes : Form
    {
        public GraphicWithDataOfChromosomes()
        {
            InitializeComponent();
        }

        private void GraphicWithDataOfChromosomes_Load(object sender, EventArgs e)
        {

            //chartForChromosomes.ChartAreas[0].AxisX.ScaleView.Zoom(0, SingleSpaceParams.getInstance().GlobalResultContainerGetSet.Count);
            //chartForChromosomes.ChartAreas[0].AxisY.ScaleView.Zoom(0, 1);
            chartForChromosomes.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartForChromosomes.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartForChromosomes.ChartAreas[0].AxisX.Minimum = 0;
            chartForChromosomes.ChartAreas[0].AxisX.Title = "Популяция";

            chartForChromosomes.ChartAreas[0].AxisY.Minimum = 0;
            chartForChromosomes.ChartAreas[0].AxisY.Title = "Целевая функция";
            chartForChromosomes.Series[0].Color = Color.Red;

            chartForChromosomes.ChartAreas[0].AxisX.Maximum = SingleSpaceParams.getInstance().GlobalResultContainerGetSet.Count;
            chartForChromosomes.ChartAreas[0].AxisY.Maximum = 1;

            chartForChromosomes.ChartAreas[0].AxisX.Interval = 1;
            chartForChromosomes.ChartAreas[0].AxisY.Interval = 0.02;
            chartForChromosomes.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            chartForChromosomes.Series[0].Name = "Отношение популяции к ЦФ";
            chartForChromosomes.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 0; i < SingleSpaceParams.getInstance().GlobalResultContainerGetSet.Count; i++)
            {

                chartForChromosomes.Series[0].Points.AddXY(i, Math.Round(SingleSpaceParams.getInstance().GlobalResultContainerGetSet.ElementAt(i).Ratio, 4));
               
            }


        }
    }
}
