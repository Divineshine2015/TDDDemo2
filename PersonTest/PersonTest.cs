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

    }
}
