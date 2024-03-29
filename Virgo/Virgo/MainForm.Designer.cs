﻿namespace Virgo
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TimerDayLabel = new System.Windows.Forms.Label();
            this.TimerTimeLabel = new System.Windows.Forms.Label();
            this.CountTimer = new System.Windows.Forms.Timer(this.components);
            this.StartWorkButton = new System.Windows.Forms.Button();
            this.FinishWorkButton = new System.Windows.Forms.Button();
            this.Lasted20DataGridView = new System.Windows.Forms.DataGridView();
            this.Lasted20Label = new System.Windows.Forms.Label();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LastActionLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.RecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Lasted20DataGridView)).BeginInit();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerDayLabel
            // 
            this.TimerDayLabel.AutoSize = true;
            this.TimerDayLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimerDayLabel.Location = new System.Drawing.Point(184, 102);
            this.TimerDayLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.TimerDayLabel.Name = "TimerDayLabel";
            this.TimerDayLabel.Size = new System.Drawing.Size(395, 38);
            this.TimerDayLabel.TabIndex = 0;
            this.TimerDayLabel.Text = "yyyy年 MM月 dd日 (月)";
            // 
            // TimerTimeLabel
            // 
            this.TimerTimeLabel.AutoSize = true;
            this.TimerTimeLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimerTimeLabel.Location = new System.Drawing.Point(288, 168);
            this.TimerTimeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.TimerTimeLabel.Name = "TimerTimeLabel";
            this.TimerTimeLabel.Size = new System.Drawing.Size(178, 42);
            this.TimerTimeLabel.TabIndex = 1;
            this.TimerTimeLabel.Text = "hh:mm:ss";
            // 
            // CountTimer
            // 
            this.CountTimer.Tick += new System.EventHandler(this.CountTimer_Tick);
            // 
            // StartWorkButton
            // 
            this.StartWorkButton.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartWorkButton.Location = new System.Drawing.Point(93, 274);
            this.StartWorkButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.StartWorkButton.Name = "StartWorkButton";
            this.StartWorkButton.Size = new System.Drawing.Size(258, 104);
            this.StartWorkButton.TabIndex = 1;
            this.StartWorkButton.Text = "出勤";
            this.StartWorkButton.UseVisualStyleBackColor = true;
            this.StartWorkButton.Click += new System.EventHandler(this.StartWorkButton_Click);
            // 
            // FinishWorkButton
            // 
            this.FinishWorkButton.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FinishWorkButton.Location = new System.Drawing.Point(440, 274);
            this.FinishWorkButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.FinishWorkButton.Name = "FinishWorkButton";
            this.FinishWorkButton.Size = new System.Drawing.Size(258, 104);
            this.FinishWorkButton.TabIndex = 2;
            this.FinishWorkButton.Text = "退勤";
            this.FinishWorkButton.UseVisualStyleBackColor = true;
            this.FinishWorkButton.Click += new System.EventHandler(this.FinishWorkButton_Click);
            // 
            // Lasted20DataGridView
            // 
            this.Lasted20DataGridView.AllowUserToAddRows = false;
            this.Lasted20DataGridView.AllowUserToDeleteRows = false;
            this.Lasted20DataGridView.AllowUserToResizeColumns = false;
            this.Lasted20DataGridView.AllowUserToResizeRows = false;
            this.Lasted20DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lasted20DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordDate,
            this.ToWork,
            this.Comment});
            this.Lasted20DataGridView.Location = new System.Drawing.Point(26, 502);
            this.Lasted20DataGridView.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Lasted20DataGridView.MultiSelect = false;
            this.Lasted20DataGridView.Name = "Lasted20DataGridView";
            this.Lasted20DataGridView.ReadOnly = true;
            this.Lasted20DataGridView.RowHeadersVisible = false;
            this.Lasted20DataGridView.RowHeadersWidth = 82;
            this.Lasted20DataGridView.RowTemplate.Height = 21;
            this.Lasted20DataGridView.Size = new System.Drawing.Size(748, 248);
            this.Lasted20DataGridView.TabIndex = 3;
            // 
            // Lasted20Label
            // 
            this.Lasted20Label.AutoSize = true;
            this.Lasted20Label.Location = new System.Drawing.Point(26, 470);
            this.Lasted20Label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Lasted20Label.Name = "Lasted20Label";
            this.Lasted20Label.Size = new System.Drawing.Size(174, 24);
            this.Lasted20Label.TabIndex = 4;
            this.Lasted20Label.Text = "最近20件の登録";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.OptionToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.MainMenuStrip.Size = new System.Drawing.Size(800, 44);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExportToolStripMenuItem,
            this.toolStripSeparator1,
            this.QuitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.FileToolStripMenuItem.Text = "ファイル";
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(341, 44);
            this.SearchToolStripMenuItem.Text = "検索";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(338, 6);
            // 
            // ExportToolStripMenuItem
            // 
            this.ExportToolStripMenuItem.Enabled = false;
            this.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            this.ExportToolStripMenuItem.Size = new System.Drawing.Size(341, 44);
            this.ExportToolStripMenuItem.Text = "エクスポート(開発中)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(338, 6);
            // 
            // QuitToolStripMenuItem
            // 
            this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            this.QuitToolStripMenuItem.Size = new System.Drawing.Size(341, 44);
            this.QuitToolStripMenuItem.Text = "終了";
            this.QuitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // OptionToolStripMenuItem
            // 
            this.OptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem,
            this.toolStripSeparator3,
            this.AboutToolStripMenuItem});
            this.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem";
            this.OptionToolStripMenuItem.Size = new System.Drawing.Size(123, 36);
            this.OptionToolStripMenuItem.Text = "オプション";
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.Enabled = false;
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(283, 44);
            this.SettingToolStripMenuItem.Text = "設定(開発中)";
            this.SettingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(280, 6);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(283, 44);
            this.AboutToolStripMenuItem.Text = "About Virgo";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // LastActionLabel
            // 
            this.LastActionLabel.AutoSize = true;
            this.LastActionLabel.Location = new System.Drawing.Point(30, 776);
            this.LastActionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastActionLabel.Name = "LastActionLabel";
            this.LastActionLabel.Size = new System.Drawing.Size(513, 24);
            this.LastActionLabel.TabIndex = 5;
            this.LastActionLabel.Text = "最終更新：yyyy年 MM月 dd日(月) hh:mm:ss | 出勤";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(30, 832);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 24);
            this.MessageLabel.TabIndex = 6;
            this.MessageLabel.Click += new System.EventHandler(this.MessageLabel_Click);
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(260, 400);
            this.CommentTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CommentTextBox.MaxLength = 20;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(433, 31);
            this.CommentTextBox.TabIndex = 7;
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(89, 406);
            this.CommentLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(153, 24);
            this.CommentLabel.TabIndex = 8;
            this.CommentLabel.Text = "コメント(任意) :";
            // 
            // RecordDate
            // 
            this.RecordDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RecordDate.DataPropertyName = "RecordDate";
            this.RecordDate.HeaderText = "登録日時";
            this.RecordDate.MinimumWidth = 10;
            this.RecordDate.Name = "RecordDate";
            this.RecordDate.ReadOnly = true;
            this.RecordDate.Width = 151;
            // 
            // ToWork
            // 
            this.ToWork.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ToWork.DataPropertyName = "ToWork";
            this.ToWork.HeaderText = "出勤/退勤";
            this.ToWork.MinimumWidth = 10;
            this.ToWork.Name = "ToWork";
            this.ToWork.ReadOnly = true;
            this.ToWork.Width = 163;
            // 
            // Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "コメント";
            this.Comment.MinimumWidth = 10;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 124;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 892);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.LastActionLabel);
            this.Controls.Add(this.Lasted20Label);
            this.Controls.Add(this.Lasted20DataGridView);
            this.Controls.Add(this.FinishWorkButton);
            this.Controls.Add(this.StartWorkButton);
            this.Controls.Add(this.TimerTimeLabel);
            this.Controls.Add(this.TimerDayLabel);
            this.Controls.Add(this.MainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Virgo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lasted20DataGridView)).EndInit();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerDayLabel;
        private System.Windows.Forms.Label TimerTimeLabel;
        private System.Windows.Forms.Timer CountTimer;
        private System.Windows.Forms.Button StartWorkButton;
        private System.Windows.Forms.Button FinishWorkButton;
        private System.Windows.Forms.DataGridView Lasted20DataGridView;
        private System.Windows.Forms.Label Lasted20Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Label LastActionLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}

