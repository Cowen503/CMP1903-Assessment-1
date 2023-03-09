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
            for (int ind1 =1; ind1 <= 4; ind1++) //Iterates through suits
            {
                for (int ind2 =1; ind2 <= 13; ind2++) //Iterates through values
                {
                    Card card = new Card();
                    card.Suit = ind1; //sets a new cards suit to ind1
                    card.Value = ind2; //sets a new cards value to ind2
                    pack.Add(card); //adds new card to the pack
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
                    int num = rnd.Next(0,packsize+1); //generates a random index between 0 and 51
                    tempcard = pack[packsize]; //sets a temporary variable as the card at index packsize
                    pack[packsize] = pack[num]; //sets the card at index packsize to the card at random index
                    pack[num] = tempcard; //sets the card at random index to the one that was previously at index packsize
                    packsize--; //iterates down
                }
                return true;
            }
            else if(typeOfShuffle == 2) //Riffle
            {
                int halfcount = pack.Count / 2; //sets a variable at half the size of the pack

                for (int i = 0; i < halfcount; i++) //iterates through half of pack and adds the to a temporary pack while removing them from the pack
                {
                    tempPack1.Add(pack[0]);
                    pack.RemoveAt(0);
                }
                for (int i = 0; i < halfcount; i++) //iterates through half of pack and adds the to a temporary pack while removing them from the pack
                {
                    tempPack2.Add(pack[0]);
                    pack.RemoveAt(0);
                }
                for (int i = 0; i < halfcount; i++) //adds one card from each pack back to the main pack each iteration
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
            else
            {
                Console.WriteLine("Inputs other than 1, 2 or 3 are not options");
                return false;
            }
        }
        public static Card deal() //returns the top card from the pack and removes it from the pack
        {
            Card card = pack[0];
            pack.RemoveAt(0);
            return card;
        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            for (int i=0; i<amount; i++) //iterates through until amount and adds cards to dealt list while removing them from pack
            {
                dealt.Add(pack[0]);
                pack.RemoveAt(0);
            }
            return dealt;
        }
        public static void currentPack() //iterates through the pack and returns the values and suits of each card
        {
            for(int i = 0; i <pack.Count; i++)
            {
                Console.WriteLine(pack[i].Suit.ToString() + " " + pack[i].Value.ToString());
            }
        }
    }
}
