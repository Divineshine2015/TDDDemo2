using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDDemo2;
using Xunit;

namespace PersonTest
{
    public class PersonTest
    {
        [Fact]
        public void DoesAgeValueGetComputed()
        {
            var input = new DateTime(1/1/1990);
            var engine = new Person();
            var answer = engine.CalculateAge(input);
            var now = DateTime.Now;
            var expected = now.Year - input.Year;

            Assert.Equal(expected, answer);
        }


        [Fact]
        public void TestCanPersonVote()
        {
          
            var age=17;
            var engine = new Person();
            var answer = engine.CanPersonVote(age);          
            var expected =false;

            Assert.Equal(expected, answer);
        }

        [Fact]
        public void CanPersonNameBeChanged()
        {
            var engine = new Person();
            engine.FirstName = "Justin";
            engine.LastName = "Langley";
            var name = engine.Name;
            var answer = engine.CanNameBeChanged(name);

            Assert.NotEqual(name, answer);
        }
        [Fact]
        public void FormatLastNameFirst()
        {
            var engine = new Person();
            engine.FirstName = "Justin";
            engine.LastName = "Langley";
            var testName = engine.FirstName + " " + engine.LastName;
            var lastThenFirst = engine.LastName + " " + engine.FirstName;
            var expected = lastThenFirst;
            var answer = engine.FormatToLastthenFirst(testName);

            Assert.Equal(expected, answer);
        }
        [Fact]
        public void FirstNameLastNameStringFormat()
        {
            var engine = new Person();
            engine.FirstName = "Justin";
            engine.LastName = "Langley";
            var testName = engine.LastName + " " + engine.FirstName;
            var firstThenLast = engine.FirstName + " " + engine.LastName;
            var answer = engine.IsStringFirstNameLastName(testName);
            var expected = firstThenLast;
            Assert.Equal(expected, answer);
        }


        
    }
}
