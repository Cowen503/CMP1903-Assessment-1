using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        static List<Card> pack;
        public int ind1;
        public int ind2;
        static List<Card> tempPack1;
        static List<Card> tempPack2;
        static List<Card> dealt;
        public Pack()
        {
            //Initialise the card pack here
            for (int ind1 =1; ind1 <= 4; ind1++)
            {
                for (int ind2 =1; ind2 <= 13; ind2++)
                {
                    Card card = new Card();
                    card.Suit = ind1;
                    card.Value = ind2;
                    pack.Add(card);
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {

            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1) //Fisher-Yates
            {
                int packsize = 51;
                Card tempcard;
                foreach(Card card in pack){
                    Random rnd = new Random();
                    int num = rnd.Next(0,packsize+1);
                    tempcard = pack[packsize];
                    pack[packsize] = pack[num];
                    pack[num] = tempcard;
                    packsize--;
                }
                return true;
            }
            else if(typeOfShuffle == 2) //Riffle
            {
                int halfcount = pack.Count / 2;

                for (int i = 0; i < halfcount; i++)
                {
                    tempPack1.Add(pack[0]);
                    pack.RemoveAt(0);
                }
                for (int i = 0; i < halfcount; i++)
                {
                    tempPack2.Add(pack[0]);
                    pack.RemoveAt(0);
                }
                for (int i = 0; i < halfcount; i++)
                {
                    pack.Add(tempPack1[i]);
                    pack.Add(tempPack2[i]);
                }
                return true;
            }

            else if(typeOfShuffle == 3)
            {
                return true;
            }
        }
        public static Card deal()
        {
            Card card = pack[0];
            pack.RemoveAt(0);
            return card;
        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            for (int i=0; i<amount; i++)
            {
                dealt.Add(pack[0]);
                pack.RemoveAt(0);
            }
        }
        public static void currentPack()
        {
            for(int i = 0; i <pack.Count; i++)
            {
                Console.WriteLine(pack[i].Suit.ToString() + " " + pack[i].Value.ToString());
            }
        }
    }
}
