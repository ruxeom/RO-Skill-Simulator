using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Tuple <T, U>
    {
        public T key;
        public U value;

        public Tuple()
        {
 
        }

        public Tuple(T t, U u)
        {
            key = t;
            value = u;
        }
        static int main()
        {
            Tuple<int, String> tup = new Tuple<int, String>();
            Tuple<int, String> tus = new Tuple<int, String>(5, "h");
            Console.WriteLine();
            
            return 0;
        }
    }
}
