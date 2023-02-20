namespace UI_21
{
    public partial class Frm_Title : Form
    {
        public Frm_Title()
        {
            Deck deck = new Deck();
            InitializeComponent();
        }

        private void History(object sender, EventArgs e)
        {
            this.Hide();
            Frm_History form1 = new Frm_History();// use class names
            form1.ShowDialog();
            this.Close();
        }

        private void Play(object sender, EventArgs e)
        {
            Player player= new Player();
            // this.Hide();
            Frm_Betting form1 = new Frm_Betting();// use class names
            form1.ShowDialog();
            this.Close();
        }

        private void HowToPlay(object sender, EventArgs e)
        {
            this.Hide();
            Frm_HowToPlay form1 = new Frm_HowToPlay();// use class names
            form1.ShowDialog();
            this.Close();

        }

        private void Frm_Title_Load(object sender, EventArgs e)
        {

        }
    }
}