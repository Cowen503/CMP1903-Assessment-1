using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public Pack()
        {
            
            int ind1 = 0;
            int ind2 = 0;
            for(int ind1 = 1; ind1 <= 4; ind1++)
            {
                for (int ind2 = 1; ind2 <= 13; ind2++)
                {
                    Card card = new Card;
                    card.Suit = ind1;
                    card.Value = ind2;
                    pack.Add(card);
                }
            }
            
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle

        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
    }
}
