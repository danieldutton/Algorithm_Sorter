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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblAlgorithmChoice
            // 
            this._lblAlgorithmChoice.AutoSize = true;
            this._lblAlgorithmChoice.Location = new System.Drawing.Point(4, 9);
            this._lblAlgorithmChoice.Name = "_lblAlgorithmChoice";
            this._lblAlgorithmChoice.Size = new System.Drawing.Size(53, 13);
            this._lblAlgorithmChoice.TabIndex = 0;
            this._lblAlgorithmChoice.Text = "Algorithm:";
            // 
            // _comboBxAlgorithm
            // 
            this._comboBxAlgorithm.FormattingEnabled = true;
            this._comboBxAlgorithm.Location = new System.Drawing.Point(61, 7);
            this._comboBxAlgorithm.Name = "_comboBxAlgorithm";
            this._comboBxAlgorithm.Size = new System.Drawing.Size(154, 21);
            this._comboBxAlgorithm.TabIndex = 1;
            // 
            // _lblFileToSort
            // 
            this._lblFileToSort.AutoSize = true;
            this._lblFileToSort.Location = new System.Drawing.Point(4, 5);
            this._lblFileToSort.Name = "_lblFileToSort";
            this._lblFileToSort.Size = new System.Drawing.Size(63, 13);
            this._lblFileToSort.TabIndex = 2;
            this._lblFileToSort.Text = "File Source:";
            // 
            // _btnBrowseSrcFile
            // 
            this._btnBrowseSrcFile.Location = new System.Drawing.Point(73, 3);
            this._btnBrowseSrcFile.Name = "_btnBrowseSrcFile";
            this._btnBrowseSrcFile.Size = new System.Drawing.Size(62, 23);
            this._btnBrowseSrcFile.TabIndex = 3;
            this._btnBrowseSrcFile.Text = "Browse";
            this._btnBrowseSrcFile.UseVisualStyleBackColor = true;
            this._btnBrowseSrcFile.Click += new System.EventHandler(this._btnBrowseSrcFile_Click);
            // 
            // _btnSort
            // 
            this._btnSort.Location = new System.Drawing.Point(144, 6);
            this._btnSort.Name = "_btnSort";
            this._btnSort.Size = new System.Drawing.Size(75, 23);
            this._btnSort.TabIndex = 4;
            this._btnSort.Text = "Start SortAsync";
            this._btnSort.UseVisualStyleBackColor = true;
            this._btnSort.Click += new System.EventHandler(this._btnSort_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 56);
            this.listBox1.TabIndex = 5;
            // 
            // _lblObjectsToSort
            // 
            this._lblObjectsToSort.AutoSize = true;
            this._lblObjectsToSort.Location = new System.Drawing.Point(141, 32);
            this._lblObjectsToSort.Name = "_lblObjectsToSort";
            this._lblObjectsToSort.Size = new System.Drawing.Size(75, 13);
            this._lblObjectsToSort.TabIndex = 6;
            this._lblObjectsToSort.Text = "Objects to sort";
            // 
            // _lblObjectCount
            // 
            this._lblObjectCount.AutoSize = true;
            this._lblObjectCount.Location = new System.Drawing.Point(170, 60);
            this._lblObjectCount.Name = "_lblObjectCount";
            this._lblObjectCount.Size = new System.Drawing.Size(13, 13);
            this._lblObjectCount.TabIndex = 7;
            this._lblObjectCount.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(246, 220);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(238, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(281, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this._lblAlgorithmChoice);
            this.panel1.Controls.Add(this._comboBxAlgorithm);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 35);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this._lblFileToSort);
            this.panel2.Controls.Add(this._btnBrowseSrcFile);
            this.panel2.Controls.Add(this._lblObjectCount);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this._lblObjectsToSort);
            this.panel2.Location = new System.Drawing.Point(6, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 99);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this._btnSort);
            this.panel3.Location = new System.Drawing.Point(6, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 35);
            this.panel3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 237);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

