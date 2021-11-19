using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAsa.Models
{
    public class FeverTemp
    {
        public static string TestForFever(float temperature)
        {
            //double dubbleTemp = new double();

            return (temperature > 37) ? "...have a cookie" : "Doctor says your temperature is nornal you don't have Fever...so no cookie";
        }
    }

}
 