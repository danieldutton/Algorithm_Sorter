using Sorter.Input.Interfaces;
using System;
using System.Windows.Forms;

namespace Sorter.Presentation
{
    public partial class Form1 : Form
    {
        private readonly IFileReader<int> _iFileReader;

        private int[] _data;

        public Form1(IFileReader<int> fileReader)
        {
            _iFileReader = fileReader;
            InitializeComponent();
        }

        private void _btnBrowseSrcFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = ConstructOpenFileDialog();
            openFileDialog.ShowDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] files = openFileDialog.FileNames;
                _data = _iFileReader.Read(files);
            }

            _data = _iFileReader.Read();
        }

        private OpenFileDialog ConstructOpenFileDialog()
        {
            var openFileDialog = new OpenFileDialog
                {
                    Multiselect = true,
                    Filter = "dat files(*.dat)|*.dat",
                    ShowReadOnly = true,
                    InitialDirectory = @"C:\My Documents",
                };

            return openFileDialog;
        }
    }
}
