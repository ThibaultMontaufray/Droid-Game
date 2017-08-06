using System.Collections.Generic;

namespace Droid_Game
{
    public class Player
    {
        #region Attribute
        private List<Card> _cards;
        private List<List<Card>> _cardsStack;
        private COMBINAISON _combinaison;
        private int _points;
        private string _name;
        private Hand _finalHand;
        private int _round;
        private int _roundWin;
        #endregion

        #region Properties
        public int RoundWin
        {
            get { return _roundWin; }
            set { _roundWin = value; }
        }
        public int Round
        {
            get { return _round; }
            set { _round = value; }
        }
        public List<List<Card>> CardsStacks
        {
            get { return _cardsStack; }
            set { _cardsStack = value; }
        }
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
            _round = 0;
            _roundWin = 0;
            _cards = new List<Card>();
        }
        public Player(Player p)
        {
            _round = 0;
            _roundWin = 0;
            _cardsStack = new List<List<Card>>();
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
