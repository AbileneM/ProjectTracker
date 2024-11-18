using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfMvvmUA2.ViewModel;
using WpfMvvmUA2.Views.Controls;

namespace WpfMvvmUA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainView mainView = new MainView();
            this.DataContext = mainView;
        }

        private void sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedMenu = sidebar.SelectedItem as NavButton;

            navframe.Navigate(selectedMenu.Navlink);
        }

        //private void Window_ContentRendered(object sender, EventArgs e)
        //{
        //    BackgroundWorker worker = new BackgroundWorker();
        //    worker.WorkerReportsProgress = true;
        //    worker.DoWork += worker_DoWork;
        //    worker.ProgressChanged += worker_ProgressChanged;

        //    worker.RunWorkerAsync();
        //}

        //void worker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        (sender as BackgroundWorker).ReportProgress(i);
        //        Thread.Sleep(100);
        //    }
        //}

        //void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    ProgressBar progressBar = new ProgressBar();
        //    progressBar.Value = e.ProgressPercentage;
        //}
    }
}