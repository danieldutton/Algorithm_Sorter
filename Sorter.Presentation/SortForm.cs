using Sorter.Algorithms;
using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Routines;
using Sorter.Input.Exceptions;
using Sorter.Input.Interfaces;
using Sorter.Utilities._Stopwatch;
using Sorter.Utilities.Algorithms;
using Sorter.Utilities.Async;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter.Presentation
{
    internal partial class SortForm : Form
    {
        private readonly IFileReader<int> _iFileReader;

        private readonly IRoutineNameLoader _routineNameLoader;

        private SorterContext _sorter;

        private int[] _dataToSort;

        private CancellationTokenSource _cancelTokenSrc;

        private ICancellationTokenSource _cancelTokenSrcWrapper;

        
        internal SortForm(IFileReader<int> fileReader, IRoutineNameLoader routineNameLoader)
        {
            _iFileReader = fileReader;
            _routineNameLoader = routineNameLoader;
            _cancelTokenSrc = new CancellationTokenSource();
            _cancelTokenSrcWrapper = new CancellationTokenSourceWrapper(_cancelTokenSrc);
            
            InitializeComponent();
            _btnCancelSort.Enabled = false;
            BindAlgorithmNames();
        }


        private void BindAlgorithmNames()
        {
            List<string> classNames = _routineNameLoader.Load("Sorter.Algorithms.dll", typeof (SortRoutine));

            if (classNames.Count >= 0)
                _comboBxAlgorithm.DataSource = classNames;
        }

        private void BrowseFilesToSort_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = ConstructOpenFileDialog();
            
            string[] safeFiles = null;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                safeFiles = openFileDialog.SafeFileNames;
                string[] filePaths = openFileDialog.FileNames;
                _dataToSort = ReadSortData(filePaths);
            }

            if (_dataToSort == null) return;
                PopulateListBoxWithFileNamesToSort(safeFiles);           
        }

        private OpenFileDialog ConstructOpenFileDialog()
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
            if (_lBoxSelectedFiles.Items.Count == 0)
                return;

            _btnCancelSort.Enabled = true;
            
            if (_comboBxAlgorithm.SelectedValue.Equals("BubbleSort"))
            {
                SortRoutine bubbleSort = new BubbleSort(new SortStopwatch());
                bubbleSort.Completed += DisplaySortResults;
                _sorter = new SorterContext(bubbleSort);
                
                StartProgressBar();

                await _sorter.Sort(_dataToSort, _cancelTokenSrcWrapper.Token);   
            }

            if (_comboBxAlgorithm.SelectedValue.Equals("CocktailShakerSort"))
            {
                var cocktailShakerSort = new CocktailShakerSort(new SortStopwatch());
                cocktailShakerSort.Completed += DisplaySortResults;
                _sorter = new SorterContext(cocktailShakerSort);
                
                StartProgressBar();

                Task<int[]> result = _sorter.Sort(_dataToSort, _cancelTokenSrcWrapper.Token);
            }

            if (_comboBxAlgorithm.SelectedValue.Equals("GnomeSort"))
            {
                var gnomeSort = new GnomeSort(new SortStopwatch());
                gnomeSort.Completed += DisplaySortResults;
                _sorter = new SorterContext(gnomeSort);
                
                StartProgressBar();
                
                Task<int[]> result = _sorter.Sort(_dataToSort, _cancelTokenSrcWrapper.Token);
            }

            if (_comboBxAlgorithm.SelectedValue.Equals("HeapSort"))
            {
                var heapSort = new HeapSort(new SortStopwatch());
                heapSort.Completed += DisplaySortResults;
                _sorter = new SorterContext(heapSort);
                
                StartProgressBar();

                Task<int[]> result = _sorter.Sort(_dataToSort, _cancelTokenSrcWrapper.Token);
            }

            if (_comboBxAlgorithm.SelectedValue.Equals("InsertionSort"))
            {
                var insertionSort = new InsertionSort(new SortStopwatch());
                insertionSort.Completed += DisplaySortResults;
                
                _sorter = new SorterContext(insertionSort);
                
                StartProgressBar();

                Task<int[]> result = _sorter.Sort(_dataToSort, _cancelTokenSrcWrapper.Token);
            }

            if (_comboBxAlgorithm.SelectedValue.Equals("QuickSort"))
            {
                var quickSort = new QuickSort(new SortStopwatch());
                quickSort.Completed += DisplaySortResults;
                _sorter = new SorterContext(quickSort);
                
                StartProgressBar();

                Task<int[]> result = _sorter.Sort(_dataToSort, _cancelTokenSrcWrapper.Token);
            }

            if (_comboBxAlgorithm.SelectedValue.Equals("SelectionSort"))
            {
                var selectionSort = new SelectionSort(new SortStopwatch());
                selectionSort.Completed += DisplaySortResults;
                _sorter = new SorterContext(selectionSort);
                
                StartProgressBar();

                Task<int[]> result = _sorter.Sort(_dataToSort, _cancelTokenSrcWrapper.Token);
            }

            if (_comboBxAlgorithm.SelectedValue.Equals("ShellSort"))
            {
                var shellSort = new ShellSort(new SortStopwatch());
                shellSort.Completed += DisplaySortResults;
                _sorter = new SorterContext(shellSort);
                StartProgressBar();
                Task<int[]> result = _sorter.Sort(_dataToSort, _cancelTokenSrcWrapper.Token);
            }
        }

        private void StartProgressBar()
        {
            _progressBar.Style = ProgressBarStyle.Marquee;
            _progressBar.MarqueeAnimationSpeed = 1;   
        }

        private void DisplaySortResults(object sender, SortCompleteEventArgs e)
        {
            Activate();
            
            _btnCancelSort.Enabled = false;
            _progressBar.Style = ProgressBarStyle.Continuous;
                        
            var sortResults = new SortResults();
            
            sortResults.ConstructSortResults(e);
            sortResults.ShowDialog();
            ResetApplication();
        }

        private void CancelCurrentSort_Click(object sender, EventArgs e)
        {
            if (e == null) return;
 
            ResetCancellationTokenSource();           
            _progressBar.Style = ProgressBarStyle.Continuous;               
            ResetApplication();
        }

        private void ResetCancellationTokenSource()
        {
            _cancelTokenSrcWrapper.Cancel();
            _cancelTokenSrcWrapper.Dispose();
            _cancelTokenSrc = new CancellationTokenSource();
            _cancelTokenSrcWrapper = new CancellationTokenSourceWrapper(_cancelTokenSrc);  
        }

        private void ResetApplication_Click(object sender, EventArgs e)
        {
            ResetApplication();
        }

        private void ResetApplication()
        {
            _lBoxSelectedFiles.Items.Clear();
            _dataToSort = null;
            _comboBxAlgorithm.SelectedIndex = 0;
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
