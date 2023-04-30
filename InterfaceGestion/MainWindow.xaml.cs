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

namespace InterfaceGestion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double baseWidth = 800;
        public MainWindow()
        {
            InitializeComponent();
            this.SizeChanged += Fonction;
        }
        private void Fonction(object sender, SizeChangedEventArgs e)
        {
            double scaleFactor = this.ActualWidth / baseWidth; // calcule le facteur d'échelle en fonction de la largeur actuelle de la fenêtre

            Btterminer.FontSize = 18 * scaleFactor; // adapte la taille de police en fonction du facteur d'échelle
            Chemindacces.FontSize = 18 * scaleFactor;
            Couleurdefond.FontSize = 18 * scaleFactor;
            FieldCheminacces.FontSize = 18 * scaleFactor;
            FieldCouleurdefond.FontSize = 18 * scaleFactor;

        }
    }
}
