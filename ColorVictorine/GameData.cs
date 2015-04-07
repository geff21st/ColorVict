using System;
using System.Collections.Generic;

using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using NAudio;
using NAudio.Wave;

 
namespace ColorVictorine
{
    class GameData
    {
        public      Font        reg_font       = new Font("Calibri", 26F, FontStyle.Bold, GraphicsUnit.Point, 204);
        public      Font        big_font       = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point, 204);
        public      Font        small_font     = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
                    
        public      Color       bg_clr         =  Color.FromArgb(225, 225, 225);
        private     Graphics    g;
        public      Color  []   colors         { get; private set; }
        public      string []   clr_names      { get; private set; }
        public      string []   clr_sounds     { get; private set; }
        public      string []   fig_names      { get; private set; }
                    
        public      int         n_colors       { get; private set; }
        public      int         n_figures      { get; private set; }

        public Color[]   seven_bttns_clr =
        {
            ColorTranslator.FromHtml("#0d3783"),
            ColorTranslator.FromHtml("#ee0000")
        };

        public string[]  seven_bttns_txt =
        {
            "Верно",
            "Неверно"
        };

        public string[] questions =
        {
            "Найди такой же цвет:",
            "Какой это цвет?",
            "Название какого цвета ты слышишь?",
            "Название какого цвета ты слышишь?",
            "Нади цвет с таким названием:",
            "Какой цвет называется также?",
            "Верно ли соответствие?",
            "Вопрос к уровню 8",
            "Вопрос к уровню 9",
            "Вопрос к уровню 10",
            "Вопрос к уровню 11"
        };

        
        
        IWavePlayer waveOutDevice;
        AudioFileReader audioFileReader;

        public GameData()
        {
            Init();
        }

        void Init()
        {
            waveOutDevice = new WaveOut();

            string[] data = File.ReadAllLines("colorlib.txt");
            n_colors = data.Length;

            colors      = new Color  [n_colors];
            clr_names   = new string [n_colors];
            clr_sounds  = new string [n_colors];

            string[] str;

            for (int i = 0; i < data.Length; i++)
            {
                str = data[i].Split();
                colors [i] = ColorTranslator.FromHtml(str[0]);
                clr_names  [i] = str[1];
                clr_sounds [i] = str[2];
            }

            data = File.ReadAllLines("figureslib.txt");
            n_figures = data.Length;

            fig_names   = new string [n_figures];

            for (int i = 0; i < data.Length; i++)
            {
                fig_names[i] = data[i];
            }
        }

        public void PlaySound(int i)
        {
            waveOutDevice.Stop();
            waveOutDevice.Dispose();
            waveOutDevice = new WaveOut();
            audioFileReader = new AudioFileReader(clr_sounds[i]);
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }

        public void DrawFigure(Control label, int i)
        {
            g = label.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;

            switch (fig_names[i])
            {
                case "круг":
                    break;
                case "овал":
                    break;
                case "квадрат":
                    break;
                case "ромб":
                    break;
                case "треугольник":
                    break;
            }
        }
    }
}
