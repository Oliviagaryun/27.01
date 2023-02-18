namespace UI_21
{
    public partial class Frm_Title : Form
    {
        public Frm_Title()
        {
            Deck deck = new Deck();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_History form1 = new Frm_History();// use class names
            form1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //create new player 
            //
            // this.Hide();
            Frm_Betting form1 = new Frm_Betting();// use class names
            form1.ShowDialog();
            this.Close();
        }

        private void Btn_HowToPlay_Click(object sender, EventArgs e)
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