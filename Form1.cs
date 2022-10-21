namespace Tictactoe
{
    public partial class Form1 : Form
    {

       
        string currentplayer = "X";
       
        bool CheckIswinner()
        {
           

            if (button1.Text==button2.Text && button1.Text==button3.Text)
                return true;
            if (button4.Text==button5.Text&&button4.Text==button6.Text)
                return true;
            if (button7.Text==button8.Text&&button7.Text==button9.Text)
                return true;
            if (button1.Text==button4.Text&&button1.Text==button7.Text)
                return true;
            if (button2.Text==button5.Text&&button2.Text==button8.Text)
                return true;
            if (button3.Text==button6.Text&&button3.Text==button9.Text)
                return true;
            if (button1.Text==button5.Text&&button1.Text==button9.Text)
                return true;
            if (button3.Text==button5.Text&&button3.Text==button7.Text)
                return true;
            
            return false;
        }
        public Form1()
        {
            InitializeComponent();
            currentplayerSymbolLabel.Text=currentplayer;
        }

        public void label3_Click(object sender, EventArgs e)
        {

        }

       
        public void button1_Click(object sender, EventArgs e)
        {
           
            button1.Text=currentplayer;


            if (CheckIswinner())
            {

                winnerlabel.Text="WINNER: "+currentplayer;

                return;
            }

            if (currentplayer=="X")
                currentplayer="O";

            else
                currentplayer="X";
                currentplayerSymbolLabel.Text=currentplayer;

        }

        public void button2_Click(object sender, EventArgs e)
        {
            button2.Text=currentplayer;

            if (CheckIswinner())
            {

                winnerlabel.Text="WINNER: "+currentplayer;

                return;
            }

            if (currentplayer=="X")
                currentplayer="O";

            else
                currentplayer="X";
            currentplayerSymbolLabel.Text=currentplayer;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            button3.Text=currentplayer;

            if (CheckIswinner())
            {

                winnerlabel.Text="WINNER: "+currentplayer;

                return;
            }

            if (currentplayer=="X")
                currentplayer="0";

            else
                currentplayer="X";
            currentplayerSymbolLabel.Text=currentplayer;
        }

        public void button4_Click(object sender, EventArgs e)
        {
            button4.Text=currentplayer;

            if (CheckIswinner())
            {

                winnerlabel.Text="WINNER: "+currentplayer;

                return;
            }

            if (currentplayer=="X")
                currentplayer="O";

            else
                currentplayer="X";
            currentplayerSymbolLabel.Text=currentplayer;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text=currentplayer;

            if (CheckIswinner())
            {

                winnerlabel.Text="WINNER: "+currentplayer;

                return;
            }

            if (currentplayer=="X")
                currentplayer="O";

            else
                currentplayer="X";
            currentplayerSymbolLabel.Text=currentplayer;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text=currentplayer;

            if (CheckIswinner())
            {

                winnerlabel.Text="WINNER: "+currentplayer;

                return;
            }

            if (currentplayer=="X")
                currentplayer="O";

            else
                currentplayer="X";
            currentplayerSymbolLabel.Text=currentplayer;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text=currentplayer;

            if (CheckIswinner())
            {

                winnerlabel.Text="WINNER: "+currentplayer;

                return;
            }
        
            if (currentplayer=="X")
                currentplayer="0";

            else
                currentplayer="X";
            currentplayerSymbolLabel.Text=currentplayer;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text=currentplayer;

            if (CheckIswinner())
            {

                winnerlabel.Text="WINNER: "+currentplayer;

                return;
            }

            if (currentplayer=="X")
                currentplayer="O";

            else
                currentplayer="X";
            currentplayerSymbolLabel.Text=currentplayer;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text=currentplayer;

            if (CheckIswinner())
            {

                winnerlabel.Text="WINNER: "+currentplayer; 

                return;
            }

            if (currentplayer=="X")
                currentplayer="O";

            else
                currentplayer="X";
            currentplayerSymbolLabel.Text=currentplayer;
        }

        private void currentplayerSymbolLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string name1 = Tbplayer1.Text;
            string name2 = Player2.Text;
            welcome.Text="Hello "+name1+" and "+name2+"  you may start now"; 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            welcome.Text="";
        }
    }
}