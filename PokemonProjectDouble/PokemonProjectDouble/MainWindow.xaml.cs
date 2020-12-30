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
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.IO;
using WpfAnimatedGif;

namespace ShinyPokemonGraphic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            initializeCount();
            //setCurrentOdds();
        }

        //The goal of this is to be able to set this to load the first gif in the folder and make it work regardless of the name
        public void setCurrentHunt()
        {
            string imgfolderPath = "C:\\Users\\gavin\\Desktop\\PokemonProject\\CurrentHunt\\";
            DirectoryInfo di = new DirectoryInfo(imgfolderPath);
            var firstFileName = di.EnumerateFiles()
                      .Select(f => f.Name)
                      .FirstOrDefault();

            string firstFile = imgfolderPath + di.Name;

        }

        /**
        public void setCurrentOdds()
        {
            string path = "C:\\Users\\gavin\\Desktop\\PokemonProject\\BackgroundGraphics\\_CurrentOdds.txt";
            String content = "";
            if (File.Exists(path))
            {
                if (new FileInfo(path).Length != 0)
                {
                    string readText = File.ReadAllText(path);

                    Console.WriteLine(readText);

                    content = readText;
                }
            }
            currentOdds.Content = content;

        }
        **/

        public int setCountCurrent(String path)
        {
            
            int count = 0;

            if (File.Exists(path))
            {
                if (new FileInfo(path).Length != 0)
                {
                    string readText = File.ReadAllText(path);

                    Console.WriteLine(readText);

                    count = int.Parse(readText);
                }
            }
            return count;
        }

  

        public void initializeCount()
        {
            string path = "C:\\Users\\gavin\\Desktop\\PokemonProject\\CurrentHunt\\CurrentCount.txt";
            string path2 = "C:\\Users\\gavin\\Desktop\\PokemonProject\\CurrentHunt\\CurrentCount.txt";

            currentCount.Content = setCountCurrent(path);
            currentCount2.Content = setCountCurrent(path2);
        }


        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        void plusButton(object sender, RoutedEventArgs e)
        {
            int count = (int)currentCount.Content;
            count++;
            currentCount.Content = count;
        }

        void subButton(object sender, RoutedEventArgs e)
        {
            int count = (int)currentCount.Content;
            count--;
            currentCount.Content = count;
        }

        void plusButton2(object sender, RoutedEventArgs e)
        {
            int count = (int)currentCount2.Content;
            count++;
            currentCount2.Content = count;
        }

        void subButton2(object sender, RoutedEventArgs e)
        {
            int count = (int)currentCount2.Content;
            count--;
            currentCount2.Content = count;
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.A)
            {
                // currentCount.Content = count;
            }
        }

    }
}