using Bolt.Dal;
using Bolt.Model;
using System.Windows;

namespace Bolt
{
    public partial class MainWindow : Window
    {
        private static ApplicationDbContext DbContext;

        public MainWindow()
        {
            DataContext = new Aru();
            InitializeComponent();
        }

        public MainWindow(ApplicationDbContext dbContext) : this()
        {
            DbContext = dbContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DbContext.Arucikkek.Add((Aru)DataContext);
            DbContext.SaveChanges();
        }
    }
}
