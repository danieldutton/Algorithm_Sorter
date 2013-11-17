using Sorter.Input.Exceptions;
using Sorter.Input.Interfaces;
using Sorter.Utilities.Readers;
using System;
using System.Collections.Generic;

namespace Sorter.Input
{
    public sealed class DatFileReader<TTypeToRead> : IFileReader<TTypeToRead>
    {
        private readonly IStreamReaderBuilder _streamBuilder;

        private TTypeToRead[] _dataArray;

        private readonly List<TTypeToRead> _tempDataList = new List<TTypeToRead>();


        public DatFileReader(IStreamReaderBuilder streamBuilder)
        {
            _streamBuilder = streamBuilder;
        }

        public TTypeToRead[] Read(params string[] filePaths)
        {
            if(filePaths == null) throw new ArgumentNullException("filePaths");
   
            _tempDataList.Clear();

            try
            {
                foreach (string filePath in filePaths)
                {
                    _streamBuilder.BuildStreamReader(filePath);

                    string line;
                    while ((line = _streamBuilder.StreamReader.ReadLine()) != null)
                    {
                        _tempDataList.Add((TTypeToRead) Convert.ChangeType(line, typeof (TTypeToRead)));
                    }
                    _dataArray = new TTypeToRead[_tempDataList.Count];

                    _tempDataList.CopyTo(_dataArray);

                }
            }

            //ToDo - test Exceptions
            catch (FormatException e)
            {
                throw new FileReadException("Data Corrupt", e);
            }
            catch (Exception e)
            {
                throw new FileReadException("Error", e);
            }
            return _dataArray;
        }
    }
}
