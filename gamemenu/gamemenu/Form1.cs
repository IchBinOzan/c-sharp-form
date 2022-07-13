using Balloon_pop_arcade_game_MOO_ICT;
using Car_Racing_Game_MOO_ICT;
using Fighter_Jet_Shooting_Game_MOO_ICT;
using Flappy_Bird_Windows_Form;


namespace gamemenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Balloon_pop_arcade_game_MOO_ICT.Form1 ballon_PopForm1 = new Balloon_pop_arcade_game_MOO_ICT.Form1();
            ballon_PopForm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flappy_Bird_Windows_Form.Form1 flappyBirdForm1 = new Flappy_Bird_Windows_Form.Form1();
            flappyBirdForm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fighter_Jet_Shooting_Game_MOO_ICT.Form1 jetFighterForm1 = new Fighter_Jet_Shooting_Game_MOO_ICT.Form1();
            jetFighterForm1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Car_Racing_Game_MOO_ICT.Form1 carRacingForm1 = new Car_Racing_Game_MOO_ICT.Form1();
            carRacingForm1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (label1.Text == "English")
            {
                tabPage1.Text = "Action";
            }
        }
    }
}