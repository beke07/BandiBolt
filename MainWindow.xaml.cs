using Bolt.Dal;
using Bolt.Model;
using System.Windows;

namespace Bolt
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new Aru();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                dbContext.Arucikkek.Add((Aru)DataContext);
                dbContext.SaveChanges();
            }
        }
    }
}
