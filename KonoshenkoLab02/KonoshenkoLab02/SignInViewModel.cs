using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;  
using System.Threading.Tasks;
using System.Windows;
using KMA.ProgrammingInCSharp2019.KonoshenkoLab02.Tools;
using KMA.ProgrammingInCSharp2019.KonoshenkoLab02.Tools.Managers;


namespace KMA.ProgrammingInCSharp2019.KonoshenkoLab02
{
    class SignInViewModel: ILoaderOwner
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime _dateOfBirth = DateTime.Today;
        private RelayCommand _signInCommand;
        private Visibility _loaderVisibility = Visibility.Hidden;
        private bool _isControlEnabled = true;

        public Visibility LoaderVisibility
        {
            get { return _loaderVisibility; }
            set
            {
                _loaderVisibility = value;
                OnPropertyChanged();
            }
        }

        public bool IsControlEnabled
        {
            get { return _isControlEnabled; }
            set
            {
                _isControlEnabled = value;
                OnPropertyChanged();
            }
        }

        private readonly Window _parentWindow;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                _dateOfBirth = value;
                OnPropertyChanged();
            }
        }


        private async void SignIn(object o)
        {
            LoaderManager.Instance.ShowLoader();
            Person person = null;
            await Task.Run((() =>
            {
                try
                {
                    person = new Person(_firstName, _lastName, _email, _dateOfBirth);
                    MessageBox.Show($"Please wait, {(person.IsBirthday ? "birthday boy(Vy staly na rik starishym =)(Za smailik sorri(opyat'))" : "traveler")}");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    LoaderManager.Instance.HideLoader();
                }
             

            }));
            if (person == null)
                return;
            InformationWindow personWindow = new InformationWindow(person);
            LoaderManager.Instance.HideLoader();
            _parentWindow.Hide();
            personWindow.Show();
        }

        internal SignInViewModel(Window parentWindow)
        {
            _parentWindow = parentWindow;
            LoaderManager.Instance.Initialize(this);
        }

        public RelayCommand RegisterCommand
        {
            get
            {
                return _signInCommand ?? (_signInCommand = new RelayCommand(SignIn,
                           o => !String.IsNullOrWhiteSpace(_firstName) &&
                                !String.IsNullOrWhiteSpace(_lastName) &&
                                !String.IsNullOrWhiteSpace(_email)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
