namespace Droid_Game.Poker
{
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public delegate void PlayerViewEventHandler();
    public partial class PlayerView : UserControl
    {
        #region Attribute
        public event PlayerViewEventHandler GetFocus;
        private Player _player;
        #endregion

        #region Properties
        public Player Player
        {
            get { return _player; }
            set
            {
                _player = value;
                UpdateView();
            }
        }
        #endregion

        #region Constructor
        public PlayerView()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public void UpdateView()
        {
            try
            {
                Unselect();
                labelName.Text = _player.Name;
                if (_player.Cards.Count > 0)
                {
                    cardView1.Card = _player.Cards[0];
                    cardView1.Visible = true;
                }
                if (_player.Cards.Count > 1)
                {
                    cardView2.Card = _player.Cards[1];
                    cardView2.Visible = true;
                }
                labelCombinaison.Text = _player.Combinaison.ToString();
                labelVictory.Text = string.Format("Have best hand : {0} %",  Rule.StatBestGame(_player.Combinaison).ToString());
            }
            catch (System.Exception exp)
            {
                System.Console.WriteLine(exp.Message);
            }
        }
        public void Draw()
        {
            labelName.BackColor = Color.LightGray;
        }
        public void Win()
        {
            labelName.BackColor = Color.LemonChiffon;
        }
        public void Lose()
        {
            labelName.BackColor = Color.Maroon;
        }
        public void UpdateHand()
        {
            if (_player.FinalHand.Cards.Count(c => c.Color == cardView1.Card.Color && c.Value == cardView1.Card.Value) > 0)
            {
                cardView1.BackColor = Color.DarkOrange;
            }
            else
            {
                cardView1.BackColor = Color.Gainsboro;
            }
            if (_player.FinalHand.Cards.Count(c => c.Color == cardView2.Card.Color && c.Value == cardView2.Card.Value) > 0)
            {
                cardView2.BackColor = Color.DarkOrange;
            }
            else
            {
                cardView2.BackColor = Color.Gainsboro;
            }
        }
        public void Unselect()
        {
            cardView1.BackColor = Color.Gainsboro;
            cardView2.BackColor = Color.Gainsboro;
        }
        #endregion

        #region Methods private
        #endregion

        #region Event
        private void PlayerView_Focus(object sender, MouseEventArgs e)
        {
            if (GetFocus != null)
                GetFocus();
        }
        #endregion
    }
}
