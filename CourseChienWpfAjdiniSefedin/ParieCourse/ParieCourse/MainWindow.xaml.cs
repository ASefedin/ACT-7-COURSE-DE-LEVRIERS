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


namespace ParieCourse
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BitmapImage imageChien = new BitmapImage();
            imageChien.BeginInit();
            imageChien.UriSource = new Uri("/dog.png", UriKind.Relative);
            imageChien.EndInit();

            BitmapImage imageCourse = new BitmapImage();
            imageChien.BeginInit();
            imageChien.UriSource = new Uri("/racetrack.png", UriKind.Relative);
            imageChien.EndInit();

            Image monImage = new Image();
            monImage.Source = imageChien;
            monImage.Stretch = System.Windows.Media.Stretch.None;

            Image monImage1 = new Image();
            monImage.Source = imageCourse;
            monImage.Stretch = System.Windows.Media.Stretch.None;

            Canvas.SetLeft(monImage, position[0]);
            Canvas.SetTop(monImage, position[1]);
            plateau.piste.Children.Add(monImage);

            Canvas.SetLeft(monImage, position[0]);
            Canvas.SetTop(monImage, position[1]);
            plateau.piste.Children.Add(monImage);

        }
    }
}
