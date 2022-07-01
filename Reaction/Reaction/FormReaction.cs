using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reaction
{
    public partial class FormReaction : Form
    {
        int total_clicks = 10;
        int click_nr = -1;
        int reactime_ms = 0;
        int my_card_nr = 0;
        int waiting = 0;
        int min_waiting = 1;
        int max_waiting = 3;

        Stopwatch watch = new Stopwatch();
        Random rand = new Random();

        public FormReaction()
        {
            InitializeComponent();
            progress.Maximum = total_clicks;

        }

        public void ShowCard (int nr)
        {
            picture1.Visible = nr == 1;
            picture2.Visible = nr == 2;
            picture3.Visible = nr == 3;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (click_nr < 0) return;
            if (waiting > 0)
            {
                waiting--;
                if (waiting == 0)
                {
                    my_card_nr = rand.Next(1, 4);
                    ShowCard(my_card_nr);
                    watch.Restart();
                }
            }

            

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            click_nr = 0;
            reactime_ms = 0;
            buttonStart.Enabled = false;
            ShowCard(0);
            NextClick();
        }
       private void NextClick()
           {
            ShowCard(0);
            click_nr++;
            progress.Value = click_nr;
            waiting = rand.Next(min_waiting *1000 / timer.Interval, 
                                max_waiting *1000 / timer.Interval +1);
            
        }

        private void picture1_Click(object sender, EventArgs e)
        {
            watch.Stop();
            reactime_ms += (int)watch.ElapsedMilliseconds;
            if (click_nr >= total_clicks)
                ShowResults();
            else
            NextClick();
        }

        private void ShowResults()
        {
            double sec = reactime_ms / 1000.0 / total_clicks;
            MessageBox.Show("The middle time of reaction" + sec.ToString( " 0.000") + " sec", " Results");
            buttonStart.Enabled = true;
            click_nr = 1;
        }
    }

}
