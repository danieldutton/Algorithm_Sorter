using System.Windows.Forms;
using Sorter.Algorithms.EventArg;

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
            if (e == null) return;

            _lblStartTimeValue.Text = e.StartTimeMilliSec.ToString();
            _lblStopTimeValue.Text = e.StopTimeMilliSec.ToString();
            _lblElapsedTimeValue.Text = e.ElapsedTimeMilliSec.ToString();
            _lblItemSortCountValue.Text = e.ItemSortCount.ToString();
        }

        private void CloseDialog_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }
    }
}
