using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Testing
    {

        public void shuffleCardTest()
        {
            Pack pack1 = new Pack();
            Pack.shuffleCardPack(1);
            Pack.currentPack();
        }
        public void dealTest()
        {
            Pack pack2 = new Pack();
            Pack.deal();
            Pack.currentPack();
        }
        public void multDealTest()
        {
            Pack pack3 = new Pack();
            Pack.dealCard(52);
            Pack.currentPack();
        }
    }
}