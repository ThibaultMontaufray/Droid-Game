using System;
using System.Collections.Generic;

namespace Droid_Game
{
    public class CardSet
    {
        #region Attribute
        private int _nbCard;
        private List<Card> _cards;
        private List<Card> _givenCards;
        private Random _rand;
        #endregion

        #region Properties
        public List<Card> Cards
        {
            get { return _cards; }
            set { _cards = value; }
        }
        public int NbCards
        {
            get { return _nbCard; }
            set { _nbCard = value; }
        }
        #endregion

        #region Constructor
        public CardSet()
        {
            Init();
        }
        #endregion

        #region Methods public
        public Card GetCard()
        {
            Card c = _cards[_rand.Next(_cards.Count)];
            int watchdog = 10000;
            while (_givenCards.Contains(c) || watchdog > 0)
            {
                c = _cards[_rand.Next(_cards.Count)];
                watchdog--;
            }
            _givenCards.Add(c);
            return c;
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _cards = new List<Card>();
            _givenCards = new List<Card>();

            _rand = new Random();
            _nbCard = 32;
            LoadCards();
        }
        private void LoadCards()
        {
            _cards = new List<Card>();
            switch (_nbCard)
            {
                case 52:
                    LoadCards52();
                    break;
                case 32:
                    LoadCards32();
                    break;
                default:
                    System.Console.WriteLine("Sorry, this card set is unknow : " + _nbCard);
                    break;
            }
        }
        private void LoadCards52()
        {
            for (int i = 0; i < 13; i++)
            {
                _cards.Add(new Card() { Value = (CARDVALUE)Enum.GetValues(typeof(CARDVALUE)).GetValue(i), Color = CARDCOLOR.CARREAU });
                _cards.Add(new Card() { Value = (CARDVALUE)Enum.GetValues(typeof(CARDVALUE)).GetValue(i), Color = CARDCOLOR.COEUR });
                _cards.Add(new Card() { Value = (CARDVALUE)Enum.GetValues(typeof(CARDVALUE)).GetValue(i), Color = CARDCOLOR.PIQUE });
                _cards.Add(new Card() { Value = (CARDVALUE)Enum.GetValues(typeof(CARDVALUE)).GetValue(i), Color = CARDCOLOR.TREFLE });
            }
        }
        private void LoadCards32()
        {
            for (int i = 5; i < 13; i++)
            {
                _cards.Add(new Card() { Value = (CARDVALUE)Enum.GetValues(typeof(CARDVALUE)).GetValue(i), Color = CARDCOLOR.CARREAU });
                _cards.Add(new Card() { Value = (CARDVALUE)Enum.GetValues(typeof(CARDVALUE)).GetValue(i), Color = CARDCOLOR.COEUR });
                _cards.Add(new Card() { Value = (CARDVALUE)Enum.GetValues(typeof(CARDVALUE)).GetValue(i), Color = CARDCOLOR.PIQUE });
                _cards.Add(new Card() { Value = (CARDVALUE)Enum.GetValues(typeof(CARDVALUE)).GetValue(i), Color = CARDCOLOR.TREFLE });
            }
        }
        #endregion
    }
}
