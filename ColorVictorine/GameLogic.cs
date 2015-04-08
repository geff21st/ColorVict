using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorVictorine
{
    internal class GameField
    {
        private   DelegateSetSize set_cli_size;
        private   Control   panel;
        public    GameData data;
        public    Color     qlabel_color  =   Color.FromArgb(80, 80, 80);
        public    Color     txt_color     =   Color.FromArgb(60, 60, 60);

        public    Label     info_label;   
        public    Label     stat_label;   
        public    Label     quest_label;
        public    Label     quest_color;
        public    Label[]   ans_labels;

        private   Size      ans_size      =   new Size(420, 145);
        private   Size      qcolor_size   =   new Size(220, 90);
        public    Size      client_size   {   get; protected set; }
        private   Point     ans_start;        
                                              
        public    static    Random r      =   new Random();
                                              
        public    int       seven_text    =   -1;
        public    int       seven_color   =   -1;
        public    int       true_ans      =   -1;
        public    int       true_lbl      =   -1;
                                              
        private   int       max_ans_num   =   6;
        public    int       ans_num       {   get;           set; }
        public readonly int yesno_num     =   2;
        public    int       ans_type      {   get; protected set; }
        public    int       quest_type    {   get; private   set; }
        private   int       level = 1;        
        private   int       columns       =   2;
        private   int       space         =   14;
        private   int       border        =   24;


        public GameField(Control panel, int ans_num, DelegateSetSize set_cli_size)
        {
            this.panel = panel;
            this.set_cli_size = set_cli_size;
            this.ans_num = ans_num;
            Init();
        }

        void Init()
        {
            data = new GameData();
            ans_start = new Point(
                    border,
                    border*3 + qcolor_size.Height + 20
                );
            CreateField();
        }

        public void ReloadField(int ans_num)
        {
            this.ans_num = ans_num;
            DisposeAns();
            CreateAnsLabels();
            PlaceAnsLabes(ans_start);
            ShowAns(ans_num);
            //LoadField(level);
        }

        void DisposeAns()
        {
            foreach (var label in ans_labels)
            {
                label.Dispose();
            }
        }

        public void LoadField(int level)
        {
            ReInitAnsLabels();
            bool k = true;
            this.level = level;
            //
            //
            //ans_type   = 1              ответы - закрашенные прямоугольники, при наведении отображается текст
            //ans_type   = 2              ответы - текст, при наведении подсвечивается цветом
            //ans_type   = 3              ответы - две метки (ДА, НЕТ)
            //
            //фигуры
            //ans_type   = 4              ответы - прямоугольники с изображениями  фигур
            //                                     (при наведении - название       фигуры)
            //
            //ans_type   = 5              ответы - прямоугольники с названиями     фигур 
            //                                     (при наведении - изображение    фигуры)
            //
            //quest_type = 1              метка вопроса - закрашенный в цвет правильного ответа прямоугольник 
            //quest_type = 2              метка вопроса - прямоугольник с текстом
            //quest_type = 3              метка вопроса - кнопка "прослушать" для воспроизведения звука
            //quest_type = 4              метка вопроса - ткст, написанный цветом (соответствует ли название фактическому цвету) 
            //
            //фигуры
            //quest_type = 5              метка вопроса - изображение фигуры
            //quest_type = 6              метка вопроса - название    фигуры
            //
            //
            switch (level)
            {
                case 1:   quest_type = 1;   ans_type  = 1;  break;
                case 2:   quest_type = 1;   ans_type  = 2;  break;
                case 3:   quest_type = 2;   ans_type  = 1;  break;
                case 4:   quest_type = 2;   ans_type  = 2;  break;
                case 5:   quest_type = 3;   ans_type  = 1;  break;
                case 6:   quest_type = 3;   ans_type  = 2;  break;
                case 7:   quest_type = 4;   ans_type  = 3;  break;
                case 8:   quest_type = 5;   ans_type  = 4;  break;
                case 9:   quest_type = 5;   ans_type  = 5;  break;
                case 10:  quest_type = 6;   ans_type  = 4;  break;
                case 11:  quest_type = 6;   ans_type  = 5;  break;
            }
            PlaseLabels(ans_type);
        }

        void PlaseLabels(int ans_type)
        {
            int num;
            SetTrueAns(ans_type);
            
            SetQuestLabels();

            quest_label.Size = QLabelSize(quest_type);
            quest_color.Size = QColorSize(quest_type);
            quest_color.Location = QColorLocation(quest_type);
            PlaceAnsLabes(AnsStartPoint(ans_type));
            set_cli_size(ClientSize(ans_type));

            num = ans_type == 3 ? yesno_num : ans_num;
            
            SetAnsLabels(num, ans_type);
            ShowAns(num);
        }

        int RndNum(int to, int except)
        {
            int ans;
            if (except < 0) return r.Next(to);
            do
            {
                ans = r.Next(to);
            }   while (ans == except);
            return ans;
        }

        void SetTrueAns(int type)
        {
            if (type == 3)
            {
                seven_text = RndNum(data.n_colors, seven_text);

                true_ans = r.Next(2);

                seven_color = true_ans == 0 ? seven_text : RndNum(data.n_colors, -1);

            }
            else //if (type < 3)
            {
                true_lbl = RndNum(ans_num, true_lbl);

                switch (type)
                {
                    case 1:
                        true_ans = ans_num != 2 ? RndNum(data.n_colors, true_ans) : RndNum(data.n_colors, -1);
                        ans_labels[true_lbl].Text = "";
                        ans_labels[true_lbl].BackColor = data.colors[true_ans];
                        break;
                    case 2:
                        true_ans = ans_num != 2 ? RndNum(data.n_colors, true_ans) : RndNum(data.n_colors, -1);
                        ans_labels[true_lbl].BackColor = data.bg_clr;
                        ans_labels[true_lbl].ForeColor = txt_color;
                        ans_labels[true_lbl].Text = data.clr_names[true_ans].ToUpper();
                        break;
                    case 4:
                        true_ans = ans_num != 2 ? RndNum(data.n_figures, true_ans) : RndNum(data.n_figures, -1);
                        data.DrawFigure(ans_labels[true_lbl], true_ans);
                        break;
                    case 5:
                        true_ans = ans_num != 2 ? RndNum(data.n_figures, true_ans) : RndNum(data.n_figures, -1);
                        ans_labels[true_lbl].BackColor = data.bg_clr;
                        ans_labels[true_lbl].ForeColor = txt_color;
                        ans_labels[true_lbl].Text = data.fig_names[true_ans].ToUpper();
                        break;
                }
                 
                ans_labels[true_lbl].Tag = true_ans;
            }
        }

        void ReInitAnsLabels()
        {
            DisposeAns();
            CreateAnsLabels();
        }

        void SetAnsLabels(int ans_num, int type)
        {
            int ans;
            int num = type <= 3 ? data.n_colors : data.n_figures;

            for (int i = 0; i < ans_num; i++)
            {
                if (i == true_lbl && type!= 3) continue;

                do
                {
                    ans = r.Next(num);
                } while (ans == true_ans || ColorIsExist(i, ans));
                
                switch (type)
                {
                    case 1:
                        ans_labels[i].Text = "";
                        ans_labels[i].Tag = ans;
                        ans_labels[i].ForeColor = txt_color;
                        ans_labels[i].BackColor = data.colors[ans];
                        break;
                    case 2:
                        ans_labels[i].Text = data.clr_names[ans].ToUpper();
                        ans_labels[i].Tag = ans;
                        ans_labels[i].ForeColor = txt_color;
                        ans_labels[i].BackColor = data.bg_clr;
                        break;
                    case 3:
                        ans_labels[i].Text = data.seven_bttns_txt[i];
                        ans_labels[i].Tag = i;
                        ans_labels[i].ForeColor = Color.White;
                        ans_labels[i].BackColor = data.seven_bttns_clr[i];
                        break;
                    case 4:
                        ans_labels[i].Text = data.fig_names[ans].ToUpper();
                        ans_labels[i].Tag = ans;
                        ans_labels[i].ForeColor = txt_color;
                        ans_labels[i].BackColor = data.colors[RndNum(data.n_colors, -1)];
                        break;
                    case 5:
                        ans_labels[i].Text = data.fig_names[ans].ToUpper();
                        ans_labels[i].Tag = ans;
                        ans_labels[i].ForeColor = Color.White;
                        ans_labels[i].BackColor = data.colors[RndNum(data.n_colors, -1)];
                        break;
                }
            }
        }


        public void SetQuestLabels()
        {
            quest_label.Text = data.questions[level-1];
            
            switch (quest_type)
            {
                case 1:
                    quest_color.Click      -=   quest_color_MouseDown;
                    quest_color.BackColor   =   data.colors[true_ans];
                    quest_color.Text        =   "";
                    break;
                case 2:
                    quest_color.Click      +=   quest_color_MouseDown;
                    quest_color.BackColor   =   data.colors[RndNum(data.n_colors,-1)];
                    quest_color.ForeColor   =   Color.White;
                    quest_color.Font        =   data.small_font;
                    quest_color.Text        =   "прослушать";
                    data.PlaySound(true_ans);
                    break;
                case 3:
                    quest_color.Click      -=   quest_color_MouseDown;
                    quest_color.BackColor   =   qlabel_color;
                    quest_color.ForeColor   =   Color.White;
                    quest_color.Font        =   data.small_font;
                    quest_color.Text        =   data.clr_names[true_ans];
                    break;
                case 4:
                    quest_color.Click      -=   quest_color_MouseDown;
                    quest_color.BackColor   =   panel.BackColor;
                    quest_color.ForeColor   =   data.colors[seven_color];
                    quest_color.Font        =   data.big_font;
                    quest_color.Text        =   data.clr_names[seven_text].ToUpper();
                    break;
                case 5:
                    quest_color.Click      -=   quest_color_MouseDown;
                    data.DrawFigure(quest_color, true_ans);
                    break;
                case 6:
                    quest_color.Click      -=   quest_color_MouseDown;
                    quest_color.BackColor   =   data.colors[RndNum(data.n_colors,-1)];
                    quest_color.ForeColor   =   Color.White;
                    quest_color.Font        =   data.small_font;
                    quest_color.Text        =   data.fig_names[true_ans].ToUpper();
                    break;
            }
        }

        void quest_color_MouseDown(object sender, EventArgs e)
        {
            data.PlaySound(true_ans);
        }

        bool ColorIsExist(int i, int ans)
        {
            for (int j = 0; j <= i; j++)
            {
                if ((int)ans_labels[j].Tag == ans)
                    return true;
            }
            return false;
        }

        public Size ClientSize(int type = 1)
        {
            int width, height;

            width = ans_start.X*2 + ans_size.Width*columns + space*(columns - 1);

            if (type == 3)
            {
                height = AnsStartPoint(type).Y + ans_start.X + ans_size.Height;
            }
            else
            {
                height = ans_start.Y + (ans_size.Height + space) * (ans_num / columns) - space + ans_start.X;
            }
            
            client_size = new Size(width,height);
            return client_size;
        }

        private void CreateField()
        {
            ClientSize();
            CreateQuestLbls();
            CreateAnsLabels();
        }
        private void CreateQuestLbls()
        {
            //текст вопроса
            quest_label = new Label();
            quest_label.Size = QLabelSize(1);
            quest_label.Text = "Текст вопроса";
            quest_label.Location = new Point (
                                    ans_start.X, ans_start.X + 20);
            quest_label.BackColor = data.bg_clr;
            quest_label.ForeColor = txt_color;
            quest_label.Font = data.reg_font;
            quest_label.TextAlign = ContentAlignment.MiddleCenter;
            quest_label.BorderStyle = BorderStyle.None;
            panel.Controls.Add(quest_label);

            //цвет вопроса
            quest_color = new Label();
            quest_color.Size = QColorSize(1);
            quest_color.Text = "Цвет вопроса";
            quest_color.Location = QColorLocation(1);
            quest_color.BackColor = data.bg_clr;
            quest_color.ForeColor = Color.White;
            quest_color.Font = data.small_font;
            quest_color.TextAlign = ContentAlignment.MiddleCenter;
            quest_color.BorderStyle = BorderStyle.None;
            panel.Controls.Add(quest_color);

            //статистика
            stat_label = new Label();
            stat_label.Size = new Size(
                    ans_size.Width,
                    border*2
                );
            stat_label.Text = "статистика";
            //stat_label.Location = 
            stat_label.Location = new Point(
                    border + ans_size.Width + space,
                    quest_label.Location.Y + quest_label.Height
                );
            stat_label.BackColor = panel.BackColor;
            stat_label.ForeColor = txt_color;
            stat_label.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            stat_label.TextAlign = ContentAlignment.MiddleRight;
            stat_label.BorderStyle = BorderStyle.None;
            panel.Controls.Add(stat_label);

            //игровая информация
            info_label = new Label();
            info_label.Text = "игровая информация";
            info_label.Location = new Point(
                    border,
                    quest_label.Location.Y + quest_label.Height
                );
            info_label.Size         = stat_label.Size;
            info_label.Font         = stat_label.Font;
            info_label.BackColor    = stat_label.BackColor;
            info_label.ForeColor    = stat_label.ForeColor;
            info_label.BorderStyle  = stat_label.BorderStyle;
            info_label.TextAlign    = ContentAlignment.MiddleLeft;
            panel.Controls.Add(info_label);
        }

        Point AnsStartPoint(int type)
        {
            return type==3
                   ?
                   new Point(ans_start.X, ans_start.Y + ans_size.Height + space)
                   :
                   ans_start;
        }

        Point QColorLocation(int type)
        {
            return type == 4
                   ?
                   ans_start
                   :
                   new Point(ans_start.X + quest_label.Width + space,
                              quest_label.Location.Y);
        }
        Size QColorSize(int type)
        {
            return type == 4
                   ?
                   new Size(QLabelSize(type).Width, ans_size.Height)
                   :
                   qcolor_size;
        }
        Size QLabelSize(int type)
        {
            return type != 4
                   ?
                   new Size(client_size.Width - qcolor_size.Width - ans_start.X * 2 - space,
                             qcolor_size.Height)
                   :
                   new Size(client_size.Width - ans_start.X * 2,
                             qcolor_size.Height);
        }

        void ShowAns(int ans_num)
        {
            for (int i = 0; i < max_ans_num; i++)
            {
                ans_labels[i].Visible = i < ans_num;// ? true : false;
            }
        }

        private void CreateAnsLabels()
        {
            ans_labels = new Label[max_ans_num];
            for (int i = 0; i < max_ans_num; i++)
            {
                CreateAnsLabel(i);
            }

            PlaceAnsLabes(ans_start);

            ShowAns(ans_num);
        }
        
        void PlaceAnsLabes(Point ans_start)
        {
            for (int i = 0; i < ans_num; i++)
            {
                ans_labels[i].Location = new Point(
                        ans_start.X + (space + ans_size.Width)*(i%columns),
                        ans_start.Y + (space + ans_size.Height)*(i/columns)
                    );
            }
        }

        private void CreateAnsLabel(int i)
        {
            ans_labels[i] = new Label();
            ans_labels[i].Size = ans_size;
            ans_labels[i].Tag = -1;
            ans_labels[i].ForeColor = txt_color;
            ans_labels[i].Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ans_labels[i].TextAlign = ContentAlignment.MiddleCenter;
            ans_labels[i].BorderStyle = BorderStyle.None;
            
            panel.Controls.Add(ans_labels[i]);
        }
    }

    class GameLogic
    {
        private DelegateSetSize set_cli_size;

        private  GameField  field;

        private  Timer      timer;
        private  int        time;
        private  DateTime   start_time;
        private  int        max_var;

        public   Size       client_size;
        private  Label[]    ans_labels;

        public   string     mode        =    "бесконечный";
        private  int        max_err;
        public   Control    panel;
        private  int        ans_num     =    6;
        private  int        level       =    1;
        private  int        max_level   =    7;

        

        private  int        true_clicks =    0;
        private  int        wrng_clicks =    0;

        private  bool       rnd_level = false;

        public GameLogic(Control panel, DelegateSetSize set_cli_size, Timer timer)
        {
            this.panel = panel;
            this.set_cli_size = set_cli_size;
            this.timer = timer;
            
            Init();
        }

        void Init()
        {
            field = new GameField(panel, ans_num, set_cli_size);
            client_size = field.client_size;
            LoadLevel(true);
            SetEvents();
            timer.Tick += timer_Tick;
        }

        void SetEvents(bool k = true)
        {
            if (k)
            for (int i = 0; i < field.ans_num; i++)
            {
                field.ans_labels[i].MouseDown  += ans_MouseDown;
                field.ans_labels[i].MouseMove  += ans_MouseMove;
                field.ans_labels[i].MouseLeave += ans_MouseLeave;
            }

            if (k) return;
            for (int i = 0; i < field.ans_num; i++)
            {
                field.ans_labels[i].MouseDown  -= ans_MouseDown;
                field.ans_labels[i].MouseMove  -= ans_MouseMove;
                field.ans_labels[i].MouseLeave -= ans_MouseLeave;
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            time = max_var - (int)TimeSpan.FromTicks(DateTime.Now.Ticks - start_time.Ticks).TotalSeconds;
            SetInfoLabel();
            
            if (time <= 0)
            {
                timer.Stop();
                time = max_var;
                EndGame();
            } 
            
            
        }

        public void NewGame()
        {
            wrng_clicks = 0;
            true_clicks = 0;
            LoadLevel();
        }

        public void LoadLevel(bool next = false)
        {
            
            if (rnd_level) level = GameField.r.Next(1, max_level + 1);

            field.LoadField(level);
            //Режим: [" + mode + "]   
            field.stat_label.Text = "[ Верно: " + 
                                    true_clicks.ToString().PadLeft(3) + " | " +
                                    "Ошибок: "  + wrng_clicks.ToString().PadLeft(3) + " ]";

            SetInfoLabel();
            SetEvents();
        }

        void SetInfoLabel()
        {
            field.info_label.Text = "Режим игры: [ " + mode;

            switch (mode)
            {
                case "на время":
                    field.info_label.Text += " | " + SecondsToTime();
                    break;
                case "ошибки":
                    field.info_label.Text += " | " + max_var;
                    break;

            }

            field.info_label.Text += " ]";
        }

        string SecondsToTime()
        {
            return (time/60).ToString("D2") + " : " + (time%60).ToString("D2");
        }

        public void StartTimer()
        {
            start_time = DateTime.Now;
            timer.Enabled = true;
        }
        public void SetAnsNum(int i)
        {
            ans_num = i;
            field.ReloadField(ans_num);
            SetEvents();
            LoadLevel();
            set_cli_size(field.ClientSize(field.ans_type));
        }
        public void SetMode(string mode, int a)
        {
            //switch (mode)
            //{
            //    case "бесконечный":
            //        break;
            //    case "ошибки":
                    
            //        break;
            //    case "на время":
            //        max_time = a;
            //        break;
            //}
            
            max_var = time = a;
            this.mode = mode;
            LoadLevel();
        }
        public void SetRandLevel()
        {
            rnd_level = true;
        }
        public void SetLevel(int i)
        {
            rnd_level = false;
            level = i;
            LoadLevel(true);
        }

        private void ans_MouseLeave (object sender, EventArgs e)
        {
            var label = (Label)sender;
            switch (field.ans_type)
            {
                case 2:
                    label.ForeColor = field.txt_color;
                    label.BackColor = field.data.bg_clr;
                    break;
                case 1:
                    label.ForeColor = field.txt_color;
                    label.Text = "";
                    break;
            }
        }
        private void ans_MouseMove  (object sender, EventArgs e)
        {
            var label = (Label)sender;
            switch (field.ans_type)
            {
                case 2:
                    label.ForeColor = Color.White;
                    label.BackColor = field.data.colors[(int)label.Tag];
                    break;
                case 1:
                    label.ForeColor = Color.White;
                    label.Text = field.data.clr_names[(int)label.Tag];
                    break;
            }
        }
        private void ans_MouseDown  (object sender, MouseEventArgs e)
        {
            var lbl = (Control)sender;

            PerformeAct((int)lbl.Tag == field.true_ans);
            LoadLevel(false);

            if (mode == "на время" && !timer.Enabled) 
                StartTimer();
        }

        void PerformeAct(bool k)
        {
            true_clicks =  k ? true_clicks + 1 : true_clicks;
            wrng_clicks = !k ? wrng_clicks + 1 : wrng_clicks;

            switch (mode)
            {
                case "ошибки":
                    if (wrng_clicks >= max_var) EndGame();
                    break;
            }
        }
        void EndGame()
        {
            MessageBox.Show("Игра окончена!\n" +
                            "[ " + true_clicks + " ] правильных ответов.");
            NewGame();
        }
    }
}
