using System.Diagnostics.Metrics;
using System.Globalization;
using System.Xml.Linq;

namespace W8FinalTerm2CappsTom
{
    public class Fortune //Used a protected string[] to show encapsulation but it could have been public as well.
    {
        protected string[] fortunes = { "Yes", "Hard NO", "Ask again later", "Consult someone close", "Tentative yes" };
    }
    public class Array : Fortune //Showing inheritance
    {
        public string[] Num
        {
            get { return fortunes; }
        }

    }
    public partial class Form1 : Form
    {
        Array s = new Array();
        public int counter = 0;
        public int countLimit = 5;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000; //Do not actually need this but it slows down the count so it helps when clicking the button repeatedly to see all the strings.
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e){      }
        private void btnFortune_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s.Num[counter]);
        }
        private void timer1_Tick(object sender, EventArgs e) //I could easily have used a random number generator but wanted to incorporate the timer.
        {
            counter++;
            if (counter >= countLimit)
                counter = 0;
        }
    }
}
