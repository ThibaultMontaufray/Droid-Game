namespace Droid_Game
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public struct Card
    {
        public CARDCOLOR Color;
        public CARDVALUE Value;
    }
    [Serializable]
    public class Hand
    {
        public List<Card> Cards = new List<Card>();
    }
}