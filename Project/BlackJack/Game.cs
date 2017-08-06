using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Droid_Game.BlackJack
{
    public delegate void GameEventHandler();
    public class Game
    {
        #region Attribute
        public event GameEventHandler DeckChanged;

        private CardSet _cardSet;
        private Player _dealer;
        private Player _visitor;
        private bool _roundFinished;
        private int _roundAmount;
        #endregion

        #region Properties
        public CardSet CardSet
        {
            get { return _cardSet; }
            set { _cardSet = value; }
        }
        public Player Visitor
        {
            get { return _visitor; }
            set { _visitor = value; }
        }
        public Player Dealer
        {
            get { return _dealer; }
            set { _dealer = value; }
        }
        public bool RoundFinished
        {
            get { return _roundFinished; }
            set { _roundFinished = value; }
        }
        #endregion

        #region Constructor
        public Game()
        {
            Init();
        }
        #endregion

        #region Methods public
        public void InitNewRound(int amount = 10)
        {
            _visitor.Cards.Clear();
            _dealer.Cards.Clear();
            _cardSet = new CardSet();

            _dealer.Cards.Add(_cardSet.GetCard());
            _visitor.Cards.Add(_cardSet.GetCard());
            _roundAmount = amount;

            _roundFinished = false;
            OnDeckChanged();
        }
        public void VisitorHit()
        {
            _visitor.Cards.Add(_cardSet.GetCard());
            if (Rule.GetValue(_visitor.Cards) > 20)
            {
                ProcessDealerTurn();
            }
            OnDeckChanged();
        }
        public void VisitorStand()
        {
            ProcessDealerTurn();
            OnDeckChanged();
        }
        public void VisitorDoubleDown()
        {
            _roundAmount = _roundAmount * 2;
            VisitorHit();
        }
        public void VisitorSplit()
        {
            // TODO
            OnDeckChanged();
        }
        public Player GetWinner()
        {
            return _dealer;
        }
        #endregion

        #region Methods protected
        protected void OnDeckChanged()
        {
            if (DeckChanged != null) DeckChanged();
        }
        #endregion

        #region Methods private
        private void ProcessDealerTurn()
        {
            while (Rule.GetValue(_dealer.Cards) < 17)
            {
                _dealer.Cards.Add(_cardSet.GetCard());
            }
            _roundFinished = true;
        }
        private void Init()
        {
            _dealer = new Player();
            _dealer.Name = "Dealer";

            _visitor = new Player();
            _visitor.Name = "Visitor";

            _roundFinished = true;
        }
        #endregion
    }
}
