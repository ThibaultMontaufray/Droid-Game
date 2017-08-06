namespace Droid_Game
{
    using Poker;
    using System.Linq;
    using System.Windows.Forms;

    public partial class DemoPoker : Form
    {
        #region Attribute
        private Droid_Game.Poker.Game _game;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public DemoPoker()
        {
            InitializeComponent();
            playerView1.GetFocus += PlayerView1_GetFocus;
            playerView2.GetFocus += PlayerView2_GetFocus;
            Init();
        }
        #endregion

        #region Methods public
        public void Init()
        {
            _game = new Poker.Game();
            _game.SetPlayers();
            //LaunchRound();
        }
        public void LaunchRound()
        {
            _game.ResetCardSet();
            _game.SetBenchmark();
            benchmark1.ResetColor();
            benchmark1.SetCard1(_game.Benchmark[0]);
            benchmark1.SetCard2(_game.Benchmark[1]);
            benchmark1.SetCard3(_game.Benchmark[2]);
            benchmark1.SetCard4(_game.Benchmark[3]);
            benchmark1.SetCard5(_game.Benchmark[4]);

            _game.NextRound();

            playerView1.Player = _game.Players[0];
            playerView2.Player = _game.Players[1];

            Player winner = _game.WhoWin();
            if (winner == null)
            {
                playerView1.Draw();
                playerView2.Draw();
            }
            else if (_game.Players[0].Name == winner.Name)
            {
                playerView1.Win();
                playerView2.Lose();
            }
            else
            {
                playerView1.Lose();
                playerView2.Win();
            }
        }
        #endregion

        #region Methods private
        private void PlayerHand(string playerName)
        {
            foreach (Player player in _game.Players)
            {
                if (player.Name == playerName)
                {
                    for (int i = 0; i < benchmark1.Cards.Length; i++)
                    {
                        if (player.FinalHand.Cards.Count(c => c.Color == benchmark1.Cards[i].Color && c.Value == benchmark1.Cards[i].Value) > 0)
                        {
                            benchmark1.SelectCard(i);
                        }
                        else
                        {
                            benchmark1.UnSelectCard(i);
                        }
                    }
                    break;
                }
            }
            if (playerView2.Player.Name == playerName)
            {
                playerView1.Unselect();
                playerView2.UpdateHand();
            }
            else if (playerView1.Player.Name == playerName)
            {
                playerView1.UpdateHand();
                playerView2.Unselect();
            }
        }
        #endregion

        #region Event
        private void buttonRelaunch_Click(object sender, System.EventArgs e)
        {
            LaunchRound();
        }
        private void PlayerView2_GetFocus()
        {
            PlayerHand(playerView2.Player.Name);
        }
        private void PlayerView1_GetFocus()
        {
            PlayerHand(playerView1.Player.Name);
        }
        #endregion
    }
}
