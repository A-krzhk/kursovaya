using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs
{
    public class Id
    {
        public int number;
        public int Number
        {
            get => number;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                number = value;
            }

        }
        //оно абсолютно уникальным не будет, но вероятность совпадений оч низкая
        public int GenerateID()
        {
            return Int32.Parse(Guid.NewGuid().ToString());
        }
    }
}
