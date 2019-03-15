using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace KMA.ProgrammingInCSharp2019.KonoshenkoLab02
{
    class InformationViewModel:INotifyPropertyChanged
    {
        private readonly Person _person;


        public string FirstName => $"First Name: {_person.FirstName}";
        public string LastName => $"Last Name: {_person.LastName}";
        public string Email => $"Email: {_person.Email}";
        public string DateOfBirth => $"Date of birth: {_person.DateOfBirth.ToShortDateString()}";
        public string IsAdult => $"You are {(_person.IsAdult ? "adult" : "not adult")}";
        public string SunSign => $"Sun sign: {_person.SunSign}";
        public string ChineseSign => $"Chinese sign: {_person.ChineseSign}";
        public string IsBirthday => $"Your birthday is {(_person.IsBirthday ? "today" : "not today")}";


        public InformationViewModel(Person person)
        {
            _person = person;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
