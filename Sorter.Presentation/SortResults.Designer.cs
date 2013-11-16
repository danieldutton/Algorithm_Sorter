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
            this._btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblStartTime
            // 
            this._lblStartTime.AutoSize = true;
            this._lblStartTime.ForeColor = System.Drawing.Color.White;
            this._lblStartTime.Location = new System.Drawing.Point(5, 5);
            this._lblStartTime.Name = "_lblStartTime";
            this._lblStartTime.Size = new System.Drawing.Size(58, 13);
            this._lblStartTime.TabIndex = 0;
            this._lblStartTime.Text = "Start Time:";
            // 
            // _lblStopTime
            // 
            this._lblStopTime.AutoSize = true;
            this._lblStopTime.ForeColor = System.Drawing.Color.White;
            this._lblStopTime.Location = new System.Drawing.Point(5, 4);
            this._lblStopTime.Name = "_lblStopTime";
            this._lblStopTime.Size = new System.Drawing.Size(58, 13);
            this._lblStopTime.TabIndex = 1;
            this._lblStopTime.Text = "Stop Time:";
            // 
            // _lblElapsedTime
            // 
            this._lblElapsedTime.AutoSize = true;
            this._lblElapsedTime.ForeColor = System.Drawing.Color.White;
            this._lblElapsedTime.Location = new System.Drawing.Point(5, 5);
            this._lblElapsedTime.Name = "_lblElapsedTime";
            this._lblElapsedTime.Size = new System.Drawing.Size(74, 13);
            this._lblElapsedTime.TabIndex = 2;
            this._lblElapsedTime.Text = "Elapsed Time:";
            // 
            // _lblItemSortCount
            // 
            this._lblItemSortCount.AutoSize = true;
            this._lblItemSortCount.ForeColor = System.Drawing.Color.White;
            this._lblItemSortCount.Location = new System.Drawing.Point(4, 4);
            this._lblItemSortCount.Name = "_lblItemSortCount";
            this._lblItemSortCount.Size = new System.Drawing.Size(69, 13);
            this._lblItemSortCount.TabIndex = 3;
            this._lblItemSortCount.Text = "Items Sorted:";
            // 
            // _lblStartTimeValue
            // 
            this._lblStartTimeValue.AutoSize = true;
            this._lblStartTimeValue.ForeColor = System.Drawing.Color.White;
            this._lblStartTimeValue.Location = new System.Drawing.Point(7, 5);
            this._lblStartTimeValue.Name = "_lblStartTimeValue";
            this._lblStartTimeValue.Size = new System.Drawing.Size(13, 13);
            this._lblStartTimeValue.TabIndex = 4;
            this._lblStartTimeValue.Text = "0";
            // 
            // _lblStopTimeValue
            // 
            this._lblStopTimeValue.AutoSize = true;
            this._lblStopTimeValue.ForeColor = System.Drawing.Color.White;
            this._lblStopTimeValue.Location = new System.Drawing.Point(8, 4);
            this._lblStopTimeValue.Name = "_lblStopTimeValue";
            this._lblStopTimeValue.Size = new System.Drawing.Size(13, 13);
            this._lblStopTimeValue.TabIndex = 5;
            this._lblStopTimeValue.Text = "0";
            // 
            // _lblElapsedTimeValue
            // 
            this._lblElapsedTimeValue.AutoSize = true;
            this._lblElapsedTimeValue.ForeColor = System.Drawing.Color.White;
            this._lblElapsedTimeValue.Location = new System.Drawing.Point(8, 5);
            this._lblElapsedTimeValue.Name = "_lblElapsedTimeValue";
            this._lblElapsedTimeValue.Size = new System.Drawing.Size(13, 13);
            this._lblElapsedTimeValue.TabIndex = 6;
            this._lblElapsedTimeValue.Text = "0";
            // 
            // _lblItemSortCountValue
            // 
            this._lblItemSortCountValue.AutoSize = true;
            this._lblItemSortCountValue.ForeColor = System.Drawing.Color.White;
            this._lblItemSortCountValue.Location = new System.Drawing.Point(8, 5);
            this._lblItemSortCountValue.Name = "_lblItemSortCountValue";
            this._lblItemSortCountValue.Size = new System.Drawing.Size(13, 13);
            this._lblItemSortCountValue.TabIndex = 7;
            this._lblItemSortCountValue.Text = "0";
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(52, 117);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 10;
            this._btnClose.Text = "Exit";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this.CloseDialog_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this._lblStartTime);
            this.panel1.Location = new System.Drawing.Point(4, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 23);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this._lblStopTime);
            this.panel2.Location = new System.Drawing.Point(4, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 22);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this._lblElapsedTime);
            this.panel3.Location = new System.Drawing.Point(4, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(86, 22);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this._lblItemSortCount);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(86, 22);
            this.panel4.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Crimson;
            this.panel6.Controls.Add(this._lblStartTimeValue);
            this.panel6.Location = new System.Drawing.Point(97, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(73, 23);
            this.panel6.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Crimson;
            this.panel7.Controls.Add(this._lblStopTimeValue);
            this.panel7.Location = new System.Drawing.Point(96, 61);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(74, 22);
            this.panel7.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Crimson;
            this.panel8.Controls.Add(this._lblElapsedTimeValue);
            this.panel8.Location = new System.Drawing.Point(96, 89);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(74, 22);
            this.panel8.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Crimson;
            this.panel9.Controls.Add(this._lblItemSortCountValue);
            this.panel9.Location = new System.Drawing.Point(96, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(74, 22);
            this.panel9.TabIndex = 15;
            // 
            // SortResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(174, 142);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(190, 176);
            this.Name = "SortResults";
            this.Text = "SortResults";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
    }
}