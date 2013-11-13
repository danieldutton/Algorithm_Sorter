using Sorter.Input;
using Sorter.Input.Interfaces;
using System;
using System.IO;
using System.Windows.Forms;
using Sorter.Utilities.Readers;

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
            Application.Run(new Form1(fileReader));
        }
    }
}
