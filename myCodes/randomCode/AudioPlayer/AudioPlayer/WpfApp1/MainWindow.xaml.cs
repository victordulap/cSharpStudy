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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private MediaPlayer player = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();
            player.Open(new Uri(@"D:\JuiceWrldMusicLeaks\Juice Wrld Leaks\Juice WRLD - Jeffery.mp3"));
            // @ inseamna ca noi indicam o adresa

            //imaginea cand nu se intampla nimic
            Imagine.Source = new BitmapImage(new Uri(@"D:\C_Sharp\AudioPlayer\images\2.png"));

            VolumeSlider.Value = 1;
            VolumCurent.Content = Convert.ToInt32((VolumeSlider.Value * 100)).ToString() + "%";
        }

        #region Butoane
        private void Play_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
            Imagine.Source = new BitmapImage(new Uri(@"D:\C_Sharp\AudioPlayer\images\play.png"));

            string strTotalTime = string.Format("{0:00}:{1:00}:{2:00}", player.NaturalDuration.TimeSpan.Hours, player.NaturalDuration.TimeSpan.Minutes, player.NaturalDuration.TimeSpan.Seconds);
            string strCurrentTime = string.Format("{0:00}:{1:00}:{2:00}", player.Position.Hours, player.Position.Minutes, player.Position.Seconds);

            TotalTime.Content = strTotalTime;//player.NaturalDuration.TimeSpan.ToString();
            CurrentTime.Content = strCurrentTime;//player.Position.ToString();
        }
        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            player.Pause();
            Imagine.Source = new BitmapImage(new Uri(@"D:\C_Sharp\AudioPlayer\images\pause.png"));
        }
        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            //imaginea cand nu se intampla nimic
            Imagine.Source = new BitmapImage(new Uri(@"D:\C_Sharp\AudioPlayer\images\2.png"));
        }
        #endregion

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            player.Volume = VolumeSlider.Value;
            VolumCurent.Content = Convert.ToInt32((VolumeSlider.Value * 100)).ToString() + "%";
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}