using System.Threading;
using Sorter.Algorithms;
using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Routines;
using Sorter.Input.Exceptions;
using Sorter.Input.Interfaces;
using Sorter.Utilities._Stopwatch;
using Sorter.Utilities.Algorithms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter.Presentation
{
    internal partial class SortForm : Form
    {
        #region Properties

        private readonly IFileReader<int> _iFileReader;

        private readonly IClassNameLoader _classNameLoader;

        private SorterContext _sorter;

        private int[] _dataToSort;

        private CancellationTokenSource _cancellationTokenSource;

        #endregion

        #region Constructor(s)

        internal SortForm(IFileReader<int> fileReader, IClassNameLoader classNameLoader)
        {
            _iFileReader = fileReader;
            _classNameLoader = classNameLoader;
            _cancellationTokenSource = new CancellationTokenSource();
            
            InitializeComponent();
            BindAlgorithmNamesToComboBox();
            EnableSelectionStep1();
            DisableSelectionStep2();
            DisableSelectionStep3();
        }

        #endregion

        #region Method(s)

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
                _dataToSort = ReadSortData(filePaths);
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
                InitialDirectory = AppDomain.CurrentDomain.BaseDirectory,
            };

            return openFileDialog;
        }

        private void PopulateListBoxWithFileNamesToSort(IEnumerable<string> fileNames)
        {
            if (fileNames == null) return;
            
            foreach (var fileName in fileNames)
            {
                _lBoxSelectedFiles.Items.Add(fileName);
            }
        }

        private int[] ReadSortData(params string[] filePaths)
        {
            try
            {
                _dataToSort = _iFileReader.Read(filePaths);
            }
            catch (FileReadException)
            {
                MessageBox.Show("Error Reading Data Try Again");               
                ResetApplication();
            }

            return _dataToSort;
        }
        
        private async void StartSorting_Click(object sender, EventArgs e)
        {
            DisableSelectionStep2();
            DisableSelectionStep3();
            _btnCancelSort.Enabled = true;
            if (_comboBxAlgorithm.SelectedValue.Equals("BubbleSort"))
            {
                var bubbleSort = new BubbleSort(new SortStopwatch());
                bubbleSort.Completed += DisplaySortResults;
                _sorter = new SorterContext(bubbleSort);
                
                StartProgressBar();

                int[]  result = await _sorter.Sort(_dataToSort, _cancellationTokenSource.Token);
   
            }
            if (_comboBxAlgorithm.SelectedValue.Equals("HeapSort"))
            {
                var heapSort = new HeapSort(new SortStopwatch());
                heapSort.Completed += DisplaySortResults;
                _sorter = new SorterContext(heapSort);
                
                StartProgressBar();

                Task<int[]> result = _sorter.Sort(_dataToSort, _cancellationTokenSource.Token);
            }
            if (_comboBxAlgorithm.SelectedValue.Equals("InsertionSort"))
            {
                var insertionSort = new InsertionSort(new SortStopwatch());
                insertionSort.Completed += DisplaySortResults;
                
                _sorter = new SorterContext(insertionSort);
                
                StartProgressBar();

                Task<int[]> result = _sorter.Sort(_dataToSort, _cancellationTokenSource.Token);
            }
            if (_comboBxAlgorithm.SelectedValue.Equals("QuickSort"))
            {
                var quickSort = new QuickSort(new SortStopwatch());
                quickSort.Completed += DisplaySortResults;
                _sorter = new SorterContext(quickSort);
                
                StartProgressBar();

                Task<int[]> result = _sorter.Sort(_dataToSort, _cancellationTokenSource.Token);
            }
            if (_comboBxAlgorithm.SelectedValue.Equals("SelectionSort"))
            {
                var selectionSort = new SelectionSort(new SortStopwatch());
                selectionSort.Completed += DisplaySortResults;
                _sorter = new SorterContext(selectionSort);
                
                StartProgressBar();

                Task<int[]> result = _sorter.Sort(_dataToSort, _cancellationTokenSource.Token);
            }
            if (_comboBxAlgorithm.SelectedValue.Equals("ShellSort"))
            {
                var shellSort = new ShellSort(new SortStopwatch());
                shellSort.Completed += DisplaySortResults;
                _sorter = new SorterContext(shellSort);
                StartProgressBar();
                Task<int[]> result = _sorter.Sort(_dataToSort, _cancellationTokenSource.Token);
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
            //_btnReset.Enabled = false;
        }

        private void DisplaySortResults(object sender, SortCompleteEventArgs e)
        {
            _btnCancelSort.Enabled = false;
            _progressBar.Style = ProgressBarStyle.Continuous;
            
            var sortResults = new SortResults();           
            sortResults.BuildResults(e);
            sortResults.ShowDialog();
        }

        private void ResetApplication_Click(object sender, EventArgs e)
        {
            ResetApplication();
        }

        private void ResetApplication()
        {
            EnableSelectionStep1();
            DisableSelectionStep2();
            DisableSelectionStep3();

            _lBoxSelectedFiles.Items.Clear();
            _dataToSort = null;
            _comboBxAlgorithm.SelectedIndex = 0;
        }

        private void CancelCurrentSort_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
            _cancellationTokenSource.Dispose();
            _cancellationTokenSource = new CancellationTokenSource();
            
            ResetApplication();
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
