using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOpeningGoalGuesses
{
    public class GuessData
    {
        private string _time;
        public string Time
        {
            get { return _time; }
            set
            {
                string trimmedInput = value.Trim();
                string expectedPattern = "\\d{1,2}[.:-]\\d{2}";
                if (System.Text.RegularExpressions.Regex.IsMatch(trimmedInput, expectedPattern)) _time = trimmedInput;
                else throw new ArgumentException("Time of opening goal in invalid pattern - please give two pairs of digits separated with one of the following: ., : or -.", "Time");
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
