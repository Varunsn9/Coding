using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Types
{
    
    public enum RootVegetables
    {
        Raddish,
        Carrot,
        Potato
    }
    [Flags]
    public enum Seasons {
    
        None = 0,
        Summer = 1,
        Autumn = 2,
        Winter = 4,
        Spring = 8,
        All= Summer | Autumn | Winter | Spring
    }
    internal class EnumsTypes
    {
        public static void Main()
        {
            var Raddish=RootVegetables.Raddish;
            var Spring=Seasons.Spring;
            var startingOnEqivnox=Seasons.Spring | Seasons.All;
            var TheYear = Seasons.All;
        }

    }
}
