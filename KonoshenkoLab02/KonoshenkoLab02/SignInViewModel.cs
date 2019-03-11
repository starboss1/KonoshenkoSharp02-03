using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;


namespace KMA.ProgrammingInCSharp2019.KonoshenkoLab02
{
    class SignInViewModel: INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime _dateOfBirth = DateTime.Today;
        private RelayCommand _signInCommand;

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
            //if (!IsDateValid(_dateOfBirth))
            //{
            //    MessageBox.Show($"Wrong date: {_dateOfBirth}");
            //    return;
            //}


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
                }
             

            }));
            if (person == null)
                return;
            InformationWindow personWindow = new InformationWindow(person);

            _parentWindow.Hide();
            personWindow.Show();
        }

        internal SignInViewModel(Window parentWindow)
        {
            _parentWindow = parentWindow;
        }

        public RelayCommand RegisterCommand
        {
            get
            {
                return _signInCommand ?? (_signInCommand = new RelayCommand(SignIn,
                           //o => true));
                           o => !String.IsNullOrWhiteSpace(_firstName) &&
                                !String.IsNullOrWhiteSpace(_lastName) &&
                                !String.IsNullOrWhiteSpace(_email) /*&&*/
                /*IsDateValid(_dateOfBirth)*/));
            }
        }


        //private bool IsDateValid(DateTime date)
        //{
        //    var today = DateTime.Today;
        //    var diffDateTime = today - date;
        //    var diffYears = (today.Year - date.Year) - (today.DayOfYear >= date.DayOfYear ? 0 : 1);
        //    return diffDateTime.Days >= 0 && diffYears <= 135;
        //}




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
