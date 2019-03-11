using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KMA.ProgrammingInCSharp2019.KonoshenkoLab02.CustomExceptions;
using KMA.ProgrammingInCSharp2019.KonoshenkoLab02.CustomExceptions.KMA.ProgrammingInCSharp2019.KonoshenkoLab02.CustomExceptions;

namespace KMA.ProgrammingInCSharp2019.KonoshenkoLab02
{
    internal class Validator
    { 

        public static void CheckBirthday(DateTime dateOfBirth)
        {
            if(dateOfBirth > DateTime.Today)
                throw new FutureBirthdayException("Unborn people!");
            if(DateTime.Today.Year - dateOfBirth.Year > 135)
                throw new PastBirthdayException("Too old people!");
        }

        public static void CheckEmail(string email)
        {
            if (!CorrectEmail(email))
                throw new InvalidEmailException("Wrong email");
        }

        public static bool CorrectEmail(string email)
        {
            if (email.Length < 3 || email.Count(f => f == '@') != 1 ||
                (email.IndexOf("@", StringComparison.Ordinal) == email.Length - 1) ||
                (email.IndexOf("@", StringComparison.Ordinal) == 0))
                return false;
            return true;
            
        }

        public static void CheckFirstName(string firstName)
        {
            if(firstName.Length < 3)
                throw new WrongFirstNameException($"Too small name: {firstName}");
        }

        public static void CheckLastName(string lastName)
        {
            if(lastName.Length < 3)
                throw new WrongLastNameException($"Too small last name: {lastName}");
        }
    }
}
