using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Droid_Game
{
    public partial class CardSetStatus : UserControl
    {
        #region Attribute
        private CardSet _currentCardSet;
        #endregion

        #region Properties
        public CardSet CurrentCardSet
        {
            get { return _currentCardSet; }
            set { _currentCardSet = value; }
        }
        #endregion

        #region Constructor
        public CardSetStatus()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void Init()
        {
            DataGridViewRow row;
            _currentCardSet = new CardSet();

            dataGridView1.Rows.Clear();
            foreach (var item in Enum.GetValues(typeof(CARDVALUE)))
            {
                dataGridView1.Rows.Add();
                row = dataGridView1.Rows[dataGridView1.Rows.Count - 1];
                row.Cells[0].Value = item;
                row.Cells[1].Value = item;
                row.Cells[2].Value = item;
                row.Cells[3].Value = item;
            }
            dataGridView1.Height = (dataGridView1.Rows.Count * 20) + 25;
        }
        #endregion
    }
}
