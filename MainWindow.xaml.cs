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
using static CalculationMethods_L5_WPF.Lagrange;

namespace CalculationMethods_L5_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Fill(new []
            {
                Convert.ToDouble(TbX0.Text.Replace('.',',')),
                Convert.ToDouble(TbX1.Text.Replace('.',',')), Convert.ToDouble(TbX2.Text.Replace('.',',')), Convert.ToDouble(TbX3.Text.Replace('.',',')),
                Convert.ToDouble(TbX4.Text.Replace('.',',')), Convert.ToDouble(TbX5.Text.Replace('.',',')),Convert.ToDouble(TbX6.Text.Replace('.',',')),
                Convert.ToDouble(TbX7.Text.Replace('.',',')),Convert.ToDouble(TbX8.Text.Replace('.',',')),Convert.ToDouble(TbX9.Text.Replace('.',',')),
                Convert.ToDouble(TbX10.Text.Replace('.',','))
            }, new []
            {
                Convert.ToDouble(TbY0.Text.Replace('.',',')),
                Convert.ToDouble(TbY1.Text.Replace('.',',')), Convert.ToDouble(TbY2.Text.Replace('.',',')), Convert.ToDouble(TbY3.Text.Replace('.',',')),
                Convert.ToDouble(TbY4.Text.Replace('.',',')), Convert.ToDouble(TbY5.Text.Replace('.',',')),Convert.ToDouble(TbY6.Text.Replace('.',',')),
                Convert.ToDouble(TbY7.Text.Replace('.',',')),Convert.ToDouble(TbY8.Text.Replace('.',',')),Convert.ToDouble(TbY9.Text.Replace('.',',')),
                Convert.ToDouble(TbY10.Text.Replace('.',','))
            });
            var x = Convert.ToDouble(TbX.Text.Replace('.', ','));
            TbOutput.Text = Interpolate(x) + "";
        }
    }
}