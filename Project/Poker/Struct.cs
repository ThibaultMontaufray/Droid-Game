namespace Droid_Game
{
    using System.Collections.Generic;

    public struct Card
    {
        public CARDCOLOR Color;
        public CARDVALUE Value;
    }
    public class Hand
    {
        public List<Card> Cards = new List<Card>();
    }
}