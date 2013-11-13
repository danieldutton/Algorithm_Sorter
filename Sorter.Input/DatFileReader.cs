using Sorter.Input.Exceptions;
using Sorter.Input.Interfaces;
using Sorter.Utilities.Readers;
using System;
using System.Collections.Generic;

namespace Sorter.Input
{
    public sealed class DatFileReader<TType> : IFileReader<TType>
    {
        private readonly IStreamReaderBuilder _streamBuilder;

        private TType[] _dataArray;

        private readonly List<TType> _tempDataList = new List<TType>();


        public DatFileReader(IStreamReaderBuilder streamBuilder)
        {
            _streamBuilder = streamBuilder;
        }

        public TType[] Read(params string[] filePaths)
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
                            _tempDataList.Add((TType) Convert.ChangeType(line, typeof (TType)));
                        }
                        _dataArray = new TType[_tempDataList.Count];

                        _tempDataList.CopyTo(_dataArray);
                    
                }
            }
            catch (Exception e)
            {
                throw new FileReadException("error");
            }
            return _dataArray;
        }
    }
}
