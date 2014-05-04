using Sorter.Algorithms.EventArg;
using System;
using System.Windows.Forms;

namespace Sorter.Presentation
{
    internal partial class SortResults : Form
    {
        private const string MillisecondSymbol = "ms";

        internal SortResults()
        {
            InitializeComponent();
        }

        internal void DisplaySortResults(SortFinishedEventArg sort)
        {
            if(sort.WasCancelled) 
                PopulateLabelValues_SortCancelled(sort);
            else
                PopulateLabelValues_SortComplete(sort);   
        }

        private void PopulateLabelValues_SortCancelled(SortFinishedEventArg sort)
        {
            _lblItemSortCountValue.Text = "Cancelled";
            _lblTimeTakenValue.Text = sort.ElapsedTimeMilliSec + MillisecondSymbol;
        }

        internal void PopulateLabelValues_SortComplete(SortFinishedEventArg sort)
        {
            _lblItemSortCountValue.Text = sort.ItemSortCount.ToString();
            _lblTimeTakenValue.Text = sort.ElapsedTimeMilliSec + MillisecondSymbol;    
        }

        private void CloseDialog_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
