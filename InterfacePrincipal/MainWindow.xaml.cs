using System;
using System.Collections.Generic;
using System.Data;
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
using InterfaceGestion;

namespace InterfacePrincipal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double baseWidth = 800;
        private double baseHeight = 1080;
        public MainWindow()
        {
            InitializeComponent();
            this.SizeChanged += Fonction;
        }
        private void Fonction(object sender, SizeChangedEventArgs e)
        {
            double scaleFactor = this.ActualWidth / baseWidth; // calcule le facteur d'échelle en fonction de la largeur actuelle de la fenêtre

            BtRecherche.FontSize = 16 * scaleFactor; // adapte la taille de police en fonction du facteur d'échelle
            FieldRecherche.FontSize = 14 * scaleFactor;
            LyricsTextbox.FontSize = 14 * scaleFactor;
            LibeleTitre.FontSize = 14 * scaleFactor;
            TextTitre.FontSize = 14 * scaleFactor;
            LibeleArtiste.FontSize = 14 * scaleFactor;
            TextArtiste.FontSize = 14 * scaleFactor;
            LibeleAlbum.FontSize = 14 * scaleFactor;
            TextAlbum.FontSize = 14 * scaleFactor;
            LibeleDate.FontSize = 10 * scaleFactor;
            TextDate.FontSize = 14 * scaleFactor;
            LibeleProducteur.FontSize = 10 * scaleFactor;
            TextProducteur.FontSize = 14 * scaleFactor;
            BtConfiguration.FontSize = 16 * scaleFactor;
            BtPush.FontSize = 16 * scaleFactor;
            LyricsTextbox.FontSize = 14 * scaleFactor;
            GrpbLyrics.FontSize = 14 * scaleFactor;
            LibeleDateMin.FontSize = 14 * scaleFactor;
            TextDateMin.FontSize = 14 * scaleFactor;
            LibeleProducteurMin.FontSize = 14 * scaleFactor;
            TextProducteurMin.FontSize = 14 * scaleFactor;
            TextHistorique.FontSize = 18 * scaleFactor;
            historique.Height = MainGrid.RowDefinitions[2].ActualHeight;
            historique.Width = MainGrid.ColumnDefinitions[1].ActualWidth;


            if (this.ActualHeight < 800)
            {
                GrpbLyrics.Visibility = Visibility.Collapsed;
                LyricsTextbox.Visibility = Visibility.Visible;
                RowDateProd.Height = new GridLength(0, GridUnitType.Pixel);
                RowDateProdMin.Height = new GridLength(1, GridUnitType.Star);
                ColumHist.Width = new GridLength(0, GridUnitType.Pixel);
            }
            else 
            {
                GrpbLyrics.Visibility = Visibility.Visible;
                LyricsTextbox.Visibility = Visibility.Visible;
                RowDateProdMin.Height = new GridLength(0, GridUnitType.Pixel);
                RowDateProd.Height = new GridLength(1, GridUnitType.Star);
                ColumHist.Width = new GridLength(0.33, GridUnitType.Star);
            }
            if(this.ActualWidth < 1200)
            {
                ColumHist.Width = new GridLength(0, GridUnitType.Pixel);
            }
            else
            {
                ColumHist.Width = new GridLength(0.33, GridUnitType.Star);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InterfaceGestion.MainWindow Ig = new InterfaceGestion.MainWindow();
            Ig.Owner = this; // définit la fenêtre parent comme propriétaire
            Ig.Show();

        }
    }

}
