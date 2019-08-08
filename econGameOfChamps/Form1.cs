using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using econGameOfChamps;

namespace econGameOfChamps
{
    public partial class Form1 : Form
    {
        private Player p1;

        public Form1()
        {
            InitializeComponent();
        }

        public Player getPlayer()
        {
            return p1;
        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {
            string playerName = nameEnterBox.Text;
            string playerTeam = teamEnterBox.Text;
            p1 = new Player(42, playerName, playerTeam);
        }
    }
}
