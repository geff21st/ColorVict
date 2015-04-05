using System;
using System.Collections.Generic;

using System.IO;
using System.Drawing;
using Color = System.Drawing.Color;
using NAudio;
using NAudio.Wave;

 
namespace ColorVictorine
{
    class GameData
    {
        public Color     bg_clr =  Color.FromArgb(225, 225, 225);
        public Color  [] colors { get; private set; }
        public string [] names  { get; private set; }
        public string [] sounds { get; private set; }
        public int       N      { get; private set; }

        IWavePlayer waveOutDevice;
        AudioFileReader audioFileReader;

        //WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        //System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public string[] questions =
        {
            "Найди такой же цвет:",
            "Какой это цвет?",
            "Название какого цвета ты слышишь?",
            "Название какого цвета ты слышишь?",
            "Нади цвет с таким названием:",
            "Какой цвет называется также?",
            "Верно ли соответствие?"
        };

        public GameData()
        {
            Init();
        }

        void Init()
        {
            waveOutDevice = new WaveOut();

            string[] data = File.ReadAllLines("colorlib.txt");
            N = data.Length;

            colors = new Color  [N];
            names  = new string [N];
            sounds = new string [N];

            string[] str;

            for (int i = 0; i < data.Length; i++)
            {
                str = data[i].Split();
                colors [i] = ColorTranslator.FromHtml(str[0]);
                names  [i] = str[1];
                sounds [i] = str[2];
            }
        }

        public void PlaySound(int i)
        {
            waveOutDevice.Dispose();
            waveOutDevice = new WaveOut();
            audioFileReader = new AudioFileReader(sounds[i]);
            //waveOutDevice.Stop();
            waveOutDevice.Init(audioFileReader);
            //waveOutDevice.Stop();
            waveOutDevice.Play();
            //audio = new Audio(sounds[i], true);
            //audio.Play();
            //player.SoundLocation = sounds[i];
            //player.Load();
            //player.Play();
        }
    }
}
