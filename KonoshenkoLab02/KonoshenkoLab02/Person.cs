using System;

namespace KMA.ProgrammingInCSharp2019.KonoshenkoLab02
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime _dateOfBirth;

        public Person(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _dateOfBirth = dateOfBirth;
        }

        public Person(string firstName, string lastName, string email)
            :this(firstName, lastName, email, DateTime.Today)
        {
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
            : this(firstName, lastName, "No Email", dateOfBirth)
        {

        }

        public bool IsAdult
        {
            get
            {
                DateTime today = DateTime.Today;
                var a = (today.Year * 100 + today.Month) * 100 + today.Day;
                var b = (_dateOfBirth.Year * 100 + _dateOfBirth.Month) * 100 + _dateOfBirth.Day;
                return (a - b) / 10000 >= 18;
            }
        }

        public string SunSign
        {
            get
            {
                var day = _dateOfBirth.Day;
                int westZodiacNum;
                switch (_dateOfBirth.Month)
                {
                    case 1: //Jan
                        westZodiacNum = day <= 20 ? 9 : 10;
                        break;
                    case 2: //Feb
                        westZodiacNum = day <= 19 ? 10 : 11;
                        break;
                    case 3: //Mar
                        westZodiacNum = day <= 20 ? 11 : 0;
                        break;
                    case 4: //Apr
                        westZodiacNum = day <= 20 ? 0 : 1;
                        break;
                    case 5: //May
                        westZodiacNum = day <= 20 ? 1 : 2;
                        break;
                    case 6: //Jun
                        westZodiacNum = day <= 20 ? 2 : 3;
                        break;
                    case 7: //Jul
                        westZodiacNum = day <= 21 ? 3 : 4;
                        break;
                    case 8: //Aug
                        westZodiacNum = day <= 22 ? 4 : 5;
                        break;
                    case 9: //Sep
                        westZodiacNum = day <= 21 ? 5 : 6;
                        break;
                    case 10: //Oct
                        westZodiacNum = day <= 21 ? 6 : 7;
                        break;
                    case 11: //Nov
                        westZodiacNum = day <= 21 ? 7 : 8;
                        break;
                    case 12: //Dec
                        westZodiacNum = day <= 21 ? 8 : 9;
                        break;
                    default:
                        westZodiacNum = 0;
                        break;
                }

                return WesternZodiaсList[westZodiacNum];
            }
        }

        public string ChineseSign => ChineseZodiaсList[(_dateOfBirth.Year - 5) % 12];

        public bool IsBirthday => _dateOfBirth.DayOfYear == DateTime.Today.DayOfYear;


        private static readonly string[] ChineseZodiaсList = {"Rat","Ox","Tiger","Rabbit",
            "Dragon","Snake","Horse","Goat","Monkey","Rooster","Dog","Pig"
        };

        private static readonly string[] WesternZodiaсList = {"Aries","Taurus","Gemini","Cancer",
            "Leo","Virgo","Libra","Scorpio","Sagittarius","Capricorn","Aquarius","Pisces"
        };
    }
}
