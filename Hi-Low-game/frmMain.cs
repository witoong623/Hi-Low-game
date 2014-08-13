using System;
﻿using System.Drawing;
using System.Windows.Forms;
public class frmMain : Form
{
    private TextBox txtCurrentBalance;
    private Label label2;
    private TextBox txtBetAmount;
    private MenuStrip mnsMain;
    private ToolStripMenuItem mnMenu;
    private ToolStripMenuItem smnNewGame;
    private ToolStripSeparator toolStripMenuItem1;
    private ToolStripMenuItem smnClose;
    private Label label1;
    //============ Instance Member ===========
    private int readyToPlayStatus = 0;

    #region windows code
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBetAmount = new System.Windows.Forms.TextBox();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.smnNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.smnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(291, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "จำนวนเงินที่เหลือของคุณ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Location = new System.Drawing.Point(442, 213);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.ReadOnly = true;
            this.txtCurrentBalance.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentBalance.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(291, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "จำนวนเงินที่แทง";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.Location = new System.Drawing.Point(442, 174);
            this.txtBetAmount.Name = "txtBetAmount";
            this.txtBetAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBetAmount.TabIndex = 3;
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnMenu});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(554, 24);
            this.mnsMain.TabIndex = 4;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnMenu
            // 
            this.mnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnNewGame,
            this.toolStripMenuItem1,
            this.smnClose});
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.Size = new System.Drawing.Size(36, 20);
            this.mnMenu.Text = "เมนู";
            // 
            // smnNewGame
            // 
            this.smnNewGame.Name = "smnNewGame";
            this.smnNewGame.Size = new System.Drawing.Size(152, 22);
            this.smnNewGame.Text = "เริ่มเกมใหม่";
            this.smnNewGame.Click += new System.EventHandler(this.smnNewGame_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // smnClose
            // 
            this.smnClose.Name = "smnClose";
            this.smnClose.Size = new System.Drawing.Size(152, 22);
            this.smnClose.Text = "ออกเกม";
            this.smnClose.Click += new System.EventHandler(this.smnClose_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(554, 261);
            this.Controls.Add(this.txtBetAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurrentBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnsMain);
            this.MainMenuStrip = this.mnsMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hi-Low";
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion windows code

    public frmMain()
    {
        InitializeComponent();
        GettingProgramReady(readyToPlayStatus);
    }

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.EnableVisualStyles();
        Application.Run(main);
    }

    #region getting program ready
    /***
     * porpose : new form to start game
     * and update text property to playername and game's type
     * Parameter:
     *      N/A
     * Return
     *      void
    ***/
    private void smnNewGame_Click(object sender, EventArgs e)
    {
        frmNewGame newGame = new frmNewGame();
        newGame.ShowDialog();
        this.Text += " - ยินดีต้อนรับคุณ " + newGame.NamePlayer+" รูปแบบเกมของคุณคือ";
        readyToPlayStatus = newGame.ReadyStatus;
        GettingProgramReady(readyToPlayStatus);
        return;
    }

    /***
     * porpose : adjust form to ready to play 
     * depend on player entered name and selected game's type
     * Parameter :
     *      int flag
     * Return
     *      void
     ***/
    private void GettingProgramReady(int flag)
    {
        if (flag == 1)
        {
            txtBetAmount.ReadOnly = false;
        }
        else if (flag == 0)
        {
            txtBetAmount.ReadOnly = true;
        }
    }
    #endregion getting program ready

    private void smnClose_Click(object sender, EventArgs e)
    {

        Close();
    }
}