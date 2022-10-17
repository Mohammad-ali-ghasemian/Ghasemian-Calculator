using System;
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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nButtom,
                int nWidthEllipse,
                int nHeightEllipse
            );
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

            Color numbersColor = Color.FromArgb(130 ,116, 152, 157);
            zeroBtn.BackColor = numbersColor;
            oneBtn.BackColor = numbersColor;
            twoBtn.BackColor = numbersColor;
            threeBtn.BackColor = numbersColor;
            fourBtn.BackColor = numbersColor;
            fiveBtn.BackColor = numbersColor;
            sixBtn.BackColor = numbersColor;
            sevenBtn.BackColor = numbersColor;
            eightBtn.BackColor = numbersColor;
            nineBtn.BackColor = numbersColor;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = alwaysTopChk.Checked;
        }
    }
}
