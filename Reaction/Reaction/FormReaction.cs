using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reaction
{
    public partial class FormReaction : Form
    {
        int cardNr = 1;
        public FormReaction()
        {
            InitializeComponent();
        }

        public void ShowCard (int nr)
        {
            picture1.Visible = nr == 1;
            picture2.Visible = nr == 2;
            picture3.Visible = nr == 3;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cardNr++;
            if (cardNr > 3) 
                cardNr = 1;
            ShowCard(cardNr);

        }
    }

}
