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

        internal void DisplaySortResults(SortCompleteEventArgs sort)
        {
            if(sort.WasCancelled) 
                PopulateLabelValues_SortCancelled(sort);
            else
                PopulateLabelValues_SortComplete(sort);   
        }

        private void PopulateLabelValues_SortCancelled(SortCompleteEventArgs sort)
        {
            _lblItemSortCountValue.Text = Properties.Resources.cancellationText;
            _lblTimeTakenValue.Text = sort.ElapsedTimeMilliSec + MillisecondSymbol;
        }

        internal void PopulateLabelValues_SortComplete(SortCompleteEventArgs sort)
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
