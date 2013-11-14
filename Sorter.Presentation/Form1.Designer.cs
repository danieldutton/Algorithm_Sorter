namespace Sorter.Presentation
{
    partial class Form1
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
            this._comboBxAlgorithm = new System.Windows.Forms.ComboBox();
            this._btnBrowseSrcFile = new System.Windows.Forms.Button();
            this._btnSort = new System.Windows.Forms.Button();
            this._lBoxSelectedFiles = new System.Windows.Forms.ListBox();
            this._lblObjectsToSort = new System.Windows.Forms.Label();
            this._lblObjectCount = new System.Windows.Forms.Label();
            this._panelButtons = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this._panelBrowseData = new System.Windows.Forms.Panel();
            this._panelAlgorithm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._lblInstructionsAlgo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this._panelButtons.SuspendLayout();
            this._panelBrowseData.SuspendLayout();
            this._panelAlgorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // _comboBxAlgorithm
            // 
            this._comboBxAlgorithm.FormattingEnabled = true;
            this._comboBxAlgorithm.Location = new System.Drawing.Point(6, 22);
            this._comboBxAlgorithm.Name = "_comboBxAlgorithm";
            this._comboBxAlgorithm.Size = new System.Drawing.Size(150, 21);
            this._comboBxAlgorithm.TabIndex = 1;
            // 
            // _btnBrowseSrcFile
            // 
            this._btnBrowseSrcFile.Location = new System.Drawing.Point(7, 82);
            this._btnBrowseSrcFile.Name = "_btnBrowseSrcFile";
            this._btnBrowseSrcFile.Size = new System.Drawing.Size(62, 23);
            this._btnBrowseSrcFile.TabIndex = 3;
            this._btnBrowseSrcFile.Text = "Browse";
            this._btnBrowseSrcFile.UseVisualStyleBackColor = true;
            this._btnBrowseSrcFile.Click += new System.EventHandler(this._btnBrowseSrcFile_Click);
            // 
            // _btnSort
            // 
            this._btnSort.Location = new System.Drawing.Point(6, 55);
            this._btnSort.Name = "_btnSort";
            this._btnSort.Size = new System.Drawing.Size(75, 23);
            this._btnSort.TabIndex = 4;
            this._btnSort.Text = "Sort";
            this._btnSort.UseVisualStyleBackColor = true;
            this._btnSort.Click += new System.EventHandler(this.StartSort_Click);
            // 
            // _lBoxSelectedFiles
            // 
            this._lBoxSelectedFiles.FormattingEnabled = true;
            this._lBoxSelectedFiles.Location = new System.Drawing.Point(7, 22);
            this._lBoxSelectedFiles.Name = "_lBoxSelectedFiles";
            this._lBoxSelectedFiles.Size = new System.Drawing.Size(185, 56);
            this._lBoxSelectedFiles.TabIndex = 5;
            // 
            // _lblObjectsToSort
            // 
            this._lblObjectsToSort.AutoSize = true;
            this._lblObjectsToSort.ForeColor = System.Drawing.Color.White;
            this._lblObjectsToSort.Location = new System.Drawing.Point(75, 87);
            this._lblObjectsToSort.Name = "_lblObjectsToSort";
            this._lblObjectsToSort.Size = new System.Drawing.Size(66, 13);
            this._lblObjectsToSort.TabIndex = 6;
            this._lblObjectsToSort.Text = "items to sort:";
            // 
            // _lblObjectCount
            // 
            this._lblObjectCount.AutoSize = true;
            this._lblObjectCount.ForeColor = System.Drawing.Color.White;
            this._lblObjectCount.Location = new System.Drawing.Point(138, 87);
            this._lblObjectCount.Name = "_lblObjectCount";
            this._lblObjectCount.Size = new System.Drawing.Size(13, 13);
            this._lblObjectCount.TabIndex = 7;
            this._lblObjectCount.Text = "0";
            // 
            // _panelButtons
            // 
            this._panelButtons.BackColor = System.Drawing.Color.Gray;
            this._panelButtons.Controls.Add(this.button1);
            this._panelButtons.Location = new System.Drawing.Point(5, 121);
            this._panelButtons.Name = "_panelButtons";
            this._panelButtons.Size = new System.Drawing.Size(374, 32);
            this._panelButtons.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _panelBrowseData
            // 
            this._panelBrowseData.BackColor = System.Drawing.Color.SteelBlue;
            this._panelBrowseData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelBrowseData.Controls.Add(this.label1);
            this._panelBrowseData.Controls.Add(this._btnBrowseSrcFile);
            this._panelBrowseData.Controls.Add(this._lblObjectCount);
            this._panelBrowseData.Controls.Add(this._lBoxSelectedFiles);
            this._panelBrowseData.Controls.Add(this._lblObjectsToSort);
            this._panelBrowseData.Location = new System.Drawing.Point(4, 4);
            this._panelBrowseData.Name = "_panelBrowseData";
            this._panelBrowseData.Size = new System.Drawing.Size(201, 113);
            this._panelBrowseData.TabIndex = 9;
            // 
            // _panelAlgorithm
            // 
            this._panelAlgorithm.BackColor = System.Drawing.Color.Crimson;
            this._panelAlgorithm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelAlgorithm.Controls.Add(this.button2);
            this._panelAlgorithm.Controls.Add(this._lblInstructionsAlgo);
            this._panelAlgorithm.Controls.Add(this._comboBxAlgorithm);
            this._panelAlgorithm.Controls.Add(this._btnSort);
            this._panelAlgorithm.Location = new System.Drawing.Point(211, 4);
            this._panelAlgorithm.Name = "_panelAlgorithm";
            this._panelAlgorithm.Size = new System.Drawing.Size(168, 113);
            this._panelAlgorithm.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "1.  Select Data (.dat) to sort";
            // 
            // _lblInstructionsAlgo
            // 
            this._lblInstructionsAlgo.AutoSize = true;
            this._lblInstructionsAlgo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblInstructionsAlgo.ForeColor = System.Drawing.Color.White;
            this._lblInstructionsAlgo.Location = new System.Drawing.Point(3, 4);
            this._lblInstructionsAlgo.Name = "_lblInstructionsAlgo";
            this._lblInstructionsAlgo.Size = new System.Drawing.Size(153, 15);
            this._lblInstructionsAlgo.TabIndex = 7;
            this._lblInstructionsAlgo.Text = "2.  Select Sorting Algorithm";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 157);
            this.Controls.Add(this._panelButtons);
            this.Controls.Add(this._panelAlgorithm);
            this.Controls.Add(this._panelBrowseData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Sorter+";
            this._panelButtons.ResumeLayout(false);
            this._panelBrowseData.ResumeLayout(false);
            this._panelBrowseData.PerformLayout();
            this._panelAlgorithm.ResumeLayout(false);
            this._panelAlgorithm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox _comboBxAlgorithm;
        private System.Windows.Forms.Button _btnBrowseSrcFile;
        private System.Windows.Forms.Button _btnSort;
        private System.Windows.Forms.ListBox _lBoxSelectedFiles;
        private System.Windows.Forms.Label _lblObjectsToSort;
        private System.Windows.Forms.Label _lblObjectCount;
        private System.Windows.Forms.Panel _panelButtons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel _panelBrowseData;
        private System.Windows.Forms.Panel _panelAlgorithm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblInstructionsAlgo;
        private System.Windows.Forms.Button button2;
    }
}

