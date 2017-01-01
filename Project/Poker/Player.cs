using System.Collections.Generic;

namespace Droid_Game.Poker
{
    public class Player
    {
        #region Attribute
        private List<Card> _cards;
        private COMBINAISON _combinaison;
        private int _points;
        private string _name;
        private Hand _finalHand;
        #endregion

        #region Properties
        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<Card> Cards
        {
            get { return _cards; }
            set { _cards = value; }
        }
        public COMBINAISON Combinaison
        {
            get { return _combinaison; }
            set { _combinaison = value; }
        }
        public Hand FinalHand
        {
            get { return _finalHand; }
            set { _finalHand = value; }
        }
        #endregion

        #region Constructor
        public Player()
        {
            _cards = new List<Card>();
        }
        public Player(Player p)
        {
            _cards = new List<Card>();
            foreach (Card c in p.Cards)
            {
                _cards.Add(c);
            }
            _combinaison = p.Combinaison;
            _name = p.Name;
            _points = p.Points;
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        #endregion
    }
}
