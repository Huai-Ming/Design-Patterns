using StatePattern.BookUserLevel;
using StatePattern.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //#region Book User Level
            //User user = new User("Hyman");
            //user.BuyBook(2000);
            //user.BuyBook(2000);
            //user.BuyBook(2000);
            //user.BuyBook(2000);
            //Console.Read();
            //#endregion

            #region State patter structure
            Context context = new Context();
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            Console.Read();
            #endregion
        }
    }
}
