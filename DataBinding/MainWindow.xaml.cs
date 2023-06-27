using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        public ObservableCollection<Person> Personenliste { get; set; } = new ObservableCollection<Person>()
        {
            new Person(){Name = "Rainer Zufall", Alter=54},
            new Person(){Name = "Anna Nass", Alter=23},
        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person p = Spl_DataContextBsp.DataContext as Person;
            MessageBox.Show($"{p.Name} ({p.Alter})");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            (Spl_DataContextBsp.DataContext as Person).Alter++;
            (Spl_DataContextBsp.DataContext as Person).OnPropertyChanged("Alter");
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            Personenliste.Add(new Person() { Name = "Jürgen Meier", Alter = 76 });
        }

        private void Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (Lbx_Personen.SelectedItem is Person)
                Personenliste.Remove(Lbx_Personen.SelectedItem as Person);
        }
    }
}
