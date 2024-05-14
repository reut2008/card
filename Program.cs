using System.Dynamic;

namespace קלפים
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardDeck card_deck = new CardDeck();
            int[] ammounts = { 0, 0, 0, 0 };
            for ( int i = 0; i<10; i++)
            {
                Card card = card_deck.GetCard();
                ammounts[card.GetSign()] += 1;
            }
            for (int i = 0; i < 4; i++)
            {
                int ammount = ammounts[i];
                Console.WriteLine("Num of sign " + i + " : " + ammount);
            }


        }
    }
}