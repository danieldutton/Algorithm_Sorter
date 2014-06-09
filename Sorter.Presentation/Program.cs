using Sorter.Input;
using Sorter.Input.Interfaces;
using Sorter.Utilities;
using Sorter.Utilities.Interfaces;
using Sorter.Utilities.Wrappers;
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

            IStreamReaderBuilder streamBuilder = new StreamReaderWrapper();
            IFileReader<int> fileReader = new DatFileReader<int>(streamBuilder); 
            
            ITypeNameExtractor typeNameExtractor = new TypeNameExtractor();
            
            Application.Run(new SortForm(fileReader, typeNameExtractor));
        }
    }
}
