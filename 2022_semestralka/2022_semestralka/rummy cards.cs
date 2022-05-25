using System;
using System.Collections.Generic;
using System.Text;

namespace _2022_semestralka
{
    class rummy_cards
    {
        public string Suit;
        public int Value;
        public int Points;
        public void PlayingCard(int s, int v)
        {
            Value = v;
            switch (s) 
            {
                case 1: 
                    Suit = "♣";
                    break;
                case 2: 
                    Suit = "♦";
                    break;
                case 3: 
                    Suit = "♥";
                    break;
                case 4: 
                    Suit = "♠";
                    break;
            }
            if (Value > 10)
            {
                Points = 10;
            }
            else if (Value == 1)
            {
                Points = 11;
            }
            else
            {
                Points = Value;
            }
        }
     class Blackjack
        {
            
        }

    }
}
