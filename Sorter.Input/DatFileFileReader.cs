using System;
using System.Collections.Generic;
using System.IO;
using Sorter.Input.Exceptions;
using Sorter.Input.Interfaces;

namespace Sorter.Input
{
    public class DatFileFileReader<TType> : IFileReader<TType>
    {
        private readonly TextReader _textReader;

        private TType[] _tempNumberArray;

        private readonly List<TType> _tempNumberList = new List<TType>();

        public DatFileFileReader(TextReader textReader)
        {
            _textReader = textReader;
        }

        public TType[] Read(params string[] filePaths)
        {
            if(filePaths == null) throw new ArgumentNullException("filePaths"); 
   
            _tempNumberList.Clear();

            try
            {
                for (int i = 0; i < filePaths.Length; i++)
                {
                    string line = null;
                    while ((line = _textReader.ReadLine()) != null)
                    {
                        _tempNumberList.Add((TType)Convert.ChangeType(line, typeof(TType)));
                    }
                    _tempNumberArray = new TType[_tempNumberList.Count];

                    _tempNumberList.CopyTo(_tempNumberArray);
                }
            }
            catch (Exception)
            {
                throw new FileReadException();
            }
            return _tempNumberArray;
        }
    }
}
