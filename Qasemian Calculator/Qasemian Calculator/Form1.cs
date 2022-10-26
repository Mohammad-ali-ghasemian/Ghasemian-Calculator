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
        //making buttons round
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

        //inserting form drop shadow
        private const int CS_DropShadow = 0x00000001;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }
        public form()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {
            simpleTabControlPanel.Style.BackColor2.Color = Color.DeepSkyBlue;
            simpleTabControlPanel.Style.BackColor1.Color = Color.MediumAquamarine;
            advancedTabControlPanel.Style.BackColor2.Color = Color.MediumAquamarine;
            advancedTabControlPanel.Style.BackColor1.Color = Color.DeepSkyBlue;
            
            Color numbersColor = Color.FromArgb(130 ,116, 152, 157);
            Region reg = Region.FromHrgn(CreateRoundRectRgn(0, 0, 95, 67, 30, 30));

            foreach (Control control in simpleTabControlPanel.Controls)
            {
                if (control is Button)
                {
                    control.Region = reg;
                    if (control.Tag != null && control.Tag == "numberButtons")
                        control.BackColor = numbersColor;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = alwaysTopChk.Checked;
        }

        //making left-side colorfull half circle
        private void circlePnl_Paint(object sender, PaintEventArgs e)
        {
            Graphics halfCircle = this.circlePnl.CreateGraphics();
            SolidBrush SB = new SolidBrush(Color.MediumAquamarine);
            halfCircle.FillEllipse(SB, -90, 0, 165, 430);
        }

        private void labelsMouseLeave(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(116, 152, 157);
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "x2Btn":
                    x2PowerLbl.BackColor = color;
                    break;
                case "advanced2nBtn":
                    power2nLbl.BackColor = color;
                    break;
                case "advancedNapierBtn":
                    naiperPowerLbl.BackColor = color;
                    break;
                case "advancedLogBtn":
                    logXLbl.BackColor = color;
                    logYLbl.BackColor = color;
                    break;
                case "advancedRadicalBtn":
                    radicalYLbl.BackColor = color;
                    break;
                case "advancedPowerBtn":
                    powerLbl.BackColor = color;
                    break;
            }
        }

        private void labelsMouseHover(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(150, 200, 157);
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "x2Btn":
                    x2PowerLbl.BackColor = color;
                    break;
                case "advanced2nBtn":
                    power2nLbl.BackColor = color;
                    break;
                case "advancedNapierBtn":
                    naiperPowerLbl.BackColor = color;
                    break;
                case "advancedLogBtn":
                    logXLbl.BackColor = color;
                    logYLbl.BackColor = color;
                    break;
                case "advancedRadicalBtn":
                    radicalYLbl.BackColor = color;
                    break;
                case "advancedPowerBtn":
                    powerLbl.BackColor = color;
                    break;
            }
        }
    }
}
