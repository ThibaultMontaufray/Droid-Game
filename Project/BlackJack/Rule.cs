using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Droid_Game
{
    public static class Rule
    {
        #region Attribute
        #endregion

        #region Properties
        #endregion

        #region Constructor
        #endregion

        #region Methods public
        public static bool IsSoftHand(List<Card> cards)
        {
            var res = cards.Where(c => c.Value.Equals(CARDVALUE.AS));
            return res.Count() > 0;
        }
        public static bool CanSplit(List<Card> cards)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards.Where(c => c.Value.Equals(cards[i].Value)).Count() > 1)
                {
                    return true;
                }
            }
            return false;
        }
        public static int GetValue(List<Card> cards)
        {
            int val = 0;
            foreach (Card card in cards)
            {
                switch (card.Value)
                {
                    case CARDVALUE.DEUX:
                        val += 2;
                        break;
                    case CARDVALUE.TROIS:
                        val += 3;
                        break;
                    case CARDVALUE.QUATRE:
                        val += 4;
                        break;
                    case CARDVALUE.CINQ:
                        val += 5;
                        break;
                    case CARDVALUE.SIX:
                        val += 6;
                        break;
                    case CARDVALUE.SEPT:
                        val += 7;
                        break;
                    case CARDVALUE.HUIT:
                        val += 8;
                        break;
                    case CARDVALUE.NEUF:
                        val += 9;
                        break;
                    case CARDVALUE.DIX:
                    case CARDVALUE.VALET:
                    case CARDVALUE.DAME:
                    case CARDVALUE.ROI:
                    case CARDVALUE.AS:
                        val += 10;
                        break;
                }
            }
            return val;
        }
        #endregion

        #region Methods private
        #endregion
    }
}
