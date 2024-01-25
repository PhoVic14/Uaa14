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

namespace Act6_DamiersEx3VictorPholien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[,] textBlockMatrix;
        public MainWindow()
        {
            InitializeComponent();

            ColumnDefinition[] colDefs = new ColumnDefinition[8];
            for (int i = 0; i < 8; i++)
            {
                colDefs[i] = new ColumnDefinition();
                gridMain.ColumnDefinitions.Add(colDefs[i]);
            }

            RowDefinition[] rowDefs = new RowDefinition[8];
            for (int i = 0; i < 8; i++)
            {
                rowDefs[i] = new RowDefinition();
                gridMain.RowDefinitions.Add(rowDefs[i]);
            }

            decimal x = 0;
            textBlockMatrix = new Button[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    x += 1;
                    textBlockMatrix[i, j] = new Button();
                    if (i == 0 & j == 3)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/k.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 3)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/k.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 0 & j == 4)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/q.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 4)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("/pion/q.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 1 & j < 8)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/p.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 6 & j < 8)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/p.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 0 & j == 0)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/t.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 0 & j == 7)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/t.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 0)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/t.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 0)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/t.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 0 & j == 2)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 0 & j == 5)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 2)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 5)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 0 & j == 1)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 0 & j == 6)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 1)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 6)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("pion/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if ((i + j) % 2 == 0)
                    {
                        textBlockMatrix[i, j].Background = Brushes.White;
                    }
                    else
                    {
                        textBlockMatrix[i, j].Background = Brushes.Black;
                    }



                    Grid.SetRow(textBlockMatrix[i, j], i);
                    Grid.SetColumn(textBlockMatrix[i, j], j);
                    gridMain.Children.Add(textBlockMatrix[i, j]);

                }
            }
        }
    }
}