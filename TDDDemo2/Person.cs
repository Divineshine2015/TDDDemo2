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
        public int Age { get; set; }
        public bool? CanVote { get; set; }
        public int SocSecNum { get; set; } 
        
        public object CalculateAge(DateTime input)
        {
            throw new NotImplementedException();
        }
    }
}
