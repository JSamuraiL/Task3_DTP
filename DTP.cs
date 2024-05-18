using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class DTP:List<Transport>
    {
        public void CollectParticipant() 
        {
            var SortByDTPParticipant =
            from transport in this 
            where transport.DTPParticipant == true 
            select transport;

            Console.Write($"Список участников ДТП: ");

            foreach (var transport in SortByDTPParticipant)
            {
                Console.Write(transport.Car_number + " ");
            }
        }
    }
}
