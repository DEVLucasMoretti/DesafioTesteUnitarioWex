using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SystemCalculator
    {
        private List<string> listHistoric;
        public SystemCalculator()
        {
            listHistoric = new List<string>();
        }
        public int sum(int v1, int v2)
        {
            int res = v1 + v2;
            listHistoric.Insert(0, "Res " + res);
            return res;
        }
        public int sub(int v1, int v2)
        {
            return v1-v2;
        }
        public int mult(int v1, int v2)
        {
            return v1*v2;
        }
        public int div(int v1, int v2)
        {
            return v1/v2;
        }

        public List<string> historic()
        {
            listHistoric.RemoveRange(3, listHistoric.Count - 3);
            return new List<string>(); 
        }

    }
}
