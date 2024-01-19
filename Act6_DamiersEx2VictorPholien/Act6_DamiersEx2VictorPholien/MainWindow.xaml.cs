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

namespace Act6_DamiersEx2VictorPholien
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
            prepareInterface();
        }

        public void prepareInterface()
        {

            ColumnDefinition[] colDefs = new ColumnDefinition[10];
            for (int i = 0; i < 10; i++)
            {
                colDefs[i] = new ColumnDefinition();
                grdMain.ColumnDefinitions.Add(colDefs[i]);
            }

            // Définition des lignes
            RowDefinition[] rowDefs = new RowDefinition[10];
            for (int i = 0; i < 10; i++)
            {
                rowDefs[i] = new RowDefinition();
                grdMain.RowDefinitions.Add(rowDefs[i]);
            }

            // Initialisation de la matrice Text
            decimal x = 1; // Commencer à partir de 1
            textBlockMatrix = new Button[10, 10];
            for (int i = 0; i < 10; i++)
            {
                int direction = (i % 2 == 0) ? 1 : -1;

                for (int j = 0; j < 10; j++)
                {
                    int columnIndex = (direction > 0) ? j : 9 - j;
                    textBlockMatrix[i, columnIndex] = new Button();
                    textBlockMatrix[i, columnIndex].Content = x.ToString();
                    textBlockMatrix[i, columnIndex].FontSize = 20;
                    textBlockMatrix[i, columnIndex].Foreground = Brushes.Red;

                    if ((i + columnIndex) % 2 == 0)
                    {
                        textBlockMatrix[i, columnIndex].Background = Brushes.Black;
                    }
                    else
                    {
                        textBlockMatrix[i, columnIndex].Background = Brushes.White;
                    }

                    Grid.SetRow(textBlockMatrix[i, columnIndex], i);
                    Grid.SetColumn(textBlockMatrix[i, columnIndex], columnIndex);
                    grdMain.Children.Add(textBlockMatrix[i, columnIndex]);

                    x++;

                }
            }
        }
    }
}
