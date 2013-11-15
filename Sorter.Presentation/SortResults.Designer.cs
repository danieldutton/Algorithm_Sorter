namespace Sorter.Presentation
{
    partial class SortResults
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
            this._lblStartTime = new System.Windows.Forms.Label();
            this._lblStopTime = new System.Windows.Forms.Label();
            this._lblElapsedTime = new System.Windows.Forms.Label();
            this._lblItemSortCount = new System.Windows.Forms.Label();
            this._lblStartTimeValue = new System.Windows.Forms.Label();
            this._lblStopTimeValue = new System.Windows.Forms.Label();
            this._lblElapsedTimeValue = new System.Windows.Forms.Label();
            this._lblItemSortCountValue = new System.Windows.Forms.Label();
            this._lblSortType = new System.Windows.Forms.Label();
            this._lblSortTypeValue = new System.Windows.Forms.Label();
            this._btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblStartTime
            // 
            this._lblStartTime.AutoSize = true;
            this._lblStartTime.Location = new System.Drawing.Point(12, 18);
            this._lblStartTime.Name = "_lblStartTime";
            this._lblStartTime.Size = new System.Drawing.Size(58, 13);
            this._lblStartTime.TabIndex = 0;
            this._lblStartTime.Text = "Start Time:";
            // 
            // _lblStopTime
            // 
            this._lblStopTime.AutoSize = true;
            this._lblStopTime.Location = new System.Drawing.Point(12, 41);
            this._lblStopTime.Name = "_lblStopTime";
            this._lblStopTime.Size = new System.Drawing.Size(58, 13);
            this._lblStopTime.TabIndex = 1;
            this._lblStopTime.Text = "Stop Time:";
            // 
            // _lblElapsedTime
            // 
            this._lblElapsedTime.AutoSize = true;
            this._lblElapsedTime.Location = new System.Drawing.Point(12, 66);
            this._lblElapsedTime.Name = "_lblElapsedTime";
            this._lblElapsedTime.Size = new System.Drawing.Size(74, 13);
            this._lblElapsedTime.TabIndex = 2;
            this._lblElapsedTime.Text = "Elapsed Time:";
            // 
            // _lblItemSortCount
            // 
            this._lblItemSortCount.AutoSize = true;
            this._lblItemSortCount.Location = new System.Drawing.Point(12, 95);
            this._lblItemSortCount.Name = "_lblItemSortCount";
            this._lblItemSortCount.Size = new System.Drawing.Size(69, 13);
            this._lblItemSortCount.TabIndex = 3;
            this._lblItemSortCount.Text = "Items Sorted:";
            // 
            // _lblStartTimeValue
            // 
            this._lblStartTimeValue.AutoSize = true;
            this._lblStartTimeValue.Location = new System.Drawing.Point(112, 18);
            this._lblStartTimeValue.Name = "_lblStartTimeValue";
            this._lblStartTimeValue.Size = new System.Drawing.Size(13, 13);
            this._lblStartTimeValue.TabIndex = 4;
            this._lblStartTimeValue.Text = "0";
            // 
            // _lblStopTimeValue
            // 
            this._lblStopTimeValue.AutoSize = true;
            this._lblStopTimeValue.Location = new System.Drawing.Point(112, 41);
            this._lblStopTimeValue.Name = "_lblStopTimeValue";
            this._lblStopTimeValue.Size = new System.Drawing.Size(13, 13);
            this._lblStopTimeValue.TabIndex = 5;
            this._lblStopTimeValue.Text = "0";
            // 
            // _lblElapsedTimeValue
            // 
            this._lblElapsedTimeValue.AutoSize = true;
            this._lblElapsedTimeValue.Location = new System.Drawing.Point(112, 66);
            this._lblElapsedTimeValue.Name = "_lblElapsedTimeValue";
            this._lblElapsedTimeValue.Size = new System.Drawing.Size(13, 13);
            this._lblElapsedTimeValue.TabIndex = 6;
            this._lblElapsedTimeValue.Text = "0";
            // 
            // _lblItemSortCountValue
            // 
            this._lblItemSortCountValue.AutoSize = true;
            this._lblItemSortCountValue.Location = new System.Drawing.Point(112, 95);
            this._lblItemSortCountValue.Name = "_lblItemSortCountValue";
            this._lblItemSortCountValue.Size = new System.Drawing.Size(13, 13);
            this._lblItemSortCountValue.TabIndex = 7;
            this._lblItemSortCountValue.Text = "0";
            // 
            // _lblSortType
            // 
            this._lblSortType.AutoSize = true;
            this._lblSortType.Location = new System.Drawing.Point(13, 115);
            this._lblSortType.Name = "_lblSortType";
            this._lblSortType.Size = new System.Drawing.Size(56, 13);
            this._lblSortType.TabIndex = 8;
            this._lblSortType.Text = "Sort Type:";
            // 
            // _lblSortTypeValue
            // 
            this._lblSortTypeValue.AutoSize = true;
            this._lblSortTypeValue.Location = new System.Drawing.Point(115, 115);
            this._lblSortTypeValue.Name = "_lblSortTypeValue";
            this._lblSortTypeValue.Size = new System.Drawing.Size(24, 13);
            this._lblSortTypeValue.TabIndex = 9;
            this._lblSortTypeValue.Text = "test";
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(158, 115);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 10;
            this._btnClose.Text = "Close";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this.CloseDialog_Click);
            // 
            // SortResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 140);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._lblSortTypeValue);
            this.Controls.Add(this._lblSortType);
            this.Controls.Add(this._lblItemSortCountValue);
            this.Controls.Add(this._lblElapsedTimeValue);
            this.Controls.Add(this._lblStopTimeValue);
            this.Controls.Add(this._lblStartTimeValue);
            this.Controls.Add(this._lblItemSortCount);
            this.Controls.Add(this._lblElapsedTime);
            this.Controls.Add(this._lblStopTime);
            this.Controls.Add(this._lblStartTime);
            this.Name = "SortResults";
            this.Text = "SortResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblStartTime;
        private System.Windows.Forms.Label _lblStopTime;
        private System.Windows.Forms.Label _lblElapsedTime;
        private System.Windows.Forms.Label _lblItemSortCount;
        private System.Windows.Forms.Label _lblStartTimeValue;
        private System.Windows.Forms.Label _lblStopTimeValue;
        private System.Windows.Forms.Label _lblElapsedTimeValue;
        private System.Windows.Forms.Label _lblItemSortCountValue;
        private System.Windows.Forms.Label _lblSortType;
        private System.Windows.Forms.Label _lblSortTypeValue;
        private System.Windows.Forms.Button _btnClose;
    }
}