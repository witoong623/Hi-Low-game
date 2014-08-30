using System;
﻿using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

public class frmRanking : Form
{
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ListView lstRanking;
    private DBConnector MySql = new DBConnector();
    #region windows code
    private void InitializeComponent()
    {
            this.lstRanking = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstRanking
            // 
            this.lstRanking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstRanking.FullRowSelect = true;
            this.lstRanking.GridLines = true;
            this.lstRanking.Location = new System.Drawing.Point(12, 12);
            this.lstRanking.Name = "lstRanking";
            this.lstRanking.Size = new System.Drawing.Size(260, 237);
            this.lstRanking.TabIndex = 0;
            this.lstRanking.UseCompatibleStateImageBehavior = false;
            this.lstRanking.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "อันดับ";
            this.columnHeader1.Width = 51;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ชื่อผู้เล่น";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "คะแนน";
            this.columnHeader3.Width = 73;
            // 
            // frmRanking
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstRanking);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRanking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "อันดับผู้เล่น";
            this.ResumeLayout(false);

    }
    #endregion windows code
    public frmRanking()
    {
        InitializeComponent();
        UpdateRanking();
    }

    /// <summary>
    /// To update ranking by load player stastics from DB
    /// </summary>
    private void UpdateRanking()
    {
        int i;
        List<string>[] ranking = new List<string>[2];
        ListViewItem sub;
        ranking = MySql.Select();
        for (i = 0; i < ranking[1].Count; i++) //pre = array,pos = list deepth
        {
            sub = new ListViewItem(string.Format("{0}",i + 1));
            sub.SubItems.Add(ranking[0][i]);
            sub.SubItems.Add(ranking[1][i]);
            lstRanking.Items.Add(sub);
        }
    }
}