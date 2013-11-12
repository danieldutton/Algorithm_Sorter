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
            this._lblAlgorithmChoice = new System.Windows.Forms.Label();
            this._comboBxAlgorithm = new System.Windows.Forms.ComboBox();
            this._lblFileToSort = new System.Windows.Forms.Label();
            this._btnBrowseSrcFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblAlgorithmChoice
            // 
            this._lblAlgorithmChoice.AutoSize = true;
            this._lblAlgorithmChoice.Location = new System.Drawing.Point(13, 13);
            this._lblAlgorithmChoice.Name = "_lblAlgorithmChoice";
            this._lblAlgorithmChoice.Size = new System.Drawing.Size(53, 13);
            this._lblAlgorithmChoice.TabIndex = 0;
            this._lblAlgorithmChoice.Text = "Algorithm:";
            // 
            // _comboBxAlgorithm
            // 
            this._comboBxAlgorithm.FormattingEnabled = true;
            this._comboBxAlgorithm.Location = new System.Drawing.Point(81, 13);
            this._comboBxAlgorithm.Name = "_comboBxAlgorithm";
            this._comboBxAlgorithm.Size = new System.Drawing.Size(121, 21);
            this._comboBxAlgorithm.TabIndex = 1;
            // 
            // _lblFileToSort
            // 
            this._lblFileToSort.AutoSize = true;
            this._lblFileToSort.Location = new System.Drawing.Point(13, 48);
            this._lblFileToSort.Name = "_lblFileToSort";
            this._lblFileToSort.Size = new System.Drawing.Size(63, 13);
            this._lblFileToSort.TabIndex = 2;
            this._lblFileToSort.Text = "File Source:";
            // 
            // _btnBrowseSrcFile
            // 
            this._btnBrowseSrcFile.Location = new System.Drawing.Point(81, 48);
            this._btnBrowseSrcFile.Name = "_btnBrowseSrcFile";
            this._btnBrowseSrcFile.Size = new System.Drawing.Size(75, 23);
            this._btnBrowseSrcFile.TabIndex = 3;
            this._btnBrowseSrcFile.Text = "button1";
            this._btnBrowseSrcFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this._btnBrowseSrcFile);
            this.Controls.Add(this._lblFileToSort);
            this.Controls.Add(this._comboBxAlgorithm);
            this.Controls.Add(this._lblAlgorithmChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblAlgorithmChoice;
        private System.Windows.Forms.ComboBox _comboBxAlgorithm;
        private System.Windows.Forms.Label _lblFileToSort;
        private System.Windows.Forms.Button _btnBrowseSrcFile;
    }
}

