using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace econGameOfChamps
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void InputTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                commandHandler();
            }
        }

        public void openAddPlayerWindow()
        {
            Form1 addPlayerWindow = new Form1();
            addPlayerWindow.ShowDialog();
            Player newPlayer = addPlayerWindow.getPlayer();
            addPlayerWindow.
        }

        public string commandHandler()
        {
            return "test output, need to change";
        }

        public void writeToOutpue(string s)
        {
            // enters string into output window + clears command input box
            outputTextbox.Text += s;
            inputTextbox.Text = "";
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            openAddPlayerWindow();
        }
    }
}
