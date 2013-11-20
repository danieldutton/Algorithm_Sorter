using Sorter.Input;
using Sorter.Input.Interfaces;
using Sorter.Utilities.Algorithms;
using Sorter.Utilities.Readers;
using System;
using System.Windows.Forms;

namespace Sorter.Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IStreamReaderBuilder streamBuilder = new StreamReaderBuilder();
            IFileReader<int> fileReader = new DatFileReader<int>(streamBuilder); 
            IRoutineNameLoader classNameLoader = new RoutineNameLoader();
            Application.Run(new SortForm(fileReader, classNameLoader));
        }
    }
}
