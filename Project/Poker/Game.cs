namespace Droid_Game.Poker
{
    using System.Collections.Generic;

    public class Game
    {
        #region Attribute
        private CardSet _cardSet;
        private List<Card> _benchmark;
        private List<Player> _players;
        #endregion

        #region Properties
        public List<Player> Players
        {
            get { return _players; }
            set { _players = value; }
        }
        public List<Card> Benchmark
        {
            get { return _benchmark; }
            set { _benchmark = value; }
        }
        public CardSet CardSet
        {
            get { return _cardSet; }
            set { _cardSet = value; }
        }
        #endregion

        #region Constructor
        public Game()
        {
            Init();
        }
        #endregion

        #region Methods public
        public void ResetCardSet()
        {
            _cardSet = new CardSet();
        }
        public void SetBenchmark()
        {
            _benchmark.Clear();
            _benchmark.Add(_cardSet.GetCard());
            _benchmark.Add(_cardSet.GetCard());
            _benchmark.Add(_cardSet.GetCard());
            _benchmark.Add(_cardSet.GetCard());
            _benchmark.Add(_cardSet.GetCard());
        }
        public void SetPlayers()
        {
            BuildPlayers();
        }
        public void NextRound()
        {
            int tmpPoints;
            Hand hand;
            List<Card> l1;

            foreach (Player p in _players)
            {
                p.Cards.Clear();
                p.Cards.Add(_cardSet.GetCard());
                p.Cards.Add(_cardSet.GetCard());
                l1 = new List<Card>();
                l1.AddRange(p.Cards);
                l1.AddRange(_benchmark);
                p.Combinaison = Rule.GetCombinaison(new Hand() { Cards = l1 }, out tmpPoints, out hand);
                p.FinalHand = hand;
                p.Points = tmpPoints;
            }
        }
        public Player WhoWin()
        {
            bool draw = false;
            if (_players.Count == 0) return null;

            int cardPointPlayer1 = 0;
            int cardPointPlayer2 = 0;
            int cardPointWinner1 = ((int)_players[0].Cards[0].Value) > ((int)_players[0].Cards[1].Value) ? ((int)_players[0].Cards[0].Value) : ((int)_players[0].Cards[1].Value);
            int cardPointWinner2 = ((int)_players[0].Cards[0].Value) < ((int)_players[0].Cards[1].Value) ? ((int)_players[0].Cards[0].Value) : ((int)_players[0].Cards[1].Value);
            Player winner = new Player(_players[0]);
            for (int i = 0; i < _players.Count; i++)
            {
                _players[i].Round += 1;
                if (((int)_players[i].Combinaison) > ((int)winner.Combinaison))
                {
                    winner = _players[i];
                    draw = false;
                }
                else if (((int)_players[i].Combinaison) == ((int)winner.Combinaison))
                {
                    if (_players[i].Points > winner.Points)
                    {
                        winner = _players[i];
                    }
                    if (_players[i].Points < winner.Points)
                    {
                        continue;
                    }
                    else
                    {
                        cardPointPlayer1 = ((int)_players[i].Cards[0].Value) > ((int)_players[i].Cards[1].Value) ? ((int)_players[i].Cards[0].Value) : ((int)_players[i].Cards[1].Value);
                        cardPointPlayer2 = ((int)_players[i].Cards[0].Value) < ((int)_players[i].Cards[1].Value) ? ((int)_players[i].Cards[0].Value) : ((int)_players[i].Cards[1].Value);
                        if (cardPointPlayer1 > cardPointWinner1)
                        {
                            winner = _players[i];
                            draw = false;
                        }
                        else if (cardPointPlayer1 == cardPointWinner1)
                        {
                            if (cardPointPlayer2 > cardPointWinner2)
                            {
                                winner = _players[i];
                                draw = false;
                            }
                            else if (cardPointPlayer2 == cardPointWinner2)
                            {
                                draw = true;
                            }
                        }
                    }
                }
            }
            if (winner != null) { winner.RoundWin++; }
            return draw ? null : winner;
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _benchmark = new List<Card>();
            ResetCardSet();
        }
        private void BuildPlayers()
        {
            _players = new List<Player>();

            Player p1 = new Player();
            p1.Name = "TOBI";
            _players.Add(p1);

            Player p2 = new Player();
            p2.Name = "CHALLENGER";
            _players.Add(p2);
        }
        #endregion
    }
}
