﻿using System;
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
    public delegate void DelegateSetSize (Size size);

    public partial class MainForm : Form
    {
        private DelegateSetSize set_cli_size;
        private GameLogic game;
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            set_cli_size += size => { ClientSize = size; CenterToScreen(); };
            game = new GameLogic(panel, set_cli_size, timer);

            Text = "Изучаем цвета и фигуры вместе!";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = game.client_size;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void ansNumMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem) sender;
            game.SetAnsNum(int.Parse(item.Tag.ToString()));
            //ClientSize = game.client_size;
            //CenterToScreen();
            //game.LoadLevel();
        }

        private void levelMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            game.SetLevel(int.Parse(item.Tag.ToString()));
        }

        private void newGameMenuItem_Click(object sender, EventArgs e)
        {
            game.NewGame();
            game.SetLevel(1);  
        }

        private void randLevelMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            game.SetRandLevel(int.Parse(item.Tag.ToString()));
        }

        private void ErrMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            game.SetMode("ошибки", int.Parse(item.Tag.ToString()));
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void endlessMenuItem_Click(object sender, EventArgs e)
        {
            game.SetMode("бесконечный", 0);
        }

        private void XsecMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            game.SetMode("на время", int.Parse(item.Tag.ToString()));
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа призвана помочь детям и их родителям\n" +
                            "в изучении геометрических фигур и цветов.\n" +
                            "\n" +
                            "Над программой работали:\n" +
                            "Александр Кузнецов\n" +
                            "Сухов Иван\n\n" +
                            "© Чебоксары, 2015 г.");
        }
    }
}
