﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IndianStateCensusAnalyserProblem.POCO
{
    public abstract class CensusAdapter
    {

        /// Loads the census data.
        protected string[] GetCensusData(string csvFilePath, string dataHeaders)
        {
            string[] censusData;
            if (!File.Exists(csvFilePath))
            {
                throw new CensusAnalyserException("File not Found", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);
            }
            if (Path.GetExtension(csvFilePath) != ".csv")
            {
                throw new CensusAnalyserException("Invalid File Type", CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE);
            }
            censusData = File.ReadAllLines(csvFilePath);
            if (censusData[0] != dataHeaders)
            {
                throw new CensusAnalyserException("Incorrect header in Data", CensusAnalyserException.ExceptionType.INCORRECT_HEADER);
            }
            return censusData;
        }
    }
}