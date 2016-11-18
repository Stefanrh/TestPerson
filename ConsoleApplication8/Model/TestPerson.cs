using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8.Model
{
    public class TestPerson
    {
        string someName;


        public string SomeName
        {
            get { return someName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Sometext must not be empty or null");
                }
                someName = value;
            }
        }

        int someAge;

        public int SomeAge
        {
            get { return someAge; }
            set
            {
                if (value < 0 || 130 > value)
                {
                    throw new ArgumentException("somenumber must be in range 0-130");
                }
                someAge = value;
            }
        }
    }
}
