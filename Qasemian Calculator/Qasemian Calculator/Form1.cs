﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qasemian_Calculator
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {
            simpleTabControlPanel.Style.BackColor2.Color = Color.White;
            simpleTabControlPanel.Style.BackColor1.Color = Color.LightSlateGray;
            advancedTabControlPanel2.Style.BackColor2.Color = Color.LightSlateGray;
            advancedTabControlPanel2.Style.BackColor1.Color = Color.White;
            answerAreaBackgroundPanel.BackColor = Color.FromArgb(240, 255, 242, 201);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = alwaysTopChk.Checked;
        }
    }
}
