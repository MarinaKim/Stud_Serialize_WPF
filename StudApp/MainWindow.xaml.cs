using Stud_Serialize.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace StudApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public MainWindow()
        {
            InitializeComponent();           

            BinaryFormatter formater = new BinaryFormatter();
            List<Group> ListGroup = new List<Group>();
            using (FileStream fs = new FileStream("ListSerialGroup.dat", FileMode.OpenOrCreate))
            {
                try
                {
                    ListGroup = (List<Group>)formater.Deserialize(fs);
                    lvGroup.ItemsSource = ListGroup.ToList();
                }
                catch { }
            }
        }

        private void lvGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView lw = (ListView)sender;
            Group group = (Group)lw.SelectedItem;

            lvStud.ItemsSource = group.Students.ToList();          
        }
    }
}
