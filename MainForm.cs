
using NAudio.Wave;

namespace AlarmClock
{
    public partial class MainForm : Form
    {
        bool clockOn = true;
        // Music alarm = new Music();
        public MainForm()
        {

            InitializeComponent();
            UpdateClock();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateClock();
        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }
        private void UpdateClock()
        {

            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            if (hour < 10)
                lblClockHours.Text = "0" + hour.ToString();
            else
                lblClockHours.Text = hour.ToString();

            if (minute < 10)
                lblClockMinutes.Text = "0" + minute.ToString();
            else
                lblClockMinutes.Text = minute.ToString();

            if (second < 10)
                lblClockSeconds.Text = "0" + second.ToString();
            else
                lblClockSeconds.Text = second.ToString();

            //if(!isValid(txbHour.Text, txbMinutes.Text))
            //{
            //    MessageBox.Show("קלט לא תקין");
            //    txbHour.Text = "00";
            //    txbMinutes.Text = "00";
            //}

            if (lblClockHours.Text == txbHour.Text
                && lblClockMinutes.Text == txbMinutes.Text && second == 0)
            {
                if(clockOn) 
                    Music.Play(@"AlarmAudio.mp3");
            }
        }
        private bool isValid(string hour, string minutes)
        {
            if (hour.Length == 2 && minutes.Length == 2)
            {
                if (StringHelper.IsNumeric(txbHour.Text) && StringHelper.IsNumeric(txbMinutes.Text))
                {
                    if ((int.Parse(hour) < 25 && int.Parse(hour) >= 0)
                        && (int.Parse(minutes) < 60 && int.Parse(minutes) >= 0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void isValidHour(object sender, EventArgs e)
        {
            if (!(txbHour.Text.Length == 2) ||
                !StringHelper.IsNumeric(txbHour.Text) ||
                !(int.Parse(txbHour.Text) < 25 && int.Parse(txbHour.Text) >= 0))
            {

                MessageBox.Show("קלט לא תקין");
                txbHour.Text = "00";
            }
        }
        private void isValidMinutes(object sender, EventArgs e)
        {
            if (!(txbMinutes.Text.Length == 2) ||
                !StringHelper.IsNumeric(txbMinutes.Text) ||
                !(int.Parse(txbMinutes.Text) < 60 && int.Parse(txbMinutes.Text) >= 0))
            {

                MessageBox.Show("קלט לא תקין");
                txbMinutes.Text = "00";
            }
        }
        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void lblClockMinutes_Click(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            clockOn = !clockOn;
            if (clockOn)
            {
                btnA.BackColor = Color.Green;
                btnA.Text = "on";
            }
            else
            {
                btnA.BackColor = Color.Red;
                btnA.Text = "off";
                Music.Stop();
            }

        }

        
    }
}