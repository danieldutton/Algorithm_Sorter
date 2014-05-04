using Sorter.Algorithms;
using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Routines;
using Sorter.Input.Exceptions;
using Sorter.Input.Interfaces;
using Sorter.Utilities.Interfaces;
using Sorter.Utilities.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter.Presentation
{
    internal partial class SortForm : Form
    {
        private readonly IFileReader<int> _fileReader;

        private readonly ITypeNameExtractor _typeNameExtractor;

        private SorterContext _sorter;

        private int[] _dataToSort;

        private CancellationTokenSource _cancelTokenSrc;

        private ICancelTokenSource _cancelTokenSrcWrapper;


        internal SortForm(IFileReader<int> fileReader, ITypeNameExtractor typeNameExtractor)
        {
            _fileReader = fileReader;
            _typeNameExtractor = typeNameExtractor;           
            
            _cancelTokenSrc = new CancellationTokenSource();
            _cancelTokenSrcWrapper = new CancellationTokenWrapper(_cancelTokenSrc);

            InitializeComponent();

            ListAvailableSortRoutines();
            ActivateControls_SortStopped();            
        }


        private void ListAvailableSortRoutines()
        {
            List<string> sortNames = _typeNameExtractor.Load("Sorter.Algorithms.dll", typeof (SortRoutine));

            if (sortNames.Count >= 0)
                _comboBxAlgorithm.DataSource = sortNames;
        }

        private void BrowseTestFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = InitialiseOpenFileDialog();
            
            string[] safeFiles = null;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                safeFiles = openFileDialog.SafeFileNames;
                string[] filePaths = openFileDialog.FileNames;
                _dataToSort = GetSortData(filePaths);
            }

            if (_dataToSort == null) return;
                DisplaySelectedFileNamesToSort(safeFiles);     
        }

        private OpenFileDialog InitialiseOpenFileDialog()
        {
            var openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "dat files(*.dat)|*.dat",
                ShowReadOnly = true,
            };

            return openFileDialog;
        }

        private void DisplaySelectedFileNamesToSort(IEnumerable<string> fileNames)
        {
            if (fileNames == null) return;
            
            foreach (var fileName in fileNames)
                _lBoxSelectedFiles.Items.Add(fileName);
        }

        private int[] GetSortData(params string[] filePaths)
        {
            try
            {
                _dataToSort = _fileReader.Read(filePaths);
            }
            catch (FileReadException)
            {
                MessageBox.Show("Error Reading Data Try Again");               
                ResetApplicationState();
            }

            return _dataToSort;
        }
        
        private void StartSort_Click(object sender, EventArgs e)
        {
            if (_lBoxSelectedFiles.Items.Count == 0)
                return;

            DisableControls_SortStarted();

            SortRoutine sortRoutine = SortRoutineFactory.CreateSortRoutine((string)_comboBxAlgorithm.SelectedValue);
            StartSort(sortRoutine);
        }

        private Task<int[]> StartSort(SortRoutine sortRoutine)
        {
            sortRoutine.Complete += DisplaySortResults;
            _sorter = new SorterContext(sortRoutine);

            AnimateProgressBarStart();

            return _sorter.SortAsync(_dataToSort, _cancelTokenSrcWrapper.Token);    
        }

        private void AnimateProgressBarStart()
        {
            _progressBar.Style = ProgressBarStyle.Marquee;
            _progressBar.MarqueeAnimationSpeed = 1;   
        }

        private void StopProgressBarAnimation()
        {
            _progressBar.Style = ProgressBarStyle.Continuous;    
        }

        private void DisplaySortResults(object sender, SortFinishedEventArg e)
        {
            Activate();
                       
            StopProgressBarAnimation();
                        
            var sortResults = new SortResults();
            
            sortResults.DisplaySortResults(e);
            sortResults.ShowDialog();
            
            ResetApplicationState();
            ActivateControls_SortStopped();
        }

        private void CancelCurrentSort_Click(object sender, EventArgs e)
        {
            ResetCancellationToken();           
            StopProgressBarAnimation();              
            ResetApplicationState();
            ActivateControls_SortStopped();
        }

        private void ResetCancellationToken()
        {
            _cancelTokenSrcWrapper.Cancel();
            _cancelTokenSrcWrapper.Dispose();
            
            _cancelTokenSrc = new CancellationTokenSource();           
            _cancelTokenSrcWrapper = new CancellationTokenWrapper(_cancelTokenSrc);  
        }

        private void ResetApplication_Click(object sender, EventArgs e)
        {
            ResetApplicationState();
        }

        private void ResetApplicationState()
        {
            _lBoxSelectedFiles.Items.Clear();
            _dataToSort = null;
            _comboBxAlgorithm.SelectedIndex = 0;
        }

        private void DisableControls_SortStarted()
        {
            _panelStepOne.Enabled = false;
            _panelStepTwo.Enabled = false;

            _btnCancelSort.Enabled = true;
            _btnSort.Enabled = false;
            _btnReset.Enabled = false;
        }

        private void ActivateControls_SortStopped()
        {
            _panelStepOne.Enabled = true;
            _panelStepTwo.Enabled = true;

            _btnCancelSort.Enabled = false;
            _btnSort.Enabled = true;
            _btnReset.Enabled = true;
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
