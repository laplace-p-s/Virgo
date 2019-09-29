namespace Virgo
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
            this.RecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoundRecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Lasted20DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerDayLabel
            // 
            this.TimerDayLabel.AutoSize = true;
            this.TimerDayLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimerDayLabel.Location = new System.Drawing.Point(85, 24);
            this.TimerDayLabel.Name = "TimerDayLabel";
            this.TimerDayLabel.Size = new System.Drawing.Size(197, 19);
            this.TimerDayLabel.TabIndex = 0;
            this.TimerDayLabel.Text = "yyyy年 MM月 dd日 (月)";
            // 
            // TimerTimeLabel
            // 
            this.TimerTimeLabel.AutoSize = true;
            this.TimerTimeLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimerTimeLabel.Location = new System.Drawing.Point(133, 57);
            this.TimerTimeLabel.Name = "TimerTimeLabel";
            this.TimerTimeLabel.Size = new System.Drawing.Size(90, 21);
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
            this.StartWorkButton.Location = new System.Drawing.Point(43, 110);
            this.StartWorkButton.Name = "StartWorkButton";
            this.StartWorkButton.Size = new System.Drawing.Size(119, 52);
            this.StartWorkButton.TabIndex = 1;
            this.StartWorkButton.Text = "出勤";
            this.StartWorkButton.UseVisualStyleBackColor = true;
            this.StartWorkButton.Click += new System.EventHandler(this.StartWorkButton_Click);
            // 
            // FinishWorkButton
            // 
            this.FinishWorkButton.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FinishWorkButton.Location = new System.Drawing.Point(203, 110);
            this.FinishWorkButton.Name = "FinishWorkButton";
            this.FinishWorkButton.Size = new System.Drawing.Size(119, 52);
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
            this.RoundRecordDate,
            this.ToWork});
            this.Lasted20DataGridView.Location = new System.Drawing.Point(12, 209);
            this.Lasted20DataGridView.MultiSelect = false;
            this.Lasted20DataGridView.Name = "Lasted20DataGridView";
            this.Lasted20DataGridView.ReadOnly = true;
            this.Lasted20DataGridView.RowHeadersVisible = false;
            this.Lasted20DataGridView.RowTemplate.Height = 21;
            this.Lasted20DataGridView.Size = new System.Drawing.Size(345, 198);
            this.Lasted20DataGridView.TabIndex = 3;
            // 
            // Lasted20Label
            // 
            this.Lasted20Label.AutoSize = true;
            this.Lasted20Label.Location = new System.Drawing.Point(12, 191);
            this.Lasted20Label.Name = "Lasted20Label";
            this.Lasted20Label.Size = new System.Drawing.Size(87, 12);
            this.Lasted20Label.TabIndex = 4;
            this.Lasted20Label.Text = "最近20件の登録";
            // 
            // RecordDate
            // 
            this.RecordDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RecordDate.DataPropertyName = "RecordDate";
            this.RecordDate.HeaderText = "登録日時";
            this.RecordDate.Name = "RecordDate";
            this.RecordDate.ReadOnly = true;
            this.RecordDate.Width = 78;
            // 
            // RoundRecordDate
            // 
            this.RoundRecordDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RoundRecordDate.DataPropertyName = "RoundRecordDate";
            this.RoundRecordDate.HeaderText = "丸め日時";
            this.RoundRecordDate.Name = "RoundRecordDate";
            this.RoundRecordDate.ReadOnly = true;
            this.RoundRecordDate.Width = 76;
            // 
            // ToWork
            // 
            this.ToWork.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ToWork.DataPropertyName = "ToWork";
            this.ToWork.HeaderText = "出勤/退勤";
            this.ToWork.Name = "ToWork";
            this.ToWork.ReadOnly = true;
            this.ToWork.Width = 84;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 419);
            this.Controls.Add(this.Lasted20Label);
            this.Controls.Add(this.Lasted20DataGridView);
            this.Controls.Add(this.FinishWorkButton);
            this.Controls.Add(this.StartWorkButton);
            this.Controls.Add(this.TimerTimeLabel);
            this.Controls.Add(this.TimerDayLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Virgo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lasted20DataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoundRecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToWork;
    }
}

