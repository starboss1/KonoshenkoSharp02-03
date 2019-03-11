using System;

namespace KMA.ProgrammingInCSharp2019.KonoshenkoLab02.CustomExceptions
{
    class PastBirthdayException : Exception
    {
        private string _message;
        private DateTime? _badDate;

        public PastBirthdayException(string message, DateTime badDate)
        {
            _badDate = badDate;
            _message = message;
        }

        public PastBirthdayException(DateTime badDate)
        {
            _badDate = badDate;
            _message = $"Bad date(>135): {_badDate.ToString()}";
        }

        public PastBirthdayException(string message)
        {
            _message = message;
        }

        public override string Message
        {
            get => _message;
        }

    }
}
