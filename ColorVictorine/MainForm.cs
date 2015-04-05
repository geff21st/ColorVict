using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorVictorine
{
    public partial class MainForm : Form
    {
        private GameLogic game;
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            game = new GameLogic(panel);
            Text = "Изучаем цвета веместе!";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = game.client_size;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            game.LoadLevel();
        }

        private void ansNumMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem) sender;
            game.SetAnsNum(int.Parse(item.Tag.ToString()));
            ClientSize = game.client_size;
            CenterToScreen();
            game.LoadLevel();
        }

        private void levelMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            game.SetLevel(int.Parse(item.Tag.ToString()));
        }

        private void newGameMenuItem_Click(object sender, EventArgs e)
        {
            game.NewGame();
            game.SetLevel(1);        }
    }
}
