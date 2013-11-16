using Sorter.Algorithms.EventArg;
using System;
using System.Windows.Forms;

namespace Sorter.Presentation
{
    internal partial class SortResults : Form
    {
        internal SortResults()
        {
            InitializeComponent();
        }

        internal void BuildResults(SortCompleteEventArgs e)
        {
            if (e != null)
            {
                const string msValue = " ms";

                _lblItemSortCountValue.Text = e.ItemSortCount.ToString();
                _lblStartTimeValue.Text = e.StartTimeMilliSec.ToString() + msValue;
                _lblStopTimeValue.Text = e.StopTimeMilliSec.ToString() + msValue;
                _lblElapsedTimeValue.Text = e.ElapsedTimeMilliSec.ToString() + msValue;   
            }
            else
                DisplayErrorValues();   
        }

        private void DisplayErrorValues()
        {
            const string errorValue = "Error";

            _lblStartTimeValue.Text = errorValue;
            _lblStopTimeValue.Text = errorValue;
            _lblElapsedTimeValue.Text = errorValue;
            _lblItemSortCountValue.Text = errorValue;
        }

        private void CloseDialog_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
