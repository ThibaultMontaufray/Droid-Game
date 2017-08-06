namespace Droid_Game.Poker
{
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Benchmark : UserControl
    {
        #region Attribute
        private Card[] _cards;
        #endregion

        #region Properties
        public Card[] Cards
        {
            get { return _cards; }
            set { _cards = value; }
        }
        #endregion

        #region Constructor
        public Benchmark()
        {
            _cards = new Card[5];
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public void SetCard1(Card card)
        {
            _cards[0] = card;
            cardView1.Card = card;
            cardView1.Visible = true;
        }
        public void SetCard2(Card card)
        {
            _cards[1] = card;
            cardView2.Card = card;
            cardView2.Visible = true;
        }
        public void SetCard3(Card card)
        {
            _cards[2] = card;
            cardView3.Card = card;
            cardView3.Visible = true;
        }
        public void SetCard4(Card card)
        {
            _cards[3] = card;
            cardView4.Card = card;
            cardView4.Visible = true;
        }
        public void SetCard5(Card card)
        {
            _cards[4] = card;
            cardView5.Card = card;
            cardView5.Visible = true;
        }
        public void ResetColor()
        {
            for (int i = 0; i < 5; i++)
            {
                ColorCard(i, Color.Gainsboro);
            }
        }
        public void SelectCard(int num)
        {
            ColorCard(num, Color.DarkOrange);
        }
        public void UnSelectCard(int num)
        {
            ColorCard(num, Color.Gainsboro);
        }
        #endregion

        #region Methods private
        private void ColorCard(int cardNum, Color color)
        {
            switch (cardNum)
            {
                case 0:
                    cardView1.BackColor = color;
                    break;
                case 1:
                    cardView2.BackColor = color;
                    break;
                case 2:
                    cardView3.BackColor = color;
                    break;
                case 3:
                    cardView4.BackColor = color;
                    break;
                case 4:
                    cardView5.BackColor = color;
                    break;
            }
        }
        #endregion
    }
}
