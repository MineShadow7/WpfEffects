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

using System.Windows.Threading;

namespace WpfEffects
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        int ticks = 0;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if (ticks % 2 == 0)
            {
                label1.Foreground = new SolidColorBrush(Colors.Red);
                label1.Effect = new System.Windows.Media.Effects.BlurEffect();
            }
            else
            {
                label1.Foreground = new SolidColorBrush(Colors.Orange);
                label1.Effect = new System.Windows.Media.Effects.DropShadowEffect();
            }
            ticks++;
            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Effect = new System.Windows.Media.Effects.BlurEffect();
        }
    }
}
