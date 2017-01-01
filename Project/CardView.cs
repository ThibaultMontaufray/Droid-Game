namespace Droid_Game
{
    using System.Windows.Forms;

    public partial class CardView : UserControl
    {
        #region Attribute
        private Card _card;
        #endregion

        #region Properties
        public Card Card
        {
            get { return _card; }
            set
            {
                _card = value;
                UpdateDesign();
            }
        }
        #endregion

        #region Constructor
        public CardView()
        {
            _card = new Card();
            InitializeComponent();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void UpdateDesign()
        {
            if (((int)_card.Value) < 11)
            { 
                labelNb1.Text = ((int)_card.Value).ToString();
                labelNb2.Text = ((int)_card.Value).ToString();
            }
            else
            {
                labelNb1.Text = _card.Value.ToString();
                labelNb2.Text = _card.Value.ToString();
            }

            switch (_card.Color)
            {
                case CARDCOLOR.CARREAU:
                    pictureBox1.Image = imageListColor.Images[imageListColor.Images.IndexOfKey("carreau")];
                    pictureBox2.Image = imageListColor.Images[imageListColor.Images.IndexOfKey("carreau")];
                    break;
                case CARDCOLOR.COEUR:
                    pictureBox1.Image = imageListColor.Images[imageListColor.Images.IndexOfKey("coeur")];
                    pictureBox2.Image = imageListColor.Images[imageListColor.Images.IndexOfKey("coeurR")];
                    break;
                case CARDCOLOR.PIQUE:
                    pictureBox1.Image = imageListColor.Images[imageListColor.Images.IndexOfKey("pique")];
                    pictureBox2.Image = imageListColor.Images[imageListColor.Images.IndexOfKey("piqueR")];
                    break;
                case CARDCOLOR.TREFLE:
                    pictureBox1.Image = imageListColor.Images[imageListColor.Images.IndexOfKey("trefle")];
                    pictureBox2.Image = imageListColor.Images[imageListColor.Images.IndexOfKey("trefleR")];
                    break;
            }
        }
        #endregion
    }
}
