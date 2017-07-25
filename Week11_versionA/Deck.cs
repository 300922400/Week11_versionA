using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Week11_versionA
{
    public class Deck : List<Card>
    {
        // contructor
        public Deck()
        {
            this._initialize();
        }
        //private method
        private void _initialize()
        {
            for (int suit = (int)Suit.Clubs; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = (int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }
        //public methods
        /// <summary>
        /// orverides the built-in ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            foreach (Card card in this)
            {
                outputString += "The" + card.Face + "of" + card.Suit + "\n";
            }
            return outputString;
        }
    }
}