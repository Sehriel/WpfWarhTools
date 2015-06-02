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

using WarhRessources;
using DAOBuilder;
using DAOs.DAOInterface;

namespace WpfWarhTools
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// Pour le moment, sert de support pour les tests
    /// des ViewModels
    /// 
    /// Implémentera les mêmes fonctionnalités que la 
    /// version Winform
    /// 
    /// Fonctionnalités :
    /// *Barre des menus
    /// *Barre sur la droite (qui ne sera pas forcément
    /// que des boutons)
    /// *Panel affichant le contrôle en cours 
    /// d'utilisation
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            IModel_PersoCreator Source = Builder.GetDAO();

            
            List<DAOs.DAO_Core.Talent> liste = new List<DAOs.DAO_Core.Talent>();
            Source.LoadTalents(liste);

            List<ViewTalent> listeView = new List<ViewTalent>();

            foreach (DAOs.DAO_Core.Talent t in liste)
            {
                ViewTalent tal = new ViewTalent(t);
                listeView.Add(tal);

            }

        }

    }
}
