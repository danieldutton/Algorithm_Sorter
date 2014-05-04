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
            this._lblTimeTakenValue = new System.Windows.Forms.Label();
            this._lblItemSortCountValue = new System.Windows.Forms.Label();
            this._btnExit = new System.Windows.Forms.Button();
            this._panelBlue2 = new System.Windows.Forms.Panel();
            this._panelBlue1 = new System.Windows.Forms.Panel();
            this._panelRed2 = new System.Windows.Forms.Panel();
            this._panelRed1 = new System.Windows.Forms.Panel();
            this._panelBlue2.SuspendLayout();
            this._panelBlue1.SuspendLayout();
            this._panelRed2.SuspendLayout();
            this._panelRed1.SuspendLayout();
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
            // _lblTimeTakenValue
            // 
            this._lblTimeTakenValue.AutoSize = true;
            this._lblTimeTakenValue.ForeColor = System.Drawing.Color.White;
            this._lblTimeTakenValue.Location = new System.Drawing.Point(8, 5);
            this._lblTimeTakenValue.Name = "_lblTimeTakenValue";
            this._lblTimeTakenValue.Size = new System.Drawing.Size(13, 13);
            this._lblTimeTakenValue.TabIndex = 6;
            this._lblTimeTakenValue.Text = "0";
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
            // _btnExit
            // 
            this._btnExit.Location = new System.Drawing.Point(57, 60);
            this._btnExit.MaximumSize = new System.Drawing.Size(75, 23);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 10;
            this._btnExit.Text = "Exit";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this.CloseDialog_Click);
            // 
            // _panelBlue2
            // 
            this._panelBlue2.BackColor = System.Drawing.Color.SteelBlue;
            this._panelBlue2.Controls.Add(this._lblElapsedTime);
            this._panelBlue2.Location = new System.Drawing.Point(4, 32);
            this._panelBlue2.Name = "_panelBlue2";
            this._panelBlue2.Size = new System.Drawing.Size(86, 22);
            this._panelBlue2.TabIndex = 11;
            // 
            // _panelBlue1
            // 
            this._panelBlue1.BackColor = System.Drawing.Color.SteelBlue;
            this._panelBlue1.Controls.Add(this._lblItemSortCount);
            this._panelBlue1.Location = new System.Drawing.Point(4, 4);
            this._panelBlue1.Name = "_panelBlue1";
            this._panelBlue1.Size = new System.Drawing.Size(86, 22);
            this._panelBlue1.TabIndex = 11;
            // 
            // _panelRed2
            // 
            this._panelRed2.BackColor = System.Drawing.Color.Crimson;
            this._panelRed2.Controls.Add(this._lblTimeTakenValue);
            this._panelRed2.Location = new System.Drawing.Point(96, 32);
            this._panelRed2.Name = "_panelRed2";
            this._panelRed2.Size = new System.Drawing.Size(97, 22);
            this._panelRed2.TabIndex = 14;
            // 
            // _panelRed1
            // 
            this._panelRed1.BackColor = System.Drawing.Color.Crimson;
            this._panelRed1.Controls.Add(this._lblItemSortCountValue);
            this._panelRed1.Location = new System.Drawing.Point(96, 4);
            this._panelRed1.Name = "_panelRed1";
            this._panelRed1.Size = new System.Drawing.Size(97, 22);
            this._panelRed1.TabIndex = 15;
            // 
            // SortResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(197, 90);
            this.Controls.Add(this._panelRed1);
            this.Controls.Add(this._panelRed2);
            this.Controls.Add(this._panelBlue1);
            this.Controls.Add(this._panelBlue2);
            this.Controls.Add(this._btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(213, 124);
            this.Name = "SortResults";
            this.Text = "Results";
            this._panelBlue2.ResumeLayout(false);
            this._panelBlue2.PerformLayout();
            this._panelBlue1.ResumeLayout(false);
            this._panelBlue1.PerformLayout();
            this._panelRed2.ResumeLayout(false);
            this._panelRed2.PerformLayout();
            this._panelRed1.ResumeLayout(false);
            this._panelRed1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _lblElapsedTime;
        private System.Windows.Forms.Label _lblItemSortCount;
        private System.Windows.Forms.Label _lblTimeTakenValue;
        private System.Windows.Forms.Label _lblItemSortCountValue;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Panel _panelBlue2;
        private System.Windows.Forms.Panel _panelBlue1;
        private System.Windows.Forms.Panel _panelRed2;
        private System.Windows.Forms.Panel _panelRed1;
    }
}