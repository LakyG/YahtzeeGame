using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeGame
{
    public partial class EndGameDialogue : Form
    {
        public EndGameDialogue(string msg)
        {
            InitializeComponent();

            lblText.Text = msg;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
