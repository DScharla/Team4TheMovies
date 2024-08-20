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
using theMovies;

namespace TheMoviesScenarie1.View
{
    /// <summary>
    /// Interaction logic for FilmView.xaml
    /// </summary>
    public partial class FilmView : Window
    {
        MainViewModel mvm = new MainViewModel();

        public FilmView()
        {
            
            InitializeComponent();

            DataContext = mvm;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            mvm.AddFilm(mvm.Name, mvm.Genre, mvm.Duration);
            this.Close();
        }
    }
}
