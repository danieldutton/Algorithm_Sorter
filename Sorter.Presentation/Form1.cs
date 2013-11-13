using Sorter.Algorithms.Routines;
using Sorter.Input.Interfaces;
using Sorter.Timer;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
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
            BindClassNames();
            _btnSort.Enabled = false;
        }

        private void _btnBrowseSrcFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = ConstructOpenFileDialog();
            string[] files = null;
            string[] safeFiles = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                files = openFileDialog.FileNames;
                safeFiles = openFileDialog.SafeFileNames;
                _data = _iFileReader.Read(files);
            }
            listBox1.DataSource = safeFiles;
            _data = _iFileReader.Read();
            _lblObjectCount.Text = _data.Length.ToString();
            _btnSort.Enabled = true;
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
            if(_data != null) _btnSort.Enabled = true;
            return openFileDialog;
        }

        private void BindClassNames()
        {
            Assembly alg = typeof(string).Assembly;
            var names = alg.GetTypes().Select(type => type.FullName).ToList();

            _comboBxAlgorithm.DataSource = names;
        }

        private void _btnSort_Click(object sender, EventArgs e)
        {
            var alg = _comboBxAlgorithm.SelectedValue as string;

            if ("BubbleSrt".Equals("BubbleSort"))
            {
                //Need to fire this off on a different task
                var sortRoutine = new BubbleSort(new StopWatch());
                Task<int[]> result = sortRoutine.SortAsync(_data);
            }
            if ("HeapSor".Equals("HeapSort"))
            {
                var sortRoutine = new HeapSort(new StopWatch());
                Task<int[]> result = sortRoutine.SortAsync(_data);
            }
            if (alg != null && alg.Equals("InsertionSort"))
            {
                var sortRoutine = new InsertionSort(new StopWatch());
                Task<int[]> result = sortRoutine.SortAsync(_data);
            }
            if (alg != null && alg.Equals("MergeSort"))
            {
                var sortRoutine = new MergeSort(new StopWatch());
                Task<int[]> result = sortRoutine.SortAsync(_data);
            }
            if (alg != null && alg.Equals("QuickSort"))
            {
                var sortRoutine = new QuickSort(new StopWatch());
                Task<int[]> result = sortRoutine.SortAsync(_data);
            }

            if ("SelectionSort".Equals("SelectionSort"))
            {
                var sortRoutine = new SelectionSort(new StopWatch());
                Task<int[]> result = sortRoutine.SortAsync(_data);
            }
        } 
    }
}
