namespace CS311_Project2_RLV
{
    public partial class Form1 : Form
    {   /* Instantiating random generator 
         * sum as integer
         * balance as float starting balance of $100 */

        Random gen = new Random();
        int sum = 0;
        float balance = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDice2_Click(object sender, EventArgs e)
        {

        }//end lbl Dice2

        private void lblDice1_Click(object sender, EventArgs e)
        {


        }//end lbl Dice1

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            calculate_score();

        }//end btn Roll

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }//end lbl Balance

        private void txtPlaceBets_TextChanged(object sender, EventArgs e)
        {

        }//end txt Bet_text change

        private void lblOutcome_Click(object sender, EventArgs e)
        {

        }//end lbl Outcome

        private void calculate_score()
        {
            /* Instantiating dice as integers*/
            int die1 = 0;
            int die2 = 0;

            die1 = gen.Next(6) + 1;
            lblDice1.Text = "You rolled a " + die1;

            die2 = gen.Next(6) + 1;
            lblDice2.Text = "You rolled a " + die2;

            /* Sum equals random dice rolls */
            sum = die1 + die2;

            /* pBet as a float sorting a player's bet */
            float pBet = float.Parse(txtPlaceBets.Text);

            /* if statement for winning outcome */
            if (sum == 7 || sum == 11)
            {
                lblOutcome.Text = "You win!";
                balance = balance + pBet;
                lblBalance.Text = "Current balance: " + balance.ToString("C");

            }
            /* if statement for losing outcome, else statement for point */
            else if (sum == 2 || sum == 3 || sum == 12)
            {
                lblOutcome.Text = "You lost.";
                balance = balance - pBet;
                lblBalance.Text = "Current balance: " + balance.ToString("C");
            }
            else
            {
                lblOutcome.Text = "Outcome: point is " + sum;
                lblBalance.Text = "Your balance is: " + balance.ToString("C");
            }
            /* if statement for insufficent balance */
            if (pBet > balance || balance - pBet < 0)
            {
                MessageBox.Show("Your balance is insuffiecent. Unable to roll.");
            }


        }//end calculateScore()

    }//end class

}//end namespace