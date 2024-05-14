using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace קלפים
{
    class CardDeck
    {
        private Card[] deck;
        private int numCards;
        private Card[] usedCards;
        private int numUsedCards;
        private Random r;
       
        public CardDeck()
        {
            this.numCards = 52;
            this.numUsedCards = 0;
            this.deck = new Card[52];
            this.usedCards = new Card[52];
            for (int i=0; i < 13; i++)
            {
                for (int j = 0; j<4; j++)
                {
                    this.deck[4 * i+j] = new Card(i, j);
                }
            }
            r = new Random();
        }
        public Card GetCard()
        {
            int drawn_card_ind = this.r.Next(0,numCards);
            Card drawn_card = this.deck[drawn_card_ind];
            usedCards[numUsedCards] = drawn_card;
            for (int i = drawn_card_ind + 1; i < this.numCards; i++)

            {
                usedCards[i - 1] = usedCards[i];
            }
            numCards  = numCards-1;
            numUsedCards = numUsedCards + 1;
            return drawn_card;


          
        
        }
        public void ReFillDeck()
        { 
            for (int i = 0; i< numUsedCards; i++)
            {
                this.deck[numCards + i] = this.usedCards[i];
            }
            numCards = 52;
            numUsedCards = 0;
        }
    }
}
