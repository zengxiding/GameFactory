﻿using System.Drawing;
using System.Windows.Forms;

using KeLi.M3Game.Properties;

namespace KeLi.M3Game
{
    public sealed partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Back);
        }
    }
}