namespace Virgo
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.FromToLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.RecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoundRecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label2 = new System.Windows.Forms.Label();
            this.SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.FromToLabel);
            this.SearchGroupBox.Controls.Add(this.SearchButton);
            this.SearchGroupBox.Controls.Add(this.Label1);
            this.SearchGroupBox.Controls.Add(this.ToDateTimePicker);
            this.SearchGroupBox.Controls.Add(this.FromDateTimePicker);
            this.SearchGroupBox.Location = new System.Drawing.Point(26, 24);
            this.SearchGroupBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SearchGroupBox.Size = new System.Drawing.Size(964, 200);
            this.SearchGroupBox.TabIndex = 1;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "検索";
            // 
            // FromToLabel
            // 
            this.FromToLabel.AutoSize = true;
            this.FromToLabel.Location = new System.Drawing.Point(56, 58);
            this.FromToLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.FromToLabel.Name = "FromToLabel";
            this.FromToLabel.Size = new System.Drawing.Size(106, 24);
            this.FromToLabel.TabIndex = 4;
            this.FromToLabel.Text = "記録日付";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(745, 88);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(163, 46);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "検索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(351, 98);
            this.Label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(34, 24);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "～";
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Location = new System.Drawing.Point(401, 88);
            this.ToDateTimePicker.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(273, 31);
            this.ToDateTimePicker.TabIndex = 1;
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Location = new System.Drawing.Point(61, 88);
            this.FromDateTimePicker.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(273, 31);
            this.FromDateTimePicker.TabIndex = 0;
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.AllowUserToAddRows = false;
            this.ResultDataGridView.AllowUserToDeleteRows = false;
            this.ResultDataGridView.AllowUserToResizeColumns = false;
            this.ResultDataGridView.AllowUserToResizeRows = false;
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordDate,
            this.RoundRecordDate,
            this.ToWork});
            this.ResultDataGridView.Location = new System.Drawing.Point(26, 332);
            this.ResultDataGridView.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ResultDataGridView.MultiSelect = false;
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.ReadOnly = true;
            this.ResultDataGridView.RowHeadersVisible = false;
            this.ResultDataGridView.RowHeadersWidth = 82;
            this.ResultDataGridView.RowTemplate.Height = 21;
            this.ResultDataGridView.Size = new System.Drawing.Size(964, 704);
            this.ResultDataGridView.TabIndex = 3;
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
            // RoundRecordDate
            // 
            this.RoundRecordDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RoundRecordDate.DataPropertyName = "RoundRecordDate";
            this.RoundRecordDate.HeaderText = "丸め日時";
            this.RoundRecordDate.MinimumWidth = 10;
            this.RoundRecordDate.Name = "RoundRecordDate";
            this.RoundRecordDate.ReadOnly = true;
            this.RoundRecordDate.Width = 147;
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
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(26, 296);
            this.Label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(106, 24);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "検索結果";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 1060);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.ResultDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.Text = "Virgo | 検索";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Label FromToLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.DataGridView ResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoundRecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToWork;
        private System.Windows.Forms.Label Label2;
    }
}