using Sorter.Algorithms;
using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Routines;
using Sorter.Input.Interfaces;
using Sorter.Utilities.Algorithms;
using Sorter.Utilities._Stopwatch;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter.Presentation
{
    internal partial class Form1 : Form
    {
        private readonly IFileReader<int> _iFileReader;

        private readonly IClassNameLoader _classNameLoader;

        private SorterContext _sorter;

        private int[] _dataToSort;


        internal Form1(IFileReader<int> fileReader, IClassNameLoader classNameLoader)
        {
            _iFileReader = fileReader;
            _classNameLoader = classNameLoader;
            
            InitializeComponent();
            BindAlgorithmNamesToComboBox();
            EnableSelectionStep1();
            DisableSelectionStep2();
            DisableSelectionStep3();
        }

        private void BindAlgorithmNamesToComboBox()
        {
            List<string> classNames = _classNameLoader.Load("Sorter.Algorithms.dll", typeof (SortRoutine));

            if (classNames.Count >= 0)
                _comboBxAlgorithm.DataSource = classNames;
        }

        private void BrowseForFilesToSort_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = BuildOpenFileDialog();
            
            string[] safeFiles = null;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                safeFiles = openFileDialog.SafeFileNames;
                string[] filePaths = openFileDialog.FileNames;
                _dataToSort = ReadDataToSort(filePaths);
            }

            if (_dataToSort == null) return;
                PopulateListBoxWithFileNamesToSort(safeFiles);
            
            DisableSelectionStep1();
            EnableSelectionStep2();
            EnableSelectionStep3();
        }

        private OpenFileDialog BuildOpenFileDialog()
        {
            var openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "dat files(*.dat)|*.dat",
                ShowReadOnly = true,
                InitialDirectory = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"TestFiles"),
            };

            return openFileDialog;
        }

        private void PopulateListBoxWithFileNamesToSort(string[] fileNames)
        {
            if (fileNames == null) return;
            
            foreach (var fileName in fileNames)
            {
                _lBoxSelectedFiles.Items.Add(fileName);
            }
        }

        private int[] ReadDataToSort(params string[] filePaths)
        {
            _dataToSort = _iFileReader.Read(filePaths);

            return _dataToSort;
        }
        
        private void StartSort_Click(object sender, EventArgs e)
        {
            DisableSelectionStep2();
            DisableSelectionStep3();

            if (_comboBxAlgorithm.SelectedValue.Equals("BubbleSort"))
            {
                var bubbleSort = new BubbleSort(new SortStopwatch());
                bubbleSort.Completed += DisplayResultsOfSort;
                _sorter = new SorterContext(bubbleSort);
                
                StartProgressBar();
                
                Task<int[]> result = _sorter.Sort(_dataToSort);
                
            }
            if (_comboBxAlgorithm.SelectedValue.Equals("HeapSort"))
            {
                var heapSort = new HeapSort(new SortStopwatch());
                heapSort.Completed += DisplayResultsOfSort;
                _sorter = new SorterContext(heapSort);
                
                StartProgressBar();
                
                Task<int[]> result = _sorter.Sort(_dataToSort);
            }
            if (_comboBxAlgorithm.SelectedValue.Equals("InsertionSort"))
            {
                var insertionSort = new InsertionSort(new SortStopwatch());
                insertionSort.Completed += DisplayResultsOfSort;
                
                _sorter = new SorterContext(insertionSort);
                
                StartProgressBar();
                
                Task<int[]> result = _sorter.Sort(_dataToSort);
            }
            if (_comboBxAlgorithm.SelectedValue.Equals("QuickSort"))
            {
                var quickSort = new QuickSort(new SortStopwatch());
                quickSort.Completed += DisplayResultsOfSort;
                _sorter = new SorterContext(quickSort);
                
                StartProgressBar();
                
                Task<int[]> result = _sorter.Sort(_dataToSort);
            }
            if (_comboBxAlgorithm.SelectedValue.Equals("SelectionSort"))
            {
                var selectionSort = new SelectionSort(new SortStopwatch());
                selectionSort.Completed += DisplayResultsOfSort;
                _sorter = new SorterContext(selectionSort);
                
                StartProgressBar();
                
                Task<int[]> result = _sorter.Sort(_dataToSort);
            }
            if (_comboBxAlgorithm.SelectedValue.Equals("ShellSort"))
            {
                var shellSort = new ShellSort(new SortStopwatch());
                shellSort.Completed += DisplayResultsOfSort;
                _sorter = new SorterContext(shellSort);
                StartProgressBar();
                Task<int[]> result = _sorter.Sort(_dataToSort);
            }
        }

        private void StartProgressBar()
        {
            _progressBar.Style = ProgressBarStyle.Marquee;
            _progressBar.MarqueeAnimationSpeed = 1;   
        }

        private void EnableSelectionStep1()
        {
            _btnBrowseSrcFile.Enabled = true;
        }

        private void DisableSelectionStep1()
        {
            _btnBrowseSrcFile.Enabled = false;
        }

        private void EnableSelectionStep2()
        {
            _comboBxAlgorithm.Enabled = true;
            _btnSort.Enabled = true;
        }

        private void DisableSelectionStep2()
        {
            _comboBxAlgorithm.Enabled = false;
            _btnCancelSort.Enabled = false;
            _btnSort.Enabled = false;
        }

        private void EnableSelectionStep3()
        {
            _btnSort.Enabled = true;
            _btnReset.Enabled = true;
        }

        private void DisableSelectionStep3()
        {
            _btnSort.Enabled = false;
            _btnReset.Enabled = false;
        }

        private void DisplayResultsOfSort(object sender, SortCompleteEventArgs e)
        {
            _btnCancelSort.Enabled = false;
            _progressBar.Style = ProgressBarStyle.Continuous;
            
            var sortResults = new SortResults();           
            sortResults.BuildResults(e);
            sortResults.ShowDialog();
        }

        private void ResetApplication_Click(object sender, EventArgs e)
        {
            EnableSelectionStep1();
            DisableSelectionStep2();
            DisableSelectionStep3();

            _lBoxSelectedFiles.Items.Clear();
            _dataToSort = null;
            _comboBxAlgorithm.SelectedIndex = 0;
        }

        private void CancelCurrentSortRoutine_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
