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

namespace Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_KlickMich_Click(object sender, RoutedEventArgs e)
        {
            if (Cbx_Haken.IsChecked == true)
                Lbl_Output.Content = (Cbb_Auswahl.SelectedItem as ComboBoxItem)?.Content;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Lbl_Output.Content = (sender as Slider).Value.ToString();
        }

        private void Schließen_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Soll das Fenster wirklich geschlossen werden?", "Schließen", MessageBoxButton.YesNo, MessageBoxImage.Warning)==MessageBoxResult.Yes)
                this.Close();

            //Application.Current.Shutdown();
        }

        private void Öffnen_Click(object sender, RoutedEventArgs e)
        {
            Window wnd = new MainWindow();

            wnd.Title = "Neues Fenster";

            wnd.Show();
        }

        private void Dialog_Click(object sender, RoutedEventArgs e)
        {
            Window wnd = new MainWindow();

            wnd.Title = "Neues Dialog-Fenster";

            if (wnd.ShowDialog() == true)
                Lbl_Output.Content = "Es wurde auf OK geklickt";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

            this.Close();
        }
    }
}
