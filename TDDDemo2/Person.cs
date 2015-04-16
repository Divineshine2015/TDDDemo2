using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDDemo2
{
    public class Person : IComparable<Person>
    {
        public string FirstName;
        public string LastName;
        public string Name{get{return (LastName + FirstName); } }

        Person JustinLangley = new Person()
            {
                FirstName = "Justin",
                LastName = "Langley",
                BirthDate = new DateTime(1979, 5, 4),
                CanVote = true,
                SocSecNum = 123456789
            };

        Person JonReed = new Person()
            {
                FirstName = "Jonathan",
                LastName = "Reed",
                BirthDate = new DateTime(1978, 7, 27),
                CanVote = true,
                SocSecNum = 987654321
            };
        

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
        

        public object CanNameBeChanged(string name)
            {
            var fName="Jon";
            var lName ="Reed";

            var newName=fName+lName;
            
            if (name != newName)
            {
                return newName;
            }

            return name;
        }

    
        public object IsStringFirstNameLastName(string lastThenFirst)
            {
                string [] firstThenLast = lastThenFirst.Split(' ');
                string answer = firstThenLast[1] + " " + firstThenLast[0];
                return answer;              
            }

        public object FormatToLastthenFirst(string firstThenLast)
        {
            string[] lastThenFirst = firstThenLast.Split(' ');
            string answer = lastThenFirst[1] + " " + lastThenFirst[0];
            return answer; 
        }
    }
}
