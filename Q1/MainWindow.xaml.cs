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
        List<Player> Players = new List<Player>();

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

            // create players

            //French players
            Player p1 = new Player() { Name = "Marie", ResultRecord = "WWDDL" };
            Player p2 = new Player() { Name = "Claude", ResultRecord = "DDDLW" };
            Player p3 = new Player() { Name = "Antoine", ResultRecord = "LWDLW" };

            //Italian players
            Player p4 = new Player() { Name = "Marco", ResultRecord = "WWDLL" };
            Player p5 = new Player() { Name = "Giovanni", ResultRecord = "LLLLD" };
            Player p6 = new Player() { Name = "Valentina", ResultRecord = "DLWWW" };

            //Spanish players
            Player p7 = new Player() { Name = "Maria", ResultRecord = "WWWWW" };
            Player p8 = new Player() { Name = "Jose", ResultRecord = "LLLLL" };
            Player p9 = new Player() { Name = "Pablo", ResultRecord = "DDDDD" };

            // add players to players list
            Players.Add(p1);
            Players.Add(p2);
            Players.Add(p3);
            Players.Add(p4);
            Players.Add(p5);
            Players.Add(p6);
            Players.Add(p7);
            Players.Add(p8);
            Players.Add(p9);

            // add players to teams
            t1.Players.Add(p1);
            t1.Players.Add(p2);
            t1.Players.Add(p3);
            t2.Players.Add(p4);
            t2.Players.Add(p5);
            t2.Players.Add(p6);
            t3.Players.Add(p7);
            t3.Players.Add(p8);
            t3.Players.Add(p9);

            lbxPlayers.ItemsSource = Players;
            return teams;
        }

        private void lbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetData();
        }
    }
}
