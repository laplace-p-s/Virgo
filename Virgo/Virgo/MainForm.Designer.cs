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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 225);
            this.Controls.Add(this.TimerTimeLabel);
            this.Controls.Add(this.TimerDayLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "MainForm";
            this.Text = "Virgo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerDayLabel;
        private System.Windows.Forms.Label TimerTimeLabel;
        private System.Windows.Forms.Timer CountTimer;
    }
}

