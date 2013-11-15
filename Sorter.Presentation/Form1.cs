using Sorter.Algorithms;
using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Routines;
using Sorter.Input.Exceptions;
using Sorter.Input.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter.Presentation
{
    public partial class Form1 : Form
    {
        private readonly IFileReader<int> _iFileReader;

        private SorterContext _sorter;

        private int[] _dataToSort;


        public Form1(IFileReader<int> fileReader)
        {
            _iFileReader = fileReader;
            
            InitializeComponent();
            BindAlgorithmNamesToComboBox();
            DisableSelectionStep2();
            DisableSelectionStep3();
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

            PopulateListBoxWithFileNamesToSort(safeFiles);
            
            _lblObjectCount.Text = _dataToSort.Length.ToString();
            
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
                InitialDirectory = @"C:\My Documents",
            };
            return openFileDialog;
        }

        private void PopulateListBoxWithFileNamesToSort(string[] fileNames)
        {
            if (fileNames != null && fileNames.Length >= 0)
            {
                _lBoxSelectedFiles.DataSource = fileNames;
            }
        }

        private int[] ReadDataToSort(params string[] filePaths)
        {
            try
            {
                _dataToSort = _iFileReader.Read(filePaths);
            }
            catch (FileReadException)
            {
                MessageBox.Show("Error reading data");
            }

            return _dataToSort;
        }

        private void BindAlgorithmNamesToComboBox()
        {
            Assembly assembly = Assembly.LoadFrom("Sorter.Algorithms.dll");
            IEnumerable<Type> result = assembly.GetTypes().Where(x => x.IsSubclassOf((typeof(SortRoutine))));

            var classNames = result.Select(className => className.Name).ToList();
            
            _comboBxAlgorithm.DataSource = classNames;
        }

        private void StartSort_Click(object sender, EventArgs e)
        {
            DisableSelectionStep2();

            var alg = _comboBxAlgorithm.SelectedValue as string;

            if ("BubbleSrt".Equals("BubbleSort"))
            {
                _sorter = new SorterContext(new BubbleSort(new Timer.Timer()));
                Task<int[]> result = _sorter.Sort(_dataToSort);
            }
            if ("HeapSor".Equals("HeapSort"))
            {
                var sortRoutine = new HeapSort(new Timer.Timer());
                Task<int[]> result = sortRoutine.SortAsync(_dataToSort);
            }
            if (alg.Equals("InsertionSort"))
            {
                var sortRoutine = new InsertionSort(new Timer.Timer());
                Task<int[]> result = sortRoutine.SortAsync(_dataToSort);
            }
            if (alg.Equals("QuickSort"))
            {
                var sortRoutine = new QuickSort(new Timer.Timer());
                Task<int[]> result = sortRoutine.SortAsync(_dataToSort);
            }

            if ("SelectionSort".Equals("SelectionSort"))
            {
                var sortRoutine = new SelectionSort(new Timer.Timer());
                sortRoutine.Completed +=SortRoutine_Completed;
                Task<int[]> result = sortRoutine.SortAsync(_dataToSort);
            }
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
        }

        private void DisableSelectionStep2()
        {
            _comboBxAlgorithm.Enabled = false;
        }

        private void EnableSelectionStep3()
        {
            _btnSort.Enabled = true;
        }

        private void DisableSelectionStep3()
        {
            _btnSort.Enabled = false;    
        }

        private void SortRoutine_Completed(object sender, SortCompleteEventArgs e)
        {
            if (e == null) return;

            LaunchSortResultsForm(e);
        }

        private void LaunchSortResultsForm(SortCompleteEventArgs e)
        {
            var sortResults = new SortResults();
            
            sortResults.BuildResults(e);
            sortResults.ShowDialog();
        }
    }
}
