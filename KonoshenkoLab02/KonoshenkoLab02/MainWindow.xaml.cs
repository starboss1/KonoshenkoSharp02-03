using System.Windows;

namespace KMA.ProgrammingInCSharp2019.KonoshenkoLab02
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new SignInViewModel(this);
        }
    }
}
