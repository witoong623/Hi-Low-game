﻿using System;
﻿using System.Drawing;
using System.Windows.Forms;
public class frmNewGame : Form
{
    private ComboBox cbType;
    private TextBox txtPlayerName;
    private Label label1;
    private Label label2;
    private Button btnStartGame;
    private Label label3;
    private Button btnCancel;
    //=========== Instance Member ==========
    private int readyStatus = 0;
    private string namePlayer;

    #region windows code
    private void InitializeComponent()
    {
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "1-10 แทง 2",
            "1-20 แทง 3",
            "1-30 แทง 4",
            "1-40 แทง 5",
            "1-50 แทง 6"});
            this.cbType.Location = new System.Drawing.Point(127, 116);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(145, 21);
            this.cbType.TabIndex = 0;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(127, 90);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ชื่อ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "รูปแบบเกม";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(37, 192);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "เริ่มเกม";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(175, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "กรุณาป้อนชื่อของคุณและเลือกครั้งของการเล่นเกม";
            // 
            // frmNewGame
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.cbType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion windows code

    public frmNewGame()
    {
        InitializeComponent();
        cbType.SelectedIndex = 0;
        txtPlayerName.Select();
    }
    #region get set method
    public int ReadyStatus
    {
        get
        {
            return readyStatus;
        }
    }

    public string NamePlayer
    {
        get
        {
            return namePlayer;
        }
    }
    #endregion get set method

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnStartGame_Click(object sender, EventArgs e)
    {
        namePlayer = txtPlayerName.Text;
        readyStatus = 1;
        Close();
    }
}