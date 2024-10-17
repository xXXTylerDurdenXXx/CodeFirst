using CodeFirst.DataModel;
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

namespace CodeFirst
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        List<string> helo = new List<string>();
        Player player;
        public MainWindow()
        {
            InitializeComponent();
            using (PlayerCon context = new PlayerCon())
            {

                //Player player = new Player();
                //Team team = new Team();



                //player.NameP = "Povard";
                //player.Number = 2;
                //player.pos = Pos.Defender;
                //player.Country = "Russia";

                //context.Players.Add(player);
                //team.player = player;
                //team.NameT = "Japan";
                //team.IdP = player.IdP;
                //context.Teams.Add(team);
                //context.SaveChanges();
                helo.Clear();
                helo.Add("Id");
                helo.Add("Name");
                

                com.ItemsSource = helo;
                tab.ItemsSource = context.Players.ToList();
            }
        }

        private void com_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string str = com.SelectedItem.ToString();
            PlayerCon context = new PlayerCon();
            var zz = context.Players;
            if(str == "Id") tab.ItemsSource = zz.OrderByDescending(g => g.IdP).ToList();
            else if(str == "Name") tab.ItemsSource = zz.OrderByDescending(g => g.NameP).ToList();

        }
    }
}
