﻿using Sorter.Algorithms.EventArg;
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
            if(e.WasCancelled) 
                SetCancelledValues(e);
            else
                SetCompletedValues(e);   
        }

        private void SetCancelledValues(SortCompleteEventArgs e)
        {
            const string msValue = " ms";

            _lblItemSortCountValue.Text = "Cancelled";
            _lblElapsedTimeValue.Text = e.ElapsedTimeMilliSec.ToString() + msValue;
        }

        internal void SetCompletedValues(SortCompleteEventArgs e)
        {
            const string msValue = " ms";

            _lblItemSortCountValue.Text = e.ItemSortCount.ToString();
            _lblElapsedTimeValue.Text = e.ElapsedTimeMilliSec.ToString() + msValue;    
        }

        private void CloseDialog_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
