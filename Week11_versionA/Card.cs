using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Name: Ngan Nguyen
 * Date: July 25,2017
 * this is card class
 * Version 1 - create card class
 */
namespace Week11_versionA
{
    public class Card
    {
        // private instance variable
        private Face _face;
        private Suit _suit;
        //public properties
        public Face Face
        {

            get
            {
                return this._face;
            }
            set
            {
                this._face = value;
            }
        }
        public Suit Suit
        {

            get
            {
                return this._suit;
            }
            set
            {
                this._suit = value;
            }
        }
        //public contructor
        /// <summary>
        /// this is main constructor
        /// it take 2 pararamater name(Face), suit(Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card( Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}