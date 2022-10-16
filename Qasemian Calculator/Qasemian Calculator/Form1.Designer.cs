namespace Qasemian_Calculator
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.simpleTabControlPanel = new DevComponents.DotNetBar.TabControlPanel();
            this.simpleTabItem = new DevComponents.DotNetBar.TabItem(this.components);
            this.advancedTabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.advancedTabItem = new DevComponents.DotNetBar.TabItem(this.components);
            this.alwaysTopChk = new System.Windows.Forms.CheckBox();
            this.answerAreaBackgroundPanel = new System.Windows.Forms.Panel();
            this.previousAnswerLabel = new DevComponents.DotNetBar.LabelX();
            this.answerAreaLabel = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.answerAreaBackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.simpleTabControlPanel);
            this.tabControl.Controls.Add(this.advancedTabControlPanel2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.FixedTabSize = new System.Drawing.Size(100, 30);
            this.tabControl.Location = new System.Drawing.Point(0, 98);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(434, 463);
            this.tabControl.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.simpleTabItem);
            this.tabControl.Tabs.Add(this.advancedTabItem);
            this.tabControl.Text = "tabControl";
            // 
            // simpleTabControlPanel
            // 
            this.simpleTabControlPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.simpleTabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleTabControlPanel.Location = new System.Drawing.Point(0, 33);
            this.simpleTabControlPanel.Name = "simpleTabControlPanel";
            this.simpleTabControlPanel.Padding = new System.Windows.Forms.Padding(1);
            this.simpleTabControlPanel.Size = new System.Drawing.Size(434, 430);
            this.simpleTabControlPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.simpleTabControlPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.simpleTabControlPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.simpleTabControlPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.simpleTabControlPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.simpleTabControlPanel.Style.GradientAngle = 90;
            this.simpleTabControlPanel.TabIndex = 1;
            this.simpleTabControlPanel.TabItem = this.simpleTabItem;
            this.simpleTabControlPanel.UseCustomStyle = true;
            // 
            // simpleTabItem
            // 
            this.simpleTabItem.AttachedControl = this.simpleTabControlPanel;
            this.simpleTabItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.simpleTabItem.BackColor2 = System.Drawing.Color.LightSlateGray;
            this.simpleTabItem.BorderColor = System.Drawing.Color.Navy;
            this.simpleTabItem.Name = "simpleTabItem";
            this.simpleTabItem.Text = "simple";
            this.simpleTabItem.TextColor = System.Drawing.Color.Black;
            // 
            // advancedTabControlPanel2
            // 
            this.advancedTabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.advancedTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedTabControlPanel2.Location = new System.Drawing.Point(0, 33);
            this.advancedTabControlPanel2.Name = "advancedTabControlPanel2";
            this.advancedTabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.advancedTabControlPanel2.Size = new System.Drawing.Size(434, 430);
            this.advancedTabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.advancedTabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.LightSlateGray;
            this.advancedTabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.advancedTabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.advancedTabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.advancedTabControlPanel2.Style.GradientAngle = -90;
            this.advancedTabControlPanel2.TabIndex = 5;
            this.advancedTabControlPanel2.TabItem = this.advancedTabItem;
            // 
            // advancedTabItem
            // 
            this.advancedTabItem.AttachedControl = this.advancedTabControlPanel2;
            this.advancedTabItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.advancedTabItem.BackColor2 = System.Drawing.Color.LightSlateGray;
            this.advancedTabItem.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.advancedTabItem.Name = "advancedTabItem";
            this.advancedTabItem.Text = "advanced";
            this.advancedTabItem.TextColor = System.Drawing.Color.Black;
            // 
            // alwaysTopChk
            // 
            this.alwaysTopChk.AutoSize = true;
            this.alwaysTopChk.BackColor = System.Drawing.Color.Maroon;
            this.alwaysTopChk.ForeColor = System.Drawing.Color.White;
            this.alwaysTopChk.Location = new System.Drawing.Point(308, 106);
            this.alwaysTopChk.Name = "alwaysTopChk";
            this.alwaysTopChk.Size = new System.Drawing.Size(91, 17);
            this.alwaysTopChk.TabIndex = 12;
            this.alwaysTopChk.Text = "always on top";
            this.alwaysTopChk.UseVisualStyleBackColor = false;
            this.alwaysTopChk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // answerAreaBackgroundPanel
            // 
            this.answerAreaBackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(201)))));
            this.answerAreaBackgroundPanel.Controls.Add(this.answerAreaLabel);
            this.answerAreaBackgroundPanel.Controls.Add(this.previousAnswerLabel);
            this.answerAreaBackgroundPanel.Location = new System.Drawing.Point(12, 12);
            this.answerAreaBackgroundPanel.Name = "answerAreaBackgroundPanel";
            this.answerAreaBackgroundPanel.Size = new System.Drawing.Size(410, 80);
            this.answerAreaBackgroundPanel.TabIndex = 13;
            // 
            // previousAnswerLabel
            // 
            this.previousAnswerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            // 
            // 
            // 
            this.previousAnswerLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.previousAnswerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.previousAnswerLabel.Location = new System.Drawing.Point(3, 4);
            this.previousAnswerLabel.Name = "previousAnswerLabel";
            this.previousAnswerLabel.SingleLineColor = System.Drawing.Color.Black;
            this.previousAnswerLabel.Size = new System.Drawing.Size(404, 23);
            this.previousAnswerLabel.TabIndex = 0;
            // 
            // answerAreaLabel
            // 
            this.answerAreaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            // 
            // 
            // 
            this.answerAreaLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.answerAreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.answerAreaLabel.ForeColor = System.Drawing.Color.Black;
            this.answerAreaLabel.Location = new System.Drawing.Point(3, 29);
            this.answerAreaLabel.Name = "answerAreaLabel";
            this.answerAreaLabel.SingleLineColor = System.Drawing.Color.Black;
            this.answerAreaLabel.Size = new System.Drawing.Size(404, 48);
            this.answerAreaLabel.TabIndex = 1;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.answerAreaBackgroundPanel);
            this.Controls.Add(this.alwaysTopChk);
            this.Controls.Add(this.tabControl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form";
            this.Opacity = 0.99D;
            this.Text = "Qasemian Calculator";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.answerAreaBackgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabControlPanel simpleTabControlPanel;
        private DevComponents.DotNetBar.TabItem simpleTabItem;
        private DevComponents.DotNetBar.TabControlPanel advancedTabControlPanel2;
        private DevComponents.DotNetBar.TabItem advancedTabItem;
        private System.Windows.Forms.CheckBox alwaysTopChk;
        private System.Windows.Forms.Panel answerAreaBackgroundPanel;
        private DevComponents.DotNetBar.LabelX answerAreaLabel;
        private DevComponents.DotNetBar.LabelX previousAnswerLabel;
    }
}

