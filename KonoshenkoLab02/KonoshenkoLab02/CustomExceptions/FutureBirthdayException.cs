using System;

namespace KMA.ProgrammingInCSharp2019.KonoshenkoLab02.CustomExceptions
{
    namespace KMA.ProgrammingInCSharp2019.KonoshenkoLab02.CustomExceptions
    {
        class FutureBirthdayException : Exception
        {
            private string _message;
            private DateTime? _badDate;

            public FutureBirthdayException(string message, DateTime badDate)
            {
                _badDate = badDate;
                _message = message;
            }

            public FutureBirthdayException(DateTime badDate)
            {
                _badDate = badDate;
                _message = $"Bad date(future date of birth): {_badDate.ToString()}";
            }

            public FutureBirthdayException(string message)
            {
                _message = message;
            }

            public override string Message
            {
                get => _message;
            }

        }
    }

}
