using Sorter.Input.Exceptions;
using Sorter.Input.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Sorter.Input
{
    public sealed class DatFileReader<TType> : IFileReader<TType>
    {
        private TextReader _textReader;

        private TType[] _tempDataArray;

        private readonly List<TType> _tempDataList = new List<TType>();


        public TType[] Read(params string[] filePaths)
        {
            if(filePaths == null) throw new ArgumentNullException("filePaths"); 
   
            _tempDataList.Clear();

            try
            {
                foreach (string filePath in filePaths)
                {
                    using (_textReader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = _textReader.ReadLine()) != null)
                        {
                            _tempDataList.Add((TType) Convert.ChangeType(line, typeof (TType)));
                        }
                        _tempDataArray = new TType[_tempDataList.Count];

                        _tempDataList.CopyTo(_tempDataArray);
                    }
                }
            }
            catch (Exception e)
            {
                throw new FileReadException("error");
            }
            return _tempDataArray;
        }
    }
}
