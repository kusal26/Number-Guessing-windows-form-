namespace NumberGuessing_game
{
    public partial class Form1 : Form
    {
        Random randomNumber = new Random();
        int number = 0;
        int guess = 0;
        public Form1()
        {
            InitializeComponent();
            loadQuestion();


        }

        private void checkbutton_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            guess += 1;
            lblguesstimes.Text = "you Guessed " + guess + " times";
            if (i == number)
            {
                MessageBox.Show("correct Answer");
                loadQuestion();
                textBox1.Text = "";
                guess = 0;
                lblguesstimes.Text = "you Guessed " + guess + " times";

            }
            else if (i < number)
            {
                MessageBox.Show("its low");
            }
            else
                MessageBox.Show("its high");

        }
        private void loadQuestion()
        {
            number = randomNumber.Next(0, 10);
            lblquestion.Text = "I want to Chose a number Between 0-10";
        }


    }
}