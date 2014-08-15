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
    private Button btnBet;
    private Button btnRandom;
    private Label label3;
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
            this.btnBet = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(367, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "จำนวนเงินที่เหลือของคุณ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Location = new System.Drawing.Point(518, 27);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.ReadOnly = true;
            this.txtCurrentBalance.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentBalance.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(367, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "จำนวนเงินที่แทง";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.Location = new System.Drawing.Point(518, 53);
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
            this.mnsMain.Size = new System.Drawing.Size(630, 24);
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
            this.smnNewGame.Size = new System.Drawing.Size(123, 22);
            this.smnNewGame.Text = "เริ่มเกมใหม่";
            this.smnNewGame.Click += new System.EventHandler(this.smnNewGame_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // smnClose
            // 
            this.smnClose.Name = "smnClose";
            this.smnClose.Size = new System.Drawing.Size(123, 22);
            this.smnClose.Text = "ออกเกม";
            this.smnClose.Click += new System.EventHandler(this.smnClose_Click);
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(397, 184);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 5;
            this.btnBet.Text = "แทง";
            this.btnBet.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(518, 184);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 6;
            this.btnRandom.Text = "คอมสุ่ม";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(630, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnBet);
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
        GettingProgramReady();
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
        if (newGame.ReadyStatus==1)
        {
            this.Text += " - ยินดีต้อนรับคุณ " + newGame.NamePlayer + " รูปแบบเกมของคุณคือ " + newGame.GameTypeText;
            readyToPlayStatus = newGame.ReadyStatus;
            GettingProgramReady();
        }
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
    private void GettingProgramReady()
    {
        if (readyToPlayStatus == 1)
        {
            txtBetAmount.Enabled = true;
            txtCurrentBalance.Enabled = true;
        }
        else if (readyToPlayStatus == 0)
        {
            txtBetAmount.Enabled = false;
            txtCurrentBalance.Enabled = false;
        }
    }
    #endregion getting program ready

    private void smnClose_Click(object sender, EventArgs e)
    {

        Close();
    }
}