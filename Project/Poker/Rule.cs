namespace Droid_Game.Poker
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Rule
    {
        #region Attribute
        #endregion

        #region Properties
        #endregion

        #region Methods public
        public static COMBINAISON GetCombinaison(Hand hand, out int points, out Hand playerBestHand)
        {
            points = 0;
            COMBINAISON combinaison;
            Hand finaleHand = new Hand();

            if (IsQUINTEFLUSHROYALE(hand, ref finaleHand)) combinaison = COMBINAISON.QUINTEFLUSHROYALE;
            else if (IsQUINTEFLUSH(hand, ref finaleHand)) combinaison = COMBINAISON.QUINTEFLUSH;
            else if (IsCARRE(hand, ref finaleHand)) combinaison = COMBINAISON.CARRE;
            else if (IsFULL(hand, ref finaleHand)) combinaison = COMBINAISON.FULL;
            else if (IsCOULEUR(hand, ref finaleHand)) combinaison = COMBINAISON.COULEUR;
            else if (IsQUINTE(hand, ref finaleHand)) combinaison = COMBINAISON.QUINTE;
            else if (IsBRELAN(hand, ref finaleHand)) combinaison = COMBINAISON.BRELAN;
            else if (IsDOUBLEPAIRE(hand, ref finaleHand)) combinaison = COMBINAISON.DOUBLEPAIRE;
            else if (IsPAIRE(hand, ref finaleHand)) combinaison = COMBINAISON.PAIRE;
            else combinaison = COMBINAISON.CARTEHAUTE;

            BuildHand(ref finaleHand, hand);
            points = CountPoint(finaleHand.Cards);
            playerBestHand = finaleHand;
            return combinaison;
        }
        public static double StatBestGame(COMBINAISON cmb)
        {
            switch(cmb)
            {
                case COMBINAISON.QUINTEFLUSH:
                    return 100 - 0.031;
                case COMBINAISON.CARRE:
                    return 100 - 0.168;
                case COMBINAISON.FULL:
                    return 100 - 2.596;
                case COMBINAISON.COULEUR:
                    return 100 - 3.025;
                case COMBINAISON.QUINTE:
                    return 100 - 4.619;
                case COMBINAISON.BRELAN:
                    return 100 - 4.83;
                case COMBINAISON.DOUBLEPAIRE:
                    return 100 - 23.496;
                case COMBINAISON.PAIRE:
                    return 100 - 43.823;
                case COMBINAISON.CARTEHAUTE:
                    return 100 - 17.412;
                default:
                    return 100 - 100;
            }
        }
        #endregion

        #region Methods private
        private static bool IsQUINTEFLUSHROYALE(Hand hand, ref Hand finalHand)
        {
            List<Card> gameHand;
            finalHand = new Hand();
            foreach (Card c in hand.Cards.OrderByDescending(crt => crt.Value))
            {
                gameHand = hand.Cards.Where(crt => crt.Color.Equals(c.Color)).OrderByDescending(crt => crt.Value).ToList();
                if (gameHand.Count < 5)
                {
                    continue;
                }
                else
                {
                    int countSuite = 0;
                    int lastVal = int.MinValue;
                    foreach (Card crt in gameHand)
                    {
                        if (((int)crt.Value).Equals(lastVal + 1))
                        {
                            finalHand.Cards.Add(crt);
                            countSuite++;
                            if (countSuite >= 4)
                            {
                                if (finalHand.Cards[0].Value == CARDVALUE.AS) return true;
                                else return false;
                            }
                        }
                        else
                        {
                            finalHand = new Hand();
                            countSuite = 0;
                        }
                        lastVal = (int)crt.Value;
                    }
                }
            }
            return false;
        }
        private static bool IsQUINTEFLUSH(Hand hand, ref Hand finalHand)
        {
            List<Card> gameHand;
            finalHand = new Hand();
            foreach (Card c in hand.Cards.OrderByDescending(crt => crt.Value))
            {
                gameHand = hand.Cards.Where(crt => crt.Color.Equals(c.Color)).OrderByDescending(crt => crt.Value).ToList();
                if (gameHand.Count < 5)
                {
                    continue;
                }
                else
                {
                    int countSuite = 0;
                    int lastVal = int.MinValue;
                    foreach (Card crt in gameHand)
                    {
                        if (((int)crt.Value).Equals(lastVal + 1))
                        {
                            finalHand.Cards.Add(crt);
                            countSuite++;
                            if (countSuite >= 4) return true;
                        }
                        else
                        {
                            finalHand = new Hand();
                            countSuite = 0;
                        }
                        lastVal = (int)crt.Value;
                    }
                }
            }
            return false;
        }
        private static bool IsCARRE(Hand hand, ref Hand finalHand)
        {
            finalHand = new Hand();
            foreach (Card c in hand.Cards.OrderByDescending(crt => crt.Value))
            {
                finalHand.Cards = hand.Cards.Where(crt => crt.Value.Equals(c.Value)).ToList();
                if (finalHand.Cards.Count < 4)
                {
                    continue;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        private static bool IsFULL(Hand hand, ref Hand finalHand)
        {
            List<Card> threeHand;
            List<Card> twoHand;
            List<Card> twoHandFinal;
            foreach (Card c in hand.Cards.OrderByDescending(crt => crt.Value))
            {
                threeHand = hand.Cards.Where(crt => crt.Value.Equals(c.Value)).OrderByDescending(crt => crt.Value).ToList();
                twoHand = hand.Cards.Where(crt => ! crt.Value.Equals(c.Value)).OrderByDescending(crt => crt.Value).ToList();
                if (threeHand.Count < 3 || twoHand.Count < 2)
                {
                    continue;
                }
                else
                {
                    foreach (Card c2 in twoHand)
                    {
                        twoHandFinal = twoHand.Where(crt => crt.Value.Equals(c2.Value)).OrderByDescending(crt => crt.Value).ToList();
                        if (twoHandFinal.Count >= 2)
                        {
                            finalHand = new Hand();
                            finalHand.Cards.Add(threeHand[0]);
                            finalHand.Cards.Add(threeHand[1]);
                            finalHand.Cards.Add(threeHand[2]);
                            finalHand.Cards.Add(twoHandFinal[0]);
                            finalHand.Cards.Add(twoHandFinal[1]);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private static bool IsCOULEUR(Hand hand, ref Hand finalHand)
        {
            finalHand = new Hand();
            foreach (Card c in hand.Cards.OrderByDescending(crt => crt.Value))
            {
                finalHand.Cards = hand.Cards.Where(crt => crt.Color.Equals(c.Color)).ToList();
                if (finalHand.Cards.Count < 5)
                {
                    continue;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        private static bool IsQUINTE(Hand hand, ref Hand finalHand)
        {
            List<Card> gameHand;
            finalHand = new Hand();
            foreach (Card c in hand.Cards.OrderByDescending(crt => crt.Value))
            {
                gameHand = hand.Cards.OrderByDescending(crt => crt.Value).ToList();
                int countSuite = 0;
                int lastVal = int.MinValue;
                foreach (Card crt in gameHand)
                {
                    if (((int)crt.Value).Equals(lastVal + 1))
                    {
                        finalHand.Cards.Add(crt);
                        countSuite++;
                        if (countSuite >= 4) return true;
                    }
                    else
                    {
                        finalHand = new Hand();
                        countSuite = 0;
                    }
                    lastVal = (int)crt.Value;
                }
            }
            return false;
        }
        private static bool IsBRELAN(Hand hand, ref Hand finalHand)
        {
            finalHand = new Hand();
            foreach (Card c in hand.Cards.OrderByDescending(crt => crt.Value))
            {
                finalHand.Cards = hand.Cards.Where(crt => crt.Value.Equals(c.Value)).OrderByDescending(crt => crt.Value).ToList();
                if (finalHand.Cards.Count < 3)
                {
                    continue;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        private static bool IsDOUBLEPAIRE(Hand hand, ref Hand finalHand)
        {
            List<Card> two1Hand;
            List<Card> two2Hand;
            List<Card> two2HandFinal;
            foreach (Card c in hand.Cards.OrderByDescending(crt => crt.Value))
            {
                two1Hand = hand.Cards.Where(crt => crt.Value.Equals(c.Value)).ToList();
                two2Hand = hand.Cards.Where(crt => !crt.Value.Equals(c.Value)).ToList();
                if (two1Hand.Count < 2 || two2Hand.Count < 2)
                {
                    continue;
                }
                else
                {
                    foreach (Card c2 in two2Hand)
                    {
                        two2HandFinal = two2Hand.Where(crt => crt.Value.Equals(c2.Value)).OrderByDescending(crt => crt.Value).ToList();
                        if (two2HandFinal.Count >= 2)
                        {
                            finalHand = new Hand();
                            finalHand.Cards.Add(two1Hand[0]);
                            finalHand.Cards.Add(two1Hand[1]);
                            finalHand.Cards.Add(two2HandFinal[0]);
                            finalHand.Cards.Add(two2HandFinal[1]);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private static bool IsPAIRE(Hand hand, ref Hand finalHand)
        {
            finalHand = new Hand();
            foreach (Card c in hand.Cards.OrderByDescending(crt => crt.Value))
            {
                finalHand.Cards = hand.Cards.Where(crt => crt.Value.Equals(c.Value)).OrderByDescending(crt => crt.Value).ToList();
                if (finalHand.Cards.Count < 2)
                {
                    continue;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        private static Card CARTEHAUTE(Hand hand, ref Hand finalHand)
        {
            return hand.Cards.OrderByDescending(crt => crt.Value).ToList()[0];
        }
        private static void BuildHand(ref Hand finaleHand, Hand intialHand)
        {
            if (finaleHand.Cards.Count < 5)
            {
                List<Card> lc = intialHand.Cards.OrderByDescending(c => c.Value).ToList();
                foreach (Card c in lc)
                {
                    if (finaleHand.Cards.Count >= 5)
                    {
                        break;
                    }
                    if (!finaleHand.Cards.Contains(c))
                    {
                        finaleHand.Cards.Add(c);
                    }
                }
            }
        }
        private static int CountPoint(List<Card> cards)
        {
            int points = 0;
            foreach (Card c in cards)
            {
                points += (int)c.Value;
            }
            return points;
        }
        #endregion
    }
}
