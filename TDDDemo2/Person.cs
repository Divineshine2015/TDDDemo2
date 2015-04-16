using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDDemo2
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string Name { get { return LastName + FirstName; } }
        private int Age { get { return (DateTime.Now.Year - BirthDate.Year); } }
        private DateTime BirthDate { get; set; }
        public bool CanVote { get; set; }
        public int SocSecNum { get; set; } 
        
        public int CalculateAge(DateTime input)

        {
            BirthDate = input;

            return Age;
        }
        public bool CanPersonVote(int age)
        {
            var PersonAge = age;
            if (PersonAge >= 18)
           
            {
                CanVote = true;
            }
            else
            {
                CanVote = false;
            }
            return CanVote;
        }

    }
}
