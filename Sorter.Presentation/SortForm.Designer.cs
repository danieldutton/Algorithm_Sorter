﻿namespace Sorter.Presentation
{
    partial class SortForm
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
            this._panelStepOne = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._panelStepTwo = new System.Windows.Forms.Panel();
            this._lblInstructionsAlgo = new System.Windows.Forms.Label();
            this._panelStepThree = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this._panelButtons.SuspendLayout();
            this._panelStepOne.SuspendLayout();
            this._panelStepTwo.SuspendLayout();
            this._panelStepThree.SuspendLayout();
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
            this._btnBrowseSrcFile.Click += new System.EventHandler(this.BrowseTestFiles_Click);
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
            this.button1.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // _btnCancelSort
            // 
            this._btnCancelSort.Location = new System.Drawing.Point(99, 29);
            this._btnCancelSort.Name = "_btnCancelSort";
            this._btnCancelSort.Size = new System.Drawing.Size(61, 21);
            this._btnCancelSort.TabIndex = 6;
            this._btnCancelSort.Text = "Cancel";
            this._btnCancelSort.UseVisualStyleBackColor = true;
            this._btnCancelSort.Click += new System.EventHandler(this.CancelCurrentSort_Click);
            // 
            // _panelStepOne
            // 
            this._panelStepOne.BackColor = System.Drawing.Color.SteelBlue;
            this._panelStepOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelStepOne.Controls.Add(this.label1);
            this._panelStepOne.Controls.Add(this._btnBrowseSrcFile);
            this._panelStepOne.Controls.Add(this._lBoxSelectedFiles);
            this._panelStepOne.Location = new System.Drawing.Point(4, 4);
            this._panelStepOne.Name = "_panelStepOne";
            this._panelStepOne.Size = new System.Drawing.Size(201, 122);
            this._panelStepOne.TabIndex = 9;
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
            // _panelStepTwo
            // 
            this._panelStepTwo.BackColor = System.Drawing.Color.Crimson;
            this._panelStepTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelStepTwo.Controls.Add(this._lblInstructionsAlgo);
            this._panelStepTwo.Controls.Add(this._comboBxAlgorithm);
            this._panelStepTwo.Location = new System.Drawing.Point(211, 4);
            this._panelStepTwo.Name = "_panelStepTwo";
            this._panelStepTwo.Size = new System.Drawing.Size(168, 60);
            this._panelStepTwo.TabIndex = 8;
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
            // _panelStepThree
            // 
            this._panelStepThree.BackColor = System.Drawing.Color.Crimson;
            this._panelStepThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelStepThree.Controls.Add(this._btnCancelSort);
            this._panelStepThree.Controls.Add(this.label2);
            this._panelStepThree.Controls.Add(this._btnSort);
            this._panelStepThree.Location = new System.Drawing.Point(211, 70);
            this._panelStepThree.Name = "_panelStepThree";
            this._panelStepThree.Size = new System.Drawing.Size(168, 56);
            this._panelStepThree.TabIndex = 11;
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
            // _progressBar
            // 
            this._progressBar.Location = new System.Drawing.Point(4, 171);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(375, 12);
            this._progressBar.TabIndex = 12;
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 188);
            this.Controls.Add(this._progressBar);
            this.Controls.Add(this._panelStepThree);
            this.Controls.Add(this._panelButtons);
            this.Controls.Add(this._panelStepTwo);
            this.Controls.Add(this._panelStepOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(400, 222);
            this.MinimumSize = new System.Drawing.Size(400, 222);
            this.Name = "SortForm";
            this.Text = "Sorter+";
            this._panelButtons.ResumeLayout(false);
            this._panelStepOne.ResumeLayout(false);
            this._panelStepOne.PerformLayout();
            this._panelStepTwo.ResumeLayout(false);
            this._panelStepTwo.PerformLayout();
            this._panelStepThree.ResumeLayout(false);
            this._panelStepThree.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox _comboBxAlgorithm;
        private System.Windows.Forms.Button _btnBrowseSrcFile;
        private System.Windows.Forms.Button _btnSort;
        private System.Windows.Forms.ListBox _lBoxSelectedFiles;
        private System.Windows.Forms.Panel _panelButtons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel _panelStepOne;
        private System.Windows.Forms.Panel _panelStepTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblInstructionsAlgo;
        private System.Windows.Forms.Button _btnCancelSort;
        private System.Windows.Forms.Panel _panelStepThree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnReset;
        private System.Windows.Forms.ProgressBar _progressBar;
    }
}

