﻿#define SQLCONNECTION
#undef SQLCONNECTION
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
    private Label lblClue;
    private Label lblTellRange;
    private TextBox txtBetNumber;
    private Label lblTimeRemain;
    private ToolStripMenuItem mnHelp;
    private ToolStripMenuItem smnAboutProgram;
    //============ Instance Member ===========
    private int GameType;
    private int MaxBalance = 0;
    private string GameTypeText;
    private string PlayerName;
    private clsWallet myWallet;
    private ToolStripMenuItem smnRanking;
    private DBConnector MySql = new DBConnector();

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
            this.mnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.smnRanking = new System.Windows.Forms.ToolStripMenuItem();
            this.smnAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBet = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblClue = new System.Windows.Forms.Label();
            this.lblTellRange = new System.Windows.Forms.Label();
            this.txtBetNumber = new System.Windows.Forms.TextBox();
            this.lblTimeRemain = new System.Windows.Forms.Label();
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
            this.txtCurrentBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtBetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBetAmount.Click += new System.EventHandler(this.txtBetAmount_Click);
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnMenu,
            this.mnHelp});
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
            // mnHelp
            // 
            this.mnHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnRanking,
            this.smnAboutProgram});
            this.mnHelp.Name = "mnHelp";
            this.mnHelp.Size = new System.Drawing.Size(59, 20);
            this.mnHelp.Text = "ช่วยเหลือ";
            // 
            // smnRanking
            // 
            this.smnRanking.Name = "smnRanking";
            this.smnRanking.Size = new System.Drawing.Size(152, 22);
            this.smnRanking.Text = "อันดับคะแนน";
            this.smnRanking.Click += new System.EventHandler(this.smnRanking_Click);
            // 
            // smnAboutProgram
            // 
            this.smnAboutProgram.Name = "smnAboutProgram";
            this.smnAboutProgram.Size = new System.Drawing.Size(152, 22);
            this.smnAboutProgram.Text = "เกี่ยวกับโปรแกรม";
            this.smnAboutProgram.Click += new System.EventHandler(this.smnAboutProgram_Click);
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(397, 184);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 5;
            this.btnBet.Text = "แทง";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(518, 184);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 6;
            this.btnRandom.Text = "คอมสุ่ม";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lblClue
            // 
            this.lblClue.AutoSize = true;
            this.lblClue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClue.Location = new System.Drawing.Point(110, 96);
            this.lblClue.Name = "lblClue";
            this.lblClue.Size = new System.Drawing.Size(0, 24);
            this.lblClue.TabIndex = 7;
            this.lblClue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTellRange
            // 
            this.lblTellRange.AutoSize = true;
            this.lblTellRange.Location = new System.Drawing.Point(429, 104);
            this.lblTellRange.Name = "lblTellRange";
            this.lblTellRange.Size = new System.Drawing.Size(129, 13);
            this.lblTellRange.TabIndex = 8;
            this.lblTellRange.Text = "ใส่จำนวนที่ต้องการระหว่าง";
            // 
            // txtBetNumber
            // 
            this.txtBetNumber.Location = new System.Drawing.Point(452, 132);
            this.txtBetNumber.Name = "txtBetNumber";
            this.txtBetNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBetNumber.TabIndex = 9;
            this.txtBetNumber.Click += new System.EventHandler(this.txtBetNumber_Click);
            // 
            // lblTimeRemain
            // 
            this.lblTimeRemain.AutoSize = true;
            this.lblTimeRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemain.Location = new System.Drawing.Point(20, 48);
            this.lblTimeRemain.Name = "lblTimeRemain";
            this.lblTimeRemain.Size = new System.Drawing.Size(0, 18);
            this.lblTimeRemain.TabIndex = 10;
            this.lblTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(630, 261);
            this.Controls.Add(this.lblTimeRemain);
            this.Controls.Add(this.txtBetNumber);
            this.Controls.Add(this.lblTellRange);
            this.Controls.Add(this.lblClue);
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
        DisableForm();
        lblClue.Text = "กรุณากดเริ่มเกมใหม่ที่ \"เมนู\" เพื่อเริ่มเกม";
    }

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.EnableVisualStyles();
        Application.Run(main);
    }

    #region helper method
    
    /// <summary>
    /// Sub menu strip button to show new game window
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void smnNewGame_Click(object sender, EventArgs e)
    {
        frmNewGame newGame = new frmNewGame();
        newGame.ShowDialog();
        if (newGame.ReadyStatus == 1)
        {
            GameTypeText = newGame.GameTypeText;
            PlayerName = newGame.NamePlayer;
            this.Text += " - ยินดีต้อนรับคุณ " + PlayerName + " รูปแบบเกมของคุณคือ " + GameTypeText;
            lblTellRange.Text = "ใส่จำนวนที่ต้องการระหว่าง " + GameTypeText.Substring(0, 4);
            GettingProgramReady(newGame.ReadyStatus);
            GameType = newGame.GameType;
            myWallet = new clsWallet(GameType);
            UpdateForm();
            lblClue.Text = "กรุณาใส่จำนวนเงินและกดสุ่ม";
            btnRandom.Enabled = true;
        }
        return;
    }

    /// <summary>
    /// To disable form when need to new game
    /// </summary>
    private void DisableForm()
    {
        btnBet.Enabled = false;
        btnRandom.Enabled = false;
        txtBetNumber.Enabled = false;
        txtBetAmount.Enabled = false;
        lblTellRange.Enabled = false;
        lblTimeRemain.Enabled = false;
        lblClue.Text = "";
        lblTellRange.Text = "ใส่จำนวนที่ต้องการระหว่าง";
        lblTimeRemain.Text = "";
    }

    /// <summary>
    /// To update current balance and bet amount
    /// </summary>
    private void UpdateForm()
    {
        txtCurrentBalance.Text = myWallet.CurrentBalance.ToString("C");
        txtBetAmount.Text = myWallet.CurrentBet.ToString();
    }
    
    /// <summary>
    /// To set program to ready to enter bet amount
    /// </summary>
    /// <param name="status">
    /// 1 is program ready 0 is not ready
    /// </param>
    private void GettingProgramReady(int status)
    {
        if (status == 1)
        {
            txtBetAmount.Enabled = true;
            txtCurrentBalance.Enabled = true;
        }
        else
        {
            txtBetAmount.Enabled = false;
            txtCurrentBalance.Enabled = false;
        }
    }

    /// <summary>
    /// To set program to ready to bet
    /// </summary>
    private void ReadyToBet()   //set form to ready to click bet
    {
        btnBet.Enabled = true;
        txtBetNumber.Enabled = true;
        txtBetAmount.Enabled = false;
        btnRandom.Enabled = false;
    }

    /// <summary>
    /// To set program to not ready to bet need to click random to continue game
    /// </summary>
    private void NotReadyToBet()    //set form to not ready to click bet
    {
        btnRandom.Enabled = true;
        btnBet.Enabled = false;
        txtBetAmount.Enabled = true;
        txtBetNumber.Enabled = false;
    }

    private void txtBetAmount_Click(object sender, EventArgs e)
    {
        txtBetAmount.SelectAll();
    }

    private void txtBetNumber_Click(object sender, EventArgs e)
    {
        txtBetNumber.SelectAll();
    }

    private void smnAboutProgram_Click(object sender, EventArgs e)
    {
        frmAbout about = new frmAbout();
        about.ShowDialog();
        return;
    }

    private void smnRanking_Click(object sender, EventArgs e)
    {
        frmRanking ranking = new frmRanking();
        ranking.ShowDialog();
    }

    #endregion helper method

    #region general method

    /// <summary>
    /// Click to ordering computer to random number and set bet amount to bet
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnRandom_Click(object sender, EventArgs e)
    {
        bool flag;
        int money;

        flag = int.TryParse(txtBetAmount.Text, out money);
        if (flag == false)
        {
            MessageBox.Show("กรุณาป้อนตัวเลขเท่านั้น","ป้อนค่าไม่ถูกต้อง");
            txtBetAmount.SelectAll();
            return;
        }

        if(money < 0 || money > myWallet.CurrentBalance)
        {
            MessageBox.Show("กรุณาใส่จำนวนเงินมากกว่า 0 \n" +
            "แต่น้อยกว่าจำนวนเงินที่คุณมี(จำนวนเงินที่คุณมีคือ " + 
            myWallet.CurrentBalance.ToString("C") + ")", "จำนวนเงินไม่ถูกต้อง");
            txtBetAmount.SelectAll();
            return;
        }

        myWallet.CurrentBet = money;
        myWallet.ComputerRandom();
        ReadyToBet();
        UpdateForm();
        lblClue.Text = "";
        lblTimeRemain.Text = "คุณแทงได้อีก " + myWallet.NumberOfTime.ToString() + " ครั้ง";
    }

    /// <summary>
    /// Click to compare value between player and computer
    /// and show clue message or answer from computer
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnBet_Click(object sender, EventArgs e)
    {
        bool flag;
        int number;
        string clue = "";

        flag = int.TryParse(txtBetNumber.Text, out number);
        if (flag == false)  //case input aren't digit
        {
            MessageBox.Show("กรุณาใส่แต่ตัวเลขเท่านั้น", "ป้อนตัวเลขไม่ถูกต้อง");
            txtBetNumber.Clear();
            txtBetNumber.Select();
            return;
        }

        if (GameType == 1 && (number < 1 || number > 10))   //case out of range
        {
            MessageBox.Show("กรุณาป้อนเลขตั้งแต่ " + GameTypeText.Substring(0, 4),"ค่าที่รับมาไม่อยู่ในช่วง");
            txtBetNumber.Clear();
            txtBetNumber.Select();
            return;
        }
        else if (GameType == 2 && (number < 1 || number > 20))
        {
            MessageBox.Show("กรุณาป้อนเลขตั้งแต่ " + GameTypeText.Substring(0, 4),"ค่าที่รับมาไม่อยู่ในช่วง");
            txtBetNumber.Clear();
            txtBetNumber.Select();
            return;
        }
        else if (GameType == 3 && (number < 1 || number > 30))
        {
            MessageBox.Show("กรุณาป้อนเลขตั้งแต่ " + GameTypeText.Substring(0, 4),"ค่าที่รับมาไม่อยู่ในช่วง");
            txtBetNumber.Clear();
            txtBetNumber.Select();
            return;
        }

        flag = myWallet.CompareToComputer(number, out clue);
        lblClue.Text = clue;
        lblTimeRemain.Text = "คุณแทงได้อีก " + myWallet.NumberOfTime.ToString() + " ครั้ง";
        if (flag == true && !(myWallet.NumberOfTime < 0))
        {
            NotReadyToBet();
            UpdateForm();
            txtBetNumber.Clear();
            myWallet.SetWallet(GameType);
            lblClue.Text = "คุณชนะ";
            if (myWallet.CurrentBalance > MaxBalance)
            {
                MaxBalance = myWallet.CurrentBalance;
            }
            return;
        }
        else if (flag == false && myWallet.NumberOfTime == 0)
        {
            NotReadyToBet();
            UpdateForm();
            txtBetNumber.Clear();
            myWallet.ResetTime(GameType);
            lblClue.Text = "คุณแพ้ เลขของคอมพิวเตอร์คือ " + myWallet.CurrentComputerNumber;
            if (myWallet.CurrentBalance == 0)
            {
                MessageBox.Show("เงินคุณหมดแล้ว!\nตัวเลขของคอมพิวเตอร์คือ " + myWallet.CurrentComputerNumber, "เกมจบ");
                MySql.Insert(PlayerName, MaxBalance);
                MaxBalance = 0;
                lblClue.Text = "ตัวเลขคอมพิวเตอร์คือ " + myWallet.CurrentComputerNumber + "\nกรุณาเริ่มเกมใหม่";
                DisableForm();
            }
            return;
        }
    }

    private void smnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
    #endregion general method
}