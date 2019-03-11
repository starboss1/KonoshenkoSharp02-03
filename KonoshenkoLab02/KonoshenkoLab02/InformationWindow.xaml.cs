using System;
using System.Windows;


namespace KMA.ProgrammingInCSharp2019.KonoshenkoLab02
{
    /// <summary>
    /// Логика взаимодействия для InformationWindow.xaml
    /// </summary>
    public partial class InformationWindow : Window
    {
        public InformationWindow(Person person)
        {
            InitializeComponent();
            DataContext = new InformationViewModel(person);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
    }
}
