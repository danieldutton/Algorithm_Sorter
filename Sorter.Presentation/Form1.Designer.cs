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
            this._panelButtons = new System.Windows.Forms.Panel();
            this._btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this._btnCancelSort = new System.Windows.Forms.Button();
            this._panelBrowseData = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._panelAlgorithm = new System.Windows.Forms.Panel();
            this._lblInstructionsAlgo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this._panelButtons.SuspendLayout();
            this._panelBrowseData.SuspendLayout();
            this._panelAlgorithm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _comboBxAlgorithm
            // 
            this._comboBxAlgorithm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comboBxAlgorithm.FormattingEnabled = true;
            this._comboBxAlgorithm.Location = new System.Drawing.Point(16, 24);
            this._comboBxAlgorithm.Name = "_comboBxAlgorithm";
            this._comboBxAlgorithm.Size = new System.Drawing.Size(130, 21);
            this._comboBxAlgorithm.TabIndex = 1;
            // 
            // _btnBrowseSrcFile
            // 
            this._btnBrowseSrcFile.Location = new System.Drawing.Point(7, 95);
            this._btnBrowseSrcFile.Name = "_btnBrowseSrcFile";
            this._btnBrowseSrcFile.Size = new System.Drawing.Size(62, 23);
            this._btnBrowseSrcFile.TabIndex = 3;
            this._btnBrowseSrcFile.Text = "Browse";
            this._btnBrowseSrcFile.UseVisualStyleBackColor = true;
            this._btnBrowseSrcFile.Click += new System.EventHandler(this.BrowseForFilesToSort_Click);
            // 
            // _btnSort
            // 
            this._btnSort.Location = new System.Drawing.Point(7, 29);
            this._btnSort.Name = "_btnSort";
            this._btnSort.Size = new System.Drawing.Size(62, 21);
            this._btnSort.TabIndex = 4;
            this._btnSort.Text = "Sort";
            this._btnSort.UseVisualStyleBackColor = true;
            this._btnSort.Click += new System.EventHandler(this.StartSort_Click);
            // 
            // _lBoxSelectedFiles
            // 
            this._lBoxSelectedFiles.FormattingEnabled = true;
            this._lBoxSelectedFiles.Location = new System.Drawing.Point(7, 24);
            this._lBoxSelectedFiles.Name = "_lBoxSelectedFiles";
            this._lBoxSelectedFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this._lBoxSelectedFiles.Size = new System.Drawing.Size(185, 69);
            this._lBoxSelectedFiles.TabIndex = 5;
            // 
            // _panelButtons
            // 
            this._panelButtons.BackColor = System.Drawing.Color.Gray;
            this._panelButtons.Controls.Add(this._btnReset);
            this._panelButtons.Controls.Add(this.button1);
            this._panelButtons.Location = new System.Drawing.Point(4, 132);
            this._panelButtons.Name = "_panelButtons";
            this._panelButtons.Size = new System.Drawing.Size(375, 33);
            this._panelButtons.TabIndex = 10;
            // 
            // _btnReset
            // 
            this._btnReset.Location = new System.Drawing.Point(8, 5);
            this._btnReset.Name = "_btnReset";
            this._btnReset.Size = new System.Drawing.Size(62, 23);
            this._btnReset.TabIndex = 6;
            this._btnReset.Text = "Reset";
            this._btnReset.UseVisualStyleBackColor = true;
            this._btnReset.Click += new System.EventHandler(this.ResetApplication_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _btnCancelSort
            // 
            this._btnCancelSort.Location = new System.Drawing.Point(99, 29);
            this._btnCancelSort.Name = "_btnCancelSort";
            this._btnCancelSort.Size = new System.Drawing.Size(61, 21);
            this._btnCancelSort.TabIndex = 6;
            this._btnCancelSort.Text = "Cancel";
            this._btnCancelSort.UseVisualStyleBackColor = true;
            this._btnCancelSort.Click += new System.EventHandler(this.CancelCurrentSortRoutine_Click);
            // 
            // _panelBrowseData
            // 
            this._panelBrowseData.BackColor = System.Drawing.Color.SteelBlue;
            this._panelBrowseData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelBrowseData.Controls.Add(this.label1);
            this._panelBrowseData.Controls.Add(this._btnBrowseSrcFile);
            this._panelBrowseData.Controls.Add(this._lBoxSelectedFiles);
            this._panelBrowseData.Location = new System.Drawing.Point(4, 4);
            this._panelBrowseData.Name = "_panelBrowseData";
            this._panelBrowseData.Size = new System.Drawing.Size(201, 122);
            this._panelBrowseData.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "1.  Select data (.dat) to sort";
            // 
            // _panelAlgorithm
            // 
            this._panelAlgorithm.BackColor = System.Drawing.Color.Crimson;
            this._panelAlgorithm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelAlgorithm.Controls.Add(this._lblInstructionsAlgo);
            this._panelAlgorithm.Controls.Add(this._comboBxAlgorithm);
            this._panelAlgorithm.Location = new System.Drawing.Point(211, 4);
            this._panelAlgorithm.Name = "_panelAlgorithm";
            this._panelAlgorithm.Size = new System.Drawing.Size(168, 60);
            this._panelAlgorithm.TabIndex = 8;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this._btnCancelSort);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this._btnSort);
            this.panel1.Location = new System.Drawing.Point(211, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 56);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "3.  Click To Sort";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 171);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(375, 12);
            this.progressBar1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 188);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._panelButtons);
            this.Controls.Add(this._panelAlgorithm);
            this.Controls.Add(this._panelBrowseData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(400, 222);
            this.Name = "Form1";
            this.Text = "Sorter+";
            this._panelButtons.ResumeLayout(false);
            this._panelBrowseData.ResumeLayout(false);
            this._panelBrowseData.PerformLayout();
            this._panelAlgorithm.ResumeLayout(false);
            this._panelAlgorithm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox _comboBxAlgorithm;
        private System.Windows.Forms.Button _btnBrowseSrcFile;
        private System.Windows.Forms.Button _btnSort;
        private System.Windows.Forms.ListBox _lBoxSelectedFiles;
        private System.Windows.Forms.Panel _panelButtons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel _panelBrowseData;
        private System.Windows.Forms.Panel _panelAlgorithm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblInstructionsAlgo;
        private System.Windows.Forms.Button _btnCancelSort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnReset;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

