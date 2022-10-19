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
            simpleTabControlPanel.Style.BackColor2.Color = Color.White;
            simpleTabControlPanel.Style.BackColor1.Color = Color.LightSlateGray;
            advancedTabControlPanel2.Style.BackColor2.Color = Color.LightSlateGray;
            advancedTabControlPanel2.Style.BackColor1.Color = Color.White;

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

            Region reg = Region.FromHrgn(CreateRoundRectRgn(0, 0, 95, 67, 30, 30));
            delBtn.Region = reg;
            CBtn.Region = reg;
            CEBtn.Region = reg;
            parenthesisBtn.Region = reg;
            lnBtn.Region = reg;
            logBtn.Region = reg;
            radicalBtn.Region = reg;
            x2Btn.Region = reg;
            nineBtn.Region = reg;
            eightBtn.Region = reg;
            sevenBtn.Region = reg;
            divideBtn.Region = reg;
            sixBtn.Region = reg;
            fiveBtn.Region = reg;
            fourBtn.Region = reg;
            timesBtn.Region = reg;
            threeBtn.Region = reg;
            twoBtn.Region = reg;
            oneBtn.Region = reg;
            minusBtn.Region = reg;
            equallBtn.Region = reg;
            dotBtn.Region = reg;
            zeroBtn.Region = reg;
            plusBtn.Region = reg;

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = alwaysTopChk.Checked;
        }
        
    }

    public class myButton : Button
    {
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
    }
}
