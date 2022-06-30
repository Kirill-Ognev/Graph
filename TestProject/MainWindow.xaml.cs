using Arction.Wpf.Charting;
using Arction.Wpf.Charting.SeriesXY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestProject
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LightningChart _chart = new LightningChart();
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            CreateChart();

        }

       

        public void CreateChart()
        {
            PointLineSeries pls = new PointLineSeries();
            SeriesPoint[] sp = new SeriesPoint[10];
            GridGraph.Children.Add(_chart);
            _chart.BeginUpdate();
            
            
            for (int i = 0; i < sp.Length; i++)
            {
                sp[i].X = i;
                sp[i].Y = rnd.NextDouble() * 30;
            }
            pls.AddPoints(sp, false);
            _chart.ViewXY.PointLineSeries.Add(pls);
            _chart.EndUpdate();
            
        }
    }
}
