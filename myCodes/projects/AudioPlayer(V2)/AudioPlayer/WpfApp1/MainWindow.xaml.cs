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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private MediaPlayer player = new MediaPlayer();
        private string filePath = "";

        public MainWindow()
        {
            InitializeComponent();
            //OpenSong();
            Imagine.Source = new BitmapImage(new Uri(@"D:\C_Sharp\AudioPlayer(V2)\images\2.png")); //Imaginea cind nu cinta nimic
            VolumeSlider.Value = VolumeSlider.Maximum;

            #region Timer Code
            //Timer
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (player.Source != null)
            {
                UpdateTimers();
            }
        }
        private void UpdateTimers()
        {
            if (player.NaturalDuration.HasTimeSpan)
            {
                TotalDuration.Text = player.NaturalDuration.TimeSpan.ToString();
                CurrentDuration.Text = player.Position.ToString();
                ProgressBar.Value = player.Position.TotalSeconds / player.NaturalDuration.TimeSpan.TotalSeconds;
            }
        }
        #endregion

        #region Metode Ajutatoare
        private void OpenSong()
        {
            player.Open(new Uri(filePath));
        }
        private void PressPlay()
        {
            UpdateTimers();
            player.Play();
            Imagine.Source = new BitmapImage(new Uri(@"D:\C_Sharp\AudioPlayer(V2)\images\play.png")); //Imaginea cind cinta 
        }
        #endregion

        #region Butoane
        private void Play_Click(object sender, RoutedEventArgs e)
        {
            PressPlay();
        }
        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            player.Pause();
            Imagine.Source = new BitmapImage(new Uri(@"D:\C_Sharp\AudioPlayer(V2)\images\pause.png")); //Imaginea cind pauza 
        }
        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            Imagine.Source = new BitmapImage(new Uri(@"D:\C_Sharp\AudioPlayer(V2)\images\2.png")); //Imaginea cind nu cinta nimic
        }
        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            player.Volume = VolumeSlider.Value / 10;
            CurrentVolume.Text = (VolumeSlider.Value * 10).ToString("0") + "%";
        }
        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog window = new Microsoft.Win32.OpenFileDialog();
            window.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";

            Nullable<bool> result = window.ShowDialog();
            if (result == true)
            {
                string filename = window.FileName;
                filePath = filename;
                OpenSong();
                PressPlay();
            }
        }
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Prev5_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan sec = new TimeSpan(0, 0, 0, -5);
            player.Position = player.Position.Add(sec);
            UpdateTimers();
        }

        private void Next5_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan sec = new TimeSpan(0, 0, 0, 5);
            player.Position = player.Position.Add(sec);
            UpdateTimers();
        }
    }
}