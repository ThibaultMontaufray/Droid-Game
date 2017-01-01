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
        public void SetBenchmark()
        {
            _benchmark.Add(_cardSet.GetCard());
            _benchmark.Add(_cardSet.GetCard());
            _benchmark.Add(_cardSet.GetCard());
            _benchmark.Add(_cardSet.GetCard());
            _benchmark.Add(_cardSet.GetCard());
        }
        public void SetPlayers()
        {
            LoadPlayers();
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
            for (int i = 1; i < _players.Count; i++)
            {
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
            return draw ? null : winner;
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _benchmark = new List<Card>();
            _cardSet = new CardSet();
        }
        private void LoadPlayers()
        {
            int tmpPoints;
            Hand hand;
            _players = new List<Player>();

            Player p1 = new Player();
            p1.Name = "TOBI";
            p1.Cards.Add(_cardSet.GetCard());
            p1.Cards.Add(_cardSet.GetCard());
            List<Card> l1 = new List<Card>();
            l1.AddRange(p1.Cards);
            l1.AddRange(_benchmark);
            p1.Combinaison = Rule.GetCombinaison(new Hand() { Cards = l1 }, out tmpPoints, out hand);
            p1.FinalHand = hand;
            p1.Points = tmpPoints;
            _players.Add(p1);

            Player p2 = new Player();
            p2.Name = "CHALLENGER";
            p2.Cards.Add(_cardSet.GetCard());
            p2.Cards.Add(_cardSet.GetCard());
            List<Card> l2 = new List<Card>();
            l2.AddRange(p2.Cards);
            l2.AddRange(_benchmark);
            p2.Combinaison = Rule.GetCombinaison(new Hand() { Cards = l2 }, out tmpPoints, out hand);
            p2.FinalHand = hand;
            p2.Points = tmpPoints;
            _players.Add(p2);
        }
        #endregion
    }
}
