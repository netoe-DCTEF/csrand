using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
                                            MADE BY ELY NETO 27/12/2022
 */
namespace RandForCs
{
    class Rand
    {
        List<int> drawnNumbers = new List<int>();

        void Start()
        {
            clearList();
        }
        public void clearList()
        {
            drawnNumbers.Clear();
        }

        public int generateNumbers(int limit)
        {
            System.Random random = new System.Random();
            int drawn;
            
            do
            {
                drawn = random.Next(0,limit);
            }
            while (drawnNumbers.Contains(drawn));

            drawnNumbers.Add(drawn);
             
            return drawn;
        }
    }
}
