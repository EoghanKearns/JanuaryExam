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

namespace Q1
{
    // github link - https://github.com/EoghanKearns/JanuaryExam

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // GetData method called
            GetData();
        }

        private List<Team> GetData()
        {
            // creates teams
            List<Team> teams = new List<Team>();
            // create teams 
            Team t1 = new Team() { Name = "France" };
            Team t2 = new Team() { Name = "Italy" };
            Team t3 = new Team() { Name = "Spain" };

            // adds them to list
            teams.Add(t1);
            teams.Add(t2);
            teams.Add(t3);

            // displays in list box
            lbxTeams.ItemsSource = teams;

            return teams;
        }
    }
}
