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
using System.Windows.Shapes;

namespace TheMoviesScenarie1_Bo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class FilmView : Window
    {
        FilmViewModel fvm = new FilmViewModel();
        public FilmView()
        {
            InitializeComponent();
            DataContext = fvm;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            fvm.AddFilm(fvm.Title, fvm.Genre, fvm.Duration);

            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}