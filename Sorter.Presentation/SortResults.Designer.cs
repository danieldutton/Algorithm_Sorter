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
            this._lblElapsedTime = new System.Windows.Forms.Label();
            this._lblItemSortCount = new System.Windows.Forms.Label();
            this._lblElapsedTimeValue = new System.Windows.Forms.Label();
            this._lblItemSortCountValue = new System.Windows.Forms.Label();
            this._btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
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
            this._btnClose.Location = new System.Drawing.Point(57, 60);
            this._btnClose.MaximumSize = new System.Drawing.Size(75, 23);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 10;
            this._btnClose.Text = "Exit";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this.CloseDialog_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this._lblElapsedTime);
            this.panel3.Location = new System.Drawing.Point(4, 32);
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Crimson;
            this.panel8.Controls.Add(this._lblElapsedTimeValue);
            this.panel8.Location = new System.Drawing.Point(96, 32);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(115, 22);
            this.panel8.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Crimson;
            this.panel9.Controls.Add(this._lblItemSortCountValue);
            this.panel9.Location = new System.Drawing.Point(96, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(115, 22);
            this.panel9.TabIndex = 15;
            // 
            // SortResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(214, 90);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this._btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(230, 124);
            this.Name = "SortResults";
            this.Text = "Results";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _lblElapsedTime;
        private System.Windows.Forms.Label _lblItemSortCount;
        private System.Windows.Forms.Label _lblElapsedTimeValue;
        private System.Windows.Forms.Label _lblItemSortCountValue;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
    }
}