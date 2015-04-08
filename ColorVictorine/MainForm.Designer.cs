namespace ColorVictorine
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divider = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endlessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toXerrMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoErrMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeErrMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveErrMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenErrMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forTimeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sec10MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sec30MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.min2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.min1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.min5MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.min10MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figuresMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fig1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fig2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fig3MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fig4MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rndFigsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень4ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень6ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень7ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rndClrsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rndAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyHardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoAnsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourAnsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sixAnsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Silver;
            this.panel.Controls.Add(this.menuStrip1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(426, 169);
            this.panel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuItem,
            this.gameModeMenuItem,
            this.levelMenuItem,
            this.easyHardMenuItem,
            this.helpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameMenuItem
            // 
            this.gameMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenuItem,
            this.divider,
            this.exitMenuItem});
            this.gameMenuItem.Name = "gameMenuItem";
            this.gameMenuItem.Size = new System.Drawing.Size(46, 20);
            this.gameMenuItem.Text = "Игра";
            // 
            // newGameMenuItem
            // 
            this.newGameMenuItem.Name = "newGameMenuItem";
            this.newGameMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newGameMenuItem.Text = "Новая игра";
            this.newGameMenuItem.Click += new System.EventHandler(this.newGameMenuItem_Click);
            // 
            // divider
            // 
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(133, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // gameModeMenuItem
            // 
            this.gameModeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endlessMenuItem,
            this.toXerrMenuItem,
            this.forTimeMenuItem});
            this.gameModeMenuItem.Name = "gameModeMenuItem";
            this.gameModeMenuItem.Size = new System.Drawing.Size(88, 20);
            this.gameModeMenuItem.Text = "Режим игры";
            // 
            // endlessMenuItem
            // 
            this.endlessMenuItem.Name = "endlessMenuItem";
            this.endlessMenuItem.Size = new System.Drawing.Size(149, 22);
            this.endlessMenuItem.Text = "Бесконечный";
            this.endlessMenuItem.Click += new System.EventHandler(this.endlessMenuItem_Click);
            // 
            // toXerrMenuItem
            // 
            this.toXerrMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twoErrMenuItem,
            this.threeErrMenuItem,
            this.fiveErrMenuItem,
            this.tenErrMenuItem});
            this.toXerrMenuItem.Name = "toXerrMenuItem";
            this.toXerrMenuItem.Size = new System.Drawing.Size(149, 22);
            this.toXerrMenuItem.Text = "До Х ошибок";
            // 
            // twoErrMenuItem
            // 
            this.twoErrMenuItem.Name = "twoErrMenuItem";
            this.twoErrMenuItem.Size = new System.Drawing.Size(134, 22);
            this.twoErrMenuItem.Tag = "2";
            this.twoErrMenuItem.Text = "2 ошибки";
            this.twoErrMenuItem.Click += new System.EventHandler(this.ErrMenuItem_Click);
            // 
            // threeErrMenuItem
            // 
            this.threeErrMenuItem.Name = "threeErrMenuItem";
            this.threeErrMenuItem.Size = new System.Drawing.Size(134, 22);
            this.threeErrMenuItem.Tag = "3";
            this.threeErrMenuItem.Text = "3 ошибки";
            this.threeErrMenuItem.Click += new System.EventHandler(this.ErrMenuItem_Click);
            // 
            // fiveErrMenuItem
            // 
            this.fiveErrMenuItem.Name = "fiveErrMenuItem";
            this.fiveErrMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fiveErrMenuItem.Tag = "5";
            this.fiveErrMenuItem.Text = "5 ошибок";
            this.fiveErrMenuItem.Click += new System.EventHandler(this.ErrMenuItem_Click);
            // 
            // tenErrMenuItem
            // 
            this.tenErrMenuItem.Name = "tenErrMenuItem";
            this.tenErrMenuItem.Size = new System.Drawing.Size(134, 22);
            this.tenErrMenuItem.Tag = "10";
            this.tenErrMenuItem.Text = "10 ошибок";
            this.tenErrMenuItem.Click += new System.EventHandler(this.ErrMenuItem_Click);
            // 
            // forTimeMenuItem
            // 
            this.forTimeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sec10MenuItem,
            this.sec30MenuItem,
            this.min2MenuItem,
            this.min1MenuItem,
            this.min5MenuItem,
            this.min10MenuItem});
            this.forTimeMenuItem.Name = "forTimeMenuItem";
            this.forTimeMenuItem.Size = new System.Drawing.Size(149, 22);
            this.forTimeMenuItem.Text = "На время";
            // 
            // sec10MenuItem
            // 
            this.sec10MenuItem.Name = "sec10MenuItem";
            this.sec10MenuItem.Size = new System.Drawing.Size(115, 22);
            this.sec10MenuItem.Tag = "10";
            this.sec10MenuItem.Text = "10 сек.";
            this.sec10MenuItem.Click += new System.EventHandler(this.XsecMenuItem_Click);
            // 
            // sec30MenuItem
            // 
            this.sec30MenuItem.Name = "sec30MenuItem";
            this.sec30MenuItem.Size = new System.Drawing.Size(115, 22);
            this.sec30MenuItem.Tag = "30";
            this.sec30MenuItem.Text = "30 сек.";
            this.sec30MenuItem.Click += new System.EventHandler(this.XsecMenuItem_Click);
            // 
            // min2MenuItem
            // 
            this.min2MenuItem.Name = "min2MenuItem";
            this.min2MenuItem.Size = new System.Drawing.Size(115, 22);
            this.min2MenuItem.Tag = "120";
            this.min2MenuItem.Text = "2 мин.";
            this.min2MenuItem.Click += new System.EventHandler(this.XsecMenuItem_Click);
            // 
            // min1MenuItem
            // 
            this.min1MenuItem.Name = "min1MenuItem";
            this.min1MenuItem.Size = new System.Drawing.Size(115, 22);
            this.min1MenuItem.Tag = "60";
            this.min1MenuItem.Text = "1 мин.";
            this.min1MenuItem.Click += new System.EventHandler(this.XsecMenuItem_Click);
            // 
            // min5MenuItem
            // 
            this.min5MenuItem.Name = "min5MenuItem";
            this.min5MenuItem.Size = new System.Drawing.Size(115, 22);
            this.min5MenuItem.Tag = "300";
            this.min5MenuItem.Text = "5 мин.";
            this.min5MenuItem.Click += new System.EventHandler(this.XsecMenuItem_Click);
            // 
            // min10MenuItem
            // 
            this.min10MenuItem.Name = "min10MenuItem";
            this.min10MenuItem.Size = new System.Drawing.Size(115, 22);
            this.min10MenuItem.Tag = "600";
            this.min10MenuItem.Text = "10 мин.";
            this.min10MenuItem.Click += new System.EventHandler(this.XsecMenuItem_Click);
            // 
            // levelMenuItem
            // 
            this.levelMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figuresMenuItem,
            this.colorsMenuItem,
            this.rndAllMenuItem});
            this.levelMenuItem.Name = "levelMenuItem";
            this.levelMenuItem.Size = new System.Drawing.Size(65, 20);
            this.levelMenuItem.Text = "Уровень";
            // 
            // figuresMenuItem
            // 
            this.figuresMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fig1MenuItem,
            this.fig2MenuItem,
            this.fig3MenuItem,
            this.fig4MenuItem,
            this.rndFigsMenuItem});
            this.figuresMenuItem.Name = "figuresMenuItem";
            this.figuresMenuItem.Size = new System.Drawing.Size(168, 22);
            this.figuresMenuItem.Text = "Изучаем фигуры";
            // 
            // fig1MenuItem
            // 
            this.fig1MenuItem.Name = "fig1MenuItem";
            this.fig1MenuItem.Size = new System.Drawing.Size(152, 22);
            this.fig1MenuItem.Tag = "8";
            this.fig1MenuItem.Text = "Уровень 1";
            this.fig1MenuItem.Click += new System.EventHandler(this.levelMenuItem_Click);
            // 
            // fig2MenuItem
            // 
            this.fig2MenuItem.Name = "fig2MenuItem";
            this.fig2MenuItem.Size = new System.Drawing.Size(152, 22);
            this.fig2MenuItem.Tag = "9";
            this.fig2MenuItem.Text = "Уровень 2";
            this.fig2MenuItem.Click += new System.EventHandler(this.levelMenuItem_Click);
            // 
            // fig3MenuItem
            // 
            this.fig3MenuItem.Name = "fig3MenuItem";
            this.fig3MenuItem.Size = new System.Drawing.Size(152, 22);
            this.fig3MenuItem.Tag = "10";
            this.fig3MenuItem.Text = "Уровень 3";
            this.fig3MenuItem.Click += new System.EventHandler(this.levelMenuItem_Click);
            // 
            // fig4MenuItem
            // 
            this.fig4MenuItem.Name = "fig4MenuItem";
            this.fig4MenuItem.Size = new System.Drawing.Size(152, 22);
            this.fig4MenuItem.Tag = "11";
            this.fig4MenuItem.Text = "Уровень 4";
            this.fig4MenuItem.Click += new System.EventHandler(this.levelMenuItem_Click);
            // 
            // rndFigsMenuItem
            // 
            this.rndFigsMenuItem.Name = "rndFigsMenuItem";
            this.rndFigsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rndFigsMenuItem.Tag = "3";
            this.rndFigsMenuItem.Text = "Случайно";
            this.rndFigsMenuItem.Click += new System.EventHandler(this.randLevelMenuItem_Click);
            // 
            // colorsMenuItem
            // 
            this.colorsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.уровень2ToolStripMenuItem1,
            this.уровень3ToolStripMenuItem1,
            this.уровень4ToolStripMenuItem1,
            this.уровень5ToolStripMenuItem1,
            this.уровень6ToolStripMenuItem1,
            this.уровень7ToolStripMenuItem1,
            this.rndClrsMenuItem});
            this.colorsMenuItem.Name = "colorsMenuItem";
            this.colorsMenuItem.Size = new System.Drawing.Size(168, 22);
            this.colorsMenuItem.Text = "Изучаем цвета";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Tag = "1";
            this.toolStripMenuItem2.Text = "Уровень 1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.levelMenuItem_Click);
            // 
            // уровень2ToolStripMenuItem1
            // 
            this.уровень2ToolStripMenuItem1.Name = "уровень2ToolStripMenuItem1";
            this.уровень2ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.уровень2ToolStripMenuItem1.Tag = "2";
            this.уровень2ToolStripMenuItem1.Text = "Уровень 2";
            this.уровень2ToolStripMenuItem1.Click += new System.EventHandler(this.levelMenuItem_Click);
            // 
            // уровень3ToolStripMenuItem1
            // 
            this.уровень3ToolStripMenuItem1.Name = "уровень3ToolStripMenuItem1";
            this.уровень3ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.уровень3ToolStripMenuItem1.Tag = "3";
            this.уровень3ToolStripMenuItem1.Text = "Уровень 3";
            this.уровень3ToolStripMenuItem1.Click += new System.EventHandler(this.levelMenuItem_Click);
            // 
            // уровень4ToolStripMenuItem1
            // 
            this.уровень4ToolStripMenuItem1.Name = "уровень4ToolStripMenuItem1";
            this.уровень4ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.уровень4ToolStripMenuItem1.Tag = "4";
            this.уровень4ToolStripMenuItem1.Text = "Уровень 4";
            this.уровень4ToolStripMenuItem1.Click += new System.EventHandler(this.levelMenuItem_Click);
            // 
            // уровень5ToolStripMenuItem1
            // 
            this.уровень5ToolStripMenuItem1.Name = "уровень5ToolStripMenuItem1";
            this.уровень5ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.уровень5ToolStripMenuItem1.Tag = "5";
            this.уровень5ToolStripMenuItem1.Text = "Уровень 5";
            this.уровень5ToolStripMenuItem1.Click += new System.EventHandler(this.levelMenuItem_Click);
            // 
            // уровень6ToolStripMenuItem1
            // 
            this.уровень6ToolStripMenuItem1.Name = "уровень6ToolStripMenuItem1";
            this.уровень6ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.уровень6ToolStripMenuItem1.Tag = "6";
            this.уровень6ToolStripMenuItem1.Text = "Уровень 6";
            this.уровень6ToolStripMenuItem1.Click += new System.EventHandler(this.levelMenuItem_Click);
            // 
            // уровень7ToolStripMenuItem1
            // 
            this.уровень7ToolStripMenuItem1.Name = "уровень7ToolStripMenuItem1";
            this.уровень7ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.уровень7ToolStripMenuItem1.Tag = "7";
            this.уровень7ToolStripMenuItem1.Text = "Уровень 7";
            this.уровень7ToolStripMenuItem1.Click += new System.EventHandler(this.levelMenuItem_Click);
            // 
            // rndClrsMenuItem
            // 
            this.rndClrsMenuItem.Name = "rndClrsMenuItem";
            this.rndClrsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rndClrsMenuItem.Tag = "2";
            this.rndClrsMenuItem.Text = "Случайно";
            this.rndClrsMenuItem.Visible = false;
            this.rndClrsMenuItem.Click += new System.EventHandler(this.randLevelMenuItem_Click);
            // 
            // rndAllMenuItem
            // 
            this.rndAllMenuItem.Name = "rndAllMenuItem";
            this.rndAllMenuItem.Size = new System.Drawing.Size(168, 22);
            this.rndAllMenuItem.Tag = "1";
            this.rndAllMenuItem.Text = "Случайно";
            this.rndAllMenuItem.Click += new System.EventHandler(this.randLevelMenuItem_Click);
            // 
            // easyHardMenuItem
            // 
            this.easyHardMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twoAnsMenuItem,
            this.fourAnsMenuItem,
            this.sixAnsMenuItem});
            this.easyHardMenuItem.Name = "easyHardMenuItem";
            this.easyHardMenuItem.Size = new System.Drawing.Size(81, 20);
            this.easyHardMenuItem.Text = "Сложность";
            // 
            // twoAnsMenuItem
            // 
            this.twoAnsMenuItem.Name = "twoAnsMenuItem";
            this.twoAnsMenuItem.Size = new System.Drawing.Size(140, 22);
            this.twoAnsMenuItem.Tag = "2";
            this.twoAnsMenuItem.Text = "2 варианта";
            this.twoAnsMenuItem.Click += new System.EventHandler(this.ansNumMenuItem_Click);
            // 
            // fourAnsMenuItem
            // 
            this.fourAnsMenuItem.Name = "fourAnsMenuItem";
            this.fourAnsMenuItem.Size = new System.Drawing.Size(140, 22);
            this.fourAnsMenuItem.Tag = "4";
            this.fourAnsMenuItem.Text = "4 варианта";
            this.fourAnsMenuItem.Click += new System.EventHandler(this.ansNumMenuItem_Click);
            // 
            // sixAnsMenuItem
            // 
            this.sixAnsMenuItem.Name = "sixAnsMenuItem";
            this.sixAnsMenuItem.Size = new System.Drawing.Size(140, 22);
            this.sixAnsMenuItem.Tag = "6";
            this.sixAnsMenuItem.Text = "6 вариантов";
            this.sixAnsMenuItem.Click += new System.EventHandler(this.ansNumMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpMenuItem.Text = "Справка";
            this.helpMenuItem.Click += new System.EventHandler(this.helpMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 169);
            this.Controls.Add(this.panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameMenuItem;
        private System.Windows.Forms.ToolStripSeparator divider;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyHardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoAnsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourAnsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sixAnsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameModeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endlessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toXerrMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoErrMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeErrMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiveErrMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forTimeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sec30MenuItem;
        private System.Windows.Forms.ToolStripMenuItem min1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem min2MenuItem;
        private System.Windows.Forms.ToolStripMenuItem min5MenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenErrMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem min10MenuItem;
        private System.Windows.Forms.ToolStripMenuItem sec10MenuItem;
        private System.Windows.Forms.ToolStripMenuItem figuresMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fig1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem fig2MenuItem;
        private System.Windows.Forms.ToolStripMenuItem fig3MenuItem;
        private System.Windows.Forms.ToolStripMenuItem fig4MenuItem;
        private System.Windows.Forms.ToolStripMenuItem rndFigsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem rndClrsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rndAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem уровень3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem уровень4ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem уровень5ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem уровень6ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem уровень7ToolStripMenuItem1;
    }
}

