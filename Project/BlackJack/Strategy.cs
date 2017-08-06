using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Droid_Game.BlackJack
{
    #region Enum
    public enum StratType
    {
        HARD,
        SOFT,
        SPLIT
    }
    public enum Decision
    {
        HIT,
        DOUBLE,
        STAND,
        SPLIT
    }
    #endregion

    public class Strategy
    {
        #region Structure
        private struct Strat
        {
            public StratType StategyType;
            public int Value;
            public Dictionary<int, string> DealerHand;
        }
        #endregion

        #region Attribute
        private List<Strat> _strategies;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public Strategy()
        {
            LoadFile();
        }
        #endregion

        #region Methods public
        public Decision GetDecistion(List<Card> visitorCards, List<Card> dealerHand)
        {
            Strat strat;
            if (Rule.CanSplit(visitorCards))
            {
                strat = _strategies.Where(s => s.Value.Equals(Rule.GetValue(visitorCards)) && s.StategyType.Equals(StratType.SPLIT)).First();
            }
            else if (Rule.IsSoftHand(visitorCards))
            {
                strat = _strategies.Where(s => s.Value.Equals(Rule.GetValue(visitorCards)) && s.StategyType.Equals(StratType.SOFT)).First();
            }
            else
            {
                strat = _strategies.Where(s => s.Value.Equals(Rule.GetValue(visitorCards)) && s.StategyType.Equals(StratType.HARD)).First();
            }
            var decision = strat.DealerHand[Rule.GetValue(dealerHand)];

            switch (decision.ToUpper())
            {
                case "SP":
                    return Decision.SPLIT;
                case "H":
                    return Decision.HIT;
                case "D":
                    return Decision.DOUBLE;
                case "S":
                default:
                    return Decision.STAND;
            }
        }
        #endregion

        #region Methods private
        private void LoadFile()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream objStream = assembly.GetManifestResourceStream("Droid_Game.Resources.blackjack.csv");
            StreamReader objReader = new StreamReader(objStream);
            string fileDump = objReader.ReadToEnd();

            LoadStrategy(fileDump);
        }
        private void LoadStrategy(string fileDump)
        {
            string[] row;
            bool header = true;
            Strat stratRow;
            Dictionary<int, string> decisions;

            _strategies = new List<Strat>();
            
            foreach (var rowDump in fileDump.Split('\n'))
            {
                if (!header)
                { 
                    row = rowDump.Split(';');
                    if (row.Length > 11)
                    {
                        decisions = new Dictionary<int, string>();
                        decisions[2] = row[2];
                        decisions[3] = row[3];
                        decisions[4] = row[4];
                        decisions[5] = row[5];
                        decisions[6] = row[6];
                        decisions[7] = row[7];
                        decisions[8] = row[8];
                        decisions[9] = row[9];
                        decisions[10] = row[10];
                        decisions[1] = row[11];

                        stratRow = new Strat();
                        stratRow.StategyType = (StratType)Enum.Parse(typeof(StratType), row[0]);
                        stratRow.Value = int.Parse(row[1]);
                        stratRow.DealerHand = decisions;
                    }
                }
                else
                {
                    header = false;
                }
            }
        }
        #endregion
    }
}
