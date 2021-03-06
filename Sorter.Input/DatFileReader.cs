﻿using Sorter.Input.Interfaces;
using Sorter.Utilities.Interfaces;
using System;
using System.Collections.Generic;

namespace Sorter.Input
{
    public sealed class DatFileReader<TTypeToRead> : IFileReader<TTypeToRead>
    {
        private readonly IStreamReaderBuilder _streamBuilder;

        private TTypeToRead[] _dataArray;

        private readonly List<TTypeToRead> _tempDataList;


        public DatFileReader(IStreamReaderBuilder streamBuilder)
        {
            _streamBuilder = streamBuilder;
            _tempDataList = new List<TTypeToRead>();
        }

        public TTypeToRead[] Read(string[] filePaths)
        {
            if (filePaths == null) throw new ArgumentNullException("filePaths");

            _tempDataList.Clear();

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

            return _dataArray;
        }
    }
}