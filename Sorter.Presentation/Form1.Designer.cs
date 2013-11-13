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
            this._btnSort = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this._lblObjectsToSort = new System.Windows.Forms.Label();
            this._lblObjectCount = new System.Windows.Forms.Label();
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
            this._comboBxAlgorithm.Size = new System.Drawing.Size(176, 21);
            this._comboBxAlgorithm.TabIndex = 1;
            // 
            // _lblFileToSort
            // 
            this._lblFileToSort.AutoSize = true;
            this._lblFileToSort.Location = new System.Drawing.Point(13, 162);
            this._lblFileToSort.Name = "_lblFileToSort";
            this._lblFileToSort.Size = new System.Drawing.Size(63, 13);
            this._lblFileToSort.TabIndex = 2;
            this._lblFileToSort.Text = "File Source:";
            // 
            // _btnBrowseSrcFile
            // 
            this._btnBrowseSrcFile.Location = new System.Drawing.Point(81, 162);
            this._btnBrowseSrcFile.Name = "_btnBrowseSrcFile";
            this._btnBrowseSrcFile.Size = new System.Drawing.Size(75, 23);
            this._btnBrowseSrcFile.TabIndex = 3;
            this._btnBrowseSrcFile.Text = "button1";
            this._btnBrowseSrcFile.UseVisualStyleBackColor = true;
            this._btnBrowseSrcFile.Click += new System.EventHandler(this._btnBrowseSrcFile_Click);
            // 
            // _btnSort
            // 
            this._btnSort.Location = new System.Drawing.Point(81, 192);
            this._btnSort.Name = "_btnSort";
            this._btnSort.Size = new System.Drawing.Size(75, 23);
            this._btnSort.TabIndex = 4;
            this._btnSort.Text = "Sort";
            this._btnSort.UseVisualStyleBackColor = true;
            this._btnSort.Click += new System.EventHandler(this._btnSort_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(81, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(118, 56);
            this.listBox1.TabIndex = 5;
            // 
            // _lblObjectsToSort
            // 
            this._lblObjectsToSort.AutoSize = true;
            this._lblObjectsToSort.Location = new System.Drawing.Point(16, 122);
            this._lblObjectsToSort.Name = "_lblObjectsToSort";
            this._lblObjectsToSort.Size = new System.Drawing.Size(75, 13);
            this._lblObjectsToSort.TabIndex = 6;
            this._lblObjectsToSort.Text = "Objects to sort";
            // 
            // _lblObjectCount
            // 
            this._lblObjectCount.AutoSize = true;
            this._lblObjectCount.Location = new System.Drawing.Point(97, 122);
            this._lblObjectCount.Name = "_lblObjectCount";
            this._lblObjectCount.Size = new System.Drawing.Size(13, 13);
            this._lblObjectCount.TabIndex = 7;
            this._lblObjectCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 289);
            this.Controls.Add(this._lblObjectCount);
            this.Controls.Add(this._lblObjectsToSort);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this._btnSort);
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
        private System.Windows.Forms.Button _btnSort;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label _lblObjectsToSort;
        private System.Windows.Forms.Label _lblObjectCount;
    }
}

