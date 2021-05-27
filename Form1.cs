using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace ArbeitszeitErfassung
{
    public partial class Form1 : Form
    {

        public DateTime begin;
        public List<Tuple<DateTime, DateTime>> breaks = new List<Tuple<DateTime,DateTime>>();

        public DateTime breakBegin;
        public DateTime breakEnd;

        public DateTime end;    // when clicked finish
        public DateTime feierabend; // calculated feierabend time (begin+break+8hrs)

        public bool havingBreak = false;

        public bool forceExit = false;

        // statics
        public static DateTime finalBegin;
        public static DateTime finalEnd;
        public static TimeSpan finalWorktime;
        public static List<Tuple<DateTime, DateTime>> finalBreaks = new List<Tuple<DateTime, DateTime>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // button states
            btnBegin.Enabled = true;
            btnBreak.Enabled = false;
            btnEnd.Enabled = false;
            btnSave.Enabled = false;

            lblTimeBegan.Text = "";
            lblTimePassed.Text = "";
            lblTimeEnd.Text = "";
        }

        public DateTime getRoundedTime(DateTime givenTime)
        {
            if(Properties.Settings.Default.RoundTime15Minutes == false)
            {
                return givenTime;
            }

            DateTime roundedDateTime;
            DateTime realDateTime = givenTime;
            int realHour = realDateTime.Hour;
            int realMinute = realDateTime.Minute;

            // round Minute
            int roundedMinute = realMinute;
            if (realMinute <= 6 || realMinute >= 51)
            {
                roundedMinute = 0;
            }
            else if (realMinute > 6 && realMinute <= 20)
            {
                roundedMinute = 15;
            } else if (realMinute > 20 && realMinute <= 38)
            {
                roundedMinute = 30;
            } else if(realMinute > 38 && realMinute <= 50)
            {
                roundedMinute = 45;
            } else
            {
                roundedMinute = 0;
            }

            roundedDateTime = realDateTime.Date + new TimeSpan(realHour, roundedMinute, 0);

            return roundedDateTime;
        }

        public void beginCount()
        {
            // button states
            btnBegin.Enabled = false;
            btnEnd.Enabled = true;
            btnBreak.Enabled = true;
            pauseToolStripMenuItem.Enabled = true;
            startToolStripMenuItem.Enabled = false;
            btnSave.Enabled = false;

            lblTimePassed.Text = "00:00";

            begin = getRoundedTime(DateTime.Now);
            begin = zeroSeconds(begin);

            lblTimeBegan.Text = begin.ToString("HH") + ":" + begin.ToString("mm");
            timerTick.Enabled = true;

            lblTimeEnd.Text = begin.AddHours(8).ToString("HH") + ":" + begin.AddHours(8).ToString("mm");
        }

        public void startBreak() {
            havingBreak = true;
            // button states
            btnBreak.Text = "Fortsetzen";
            pauseToolStripMenuItem.Text = "&Pause beenden";
            btnEnd.Enabled = false;

            timerTick.Enabled = false;
            timerBreaktime.Enabled = true;

            breakBegin = DateTime.Now;
            breakBegin = zeroSeconds(breakBegin);

            calcFeierabend();
        }

        public DateTime zeroSeconds(DateTime d)
        {
            d = d.AddSeconds(-d.Second);
            d = d.AddMilliseconds(-d.Millisecond);
            return d;
        }

        public void endBreak() {
            havingBreak = false;
            // button states
            btnBreak.Text = "Pause";
            pauseToolStripMenuItem.Text = "&Pause beginnen";
            btnEnd.Enabled = true;

            breakEnd = DateTime.Now;
            breakEnd = zeroSeconds(breakEnd);
            breaks.Add(new Tuple<DateTime, DateTime>(breakBegin, breakEnd));

            calcBreakTotal();   // show total break time in lbl
            timerTick.Enabled = true;
            timerBreaktime.Enabled = false;

        }

        public void endCount()
        {
            // button states
            btnBegin.Enabled = true;
            btnEnd.Enabled = false;
            btnBreak.Enabled = false;
            pauseToolStripMenuItem.Enabled = false;
            startToolStripMenuItem.Enabled = true;
            btnSave.Enabled = true;

            end = zeroSeconds(DateTime.Now);

            timerTick.Enabled = false;
            timerBreaktime.Enabled = false;

        }

        // get time without breaks
        public TimeSpan getNettoTime()
        {
            int breakHoursTotal = 0;
            int breakMinutesTotal = 0;

            foreach(Tuple<DateTime,DateTime> breakEntry in breaks)
            {
                int breakEntryHours = breakEntry.Item1.Subtract(breakEntry.Item2).Hours * -1;
                int breakEntryMinutes = breakEntry.Item1.Subtract(breakEntry.Item2).Minutes * -1;

                breakHoursTotal = breakHoursTotal + breakEntryHours;
                breakMinutesTotal = breakMinutesTotal + breakEntryMinutes;
            }

            DateTime timeNow = DateTime.Now;
            timeNow = zeroSeconds(timeNow);

            TimeSpan passedNettoTime = begin.Subtract(timeNow.Add(new TimeSpan(-breakHoursTotal, -breakMinutesTotal, 0)));
            passedNettoTime = passedNettoTime.Add(new TimeSpan(0, 0, -1));   // hotfix
            calcFeierabend();
            return passedNettoTime;
        }

        public void calcBreakTotal()
        {
            int breakHoursTotal = 0;
            int breakMinutesTotal = 0;

            foreach (Tuple<DateTime, DateTime> breakEntry in breaks)
            {
                int breakEntryHours = breakEntry.Item1.Subtract(breakEntry.Item2).Hours * -1;
                int breakEntryMinutes = breakEntry.Item1.Subtract(breakEntry.Item2).Minutes * -1;

                breakHoursTotal = breakHoursTotal + breakEntryHours;
                breakMinutesTotal = breakMinutesTotal + breakEntryMinutes;
            }
            lblBreakTotal.Text = breakHoursTotal.ToString("D2") + ":" + breakMinutesTotal.ToString("D2");

            calcFeierabend();
        }

        public void calcFeierabend()
        {
            // breaktime:
            int breakHoursTotal = 0;
            int breakMinutesTotal = 0;
            foreach (Tuple<DateTime, DateTime> breakEntry in breaks)
            {
                int breakEntryHours = breakEntry.Item2.Subtract(breakEntry.Item1).Hours;
                int breakEntryMinutes = breakEntry.Item2.Subtract(breakEntry.Item1).Minutes;

                breakHoursTotal = breakHoursTotal + breakEntryHours;
                breakMinutesTotal = breakMinutesTotal + breakEntryMinutes;
            }

            feierabend = begin.AddHours(Properties.Settings.Default.ArbeitszeitStd + breakHoursTotal).AddMinutes(breakMinutesTotal);
            lblTimeEnd.Text = feierabend.ToString("HH") + ":" + feierabend.ToString("mm");


            // display time left in notify-icon
            TimeSpan nochZuArbeiten = feierabend.Subtract(DateTime.Now);
            string timeLeftString = "Noch " + nochZuArbeiten.Hours.ToString("D2") + ":" + nochZuArbeiten.Minutes.ToString("D2") + " h";
            notifyIcon.Text = timeLeftString;
            toolStripStatus_TimeLeft.Text = timeLeftString;
        }

        public void saveMeasurement()
        {
            // set static variables
            finalBegin = begin;
            finalEnd = end;
            finalBreaks = breaks;
            finalWorktime = getNettoTime();

            saveLogfile();
        }


        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            beginCount();
            toolStripStatusLabel1.Text = "Zeiterfassung aktiv";
            toolStripStatus_Bullet_Idle.Visible = false;
            toolStripStatus_Bullet_Active.Visible = true;
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            beginCount();
            toolStripStatusLabel1.Text = "Zeiterfassung aktiv";
            toolStripStatus_Bullet_Idle.Visible = false;
            toolStripStatus_Bullet_Active.Visible = true;
        }


        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (havingBreak)
            {
                endBreak();
                toolStripStatusLabel1.Text = "Zeiterfassung aktiv";
                toolStripStatus_Bullet_Break.Visible = false;
                toolStripStatus_Bullet_Active.Visible = true;
            }
            else
            {
                startBreak();
                toolStripStatusLabel1.Text = "Pause";
                toolStripStatus_Bullet_Active.Visible = false;
                toolStripStatus_Bullet_Break.Visible = true;
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            if(havingBreak)
            {
                endBreak();
                toolStripStatusLabel1.Text = "Zeiterfassung aktiv";
                toolStripStatus_Bullet_Break.Visible = false;
                toolStripStatus_Bullet_Active.Visible = true;
            } else
            {
                startBreak();
                toolStripStatusLabel1.Text = "Pause";
                toolStripStatus_Bullet_Active.Visible = false;
                toolStripStatus_Bullet_Break.Visible = true;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            endCount();
            toolStripStatusLabel1.Text = "Feierabend!";
            toolStripStatus_Bullet_Active.Visible = false;
            toolStripStatus_Bullet_Error.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveMeasurement();
            toolStripStatusLabel1.Text = "Gespeichert";
            toolStripStatus_Bullet_Error.Visible = false;
            toolStripStatus_Bullet_Active.Visible = true;
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            TimeSpan passedTime = getNettoTime();
            lblTimePassed.Text = passedTime.ToString("hh") + ":" + passedTime.ToString("mm");
        }

        private void timerBreaktime_Tick(object sender, EventArgs e)
        {
            calcBreakTotal();

            // display time left in notify-icon
            notifyIcon.Text = "Pause...";
        }


        private void saveLogfile()
        {
            DateTime now = DateTime.Now;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("==============================================================================");
            sb.AppendLine("Datum:  " + now.ToString("dd.MM.yyyy"));
            sb.AppendLine("Beginn:  " + finalBegin.ToString("HH:mm") + " Uhr");
            sb.AppendLine("Ende:    " + finalEnd.ToString("HH:mm") + " Uhr");
            sb.AppendLine("Arbeitszeit: " + finalWorktime.Hours.ToString("D2") + ":" + finalWorktime.Minutes.ToString("D2") + " h");
            sb.AppendLine("");
            sb.AppendLine("Pausen: ");
            int i = 1;
            foreach (Tuple<DateTime, DateTime> breakEntry in finalBreaks)
            {
                double min = Math.Max(0, Math.Floor(breakEntry.Item1.Subtract(breakEntry.Item2).TotalMinutes));
                sb.AppendLine(i + ": von " + breakEntry.Item1.ToString("HH:mm") + " Uhr bis " + breakEntry.Item2.ToString("HH:mm") + " Uhr  (" + min + " Minuten)");
                i++;
            }
            sb.AppendLine("==============================================================================");

            string filename = now.ToString("yyyy_MM_dd_fffffff") + ".txt";
            var pathWithEnvFull = @""+ Properties.Settings.Default.LogfilePath + "log_" + filename;
            var pathWithEnv = @""+ Properties.Settings.Default.LogfilePath;
            var filePathFull = Environment.ExpandEnvironmentVariables(pathWithEnvFull);
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);

            if(!Directory.Exists(filePath))
            {
                try
                {
                    Directory.CreateDirectory(filePath);
                } catch(Exception e)
                {
                    MessageBox.Show("Kann Verzeichnis \n" + filePath + "\nnicht anlegen!\n\nFehler:\n" + e.Message, "Fehler", MessageBoxButtons.OK);
                }
            }

            try
            {
                @File.WriteAllText(filePathFull, sb.ToString());
            } catch(Exception e)
            {
                MessageBox.Show(e.Message, "Fehler", MessageBoxButtons.OK);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Zeiterfassung beenden?", "Sicher?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                forceExit = true;
                System.Windows.Forms.Application.Exit();
            }
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings settingsForm = new FormSettings();
            settingsForm.Show();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!forceExit)
            {
                this.Hide();
                e.Cancel = true;    // prevent form closing
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized) {
                this.Hide();
            }
        }
    }
}
