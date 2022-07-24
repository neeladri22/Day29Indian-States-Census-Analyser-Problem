
using NUnit.Framework;
using IndianStateCensusAnalyserProblem;
using IndianStateCensusAnalyserProblem.POCO;
using Newtonsoft.Json;
using System.Collections.Generic;
using static IndianStateCensusAnalyserProblem.CensusAnalyser;

namespace TestProject1
{
    public class Tests
    {
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";

        static string indianStateCensusFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\CSV\IndiaStateCensusData.csv";
        static string wrongIndianStateCensusFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\";
        static string wrongIndianStateCensusFileType = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\IndianStateCensus.txt";
        static string delimiterIndianCensusFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\IndianStateCesusDelimeter.csv";
        static string wrongHeaderIndianCensusFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\WrongIndiaStateCensusData.csv";

        IndianStateCensusAnalyserProblem.CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;
        [SetUp]
        public void Setup()
        {
            censusAnalyser = new IndianStateCensusAnalyserProblem.CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }

        //count
        //TC 1.1 - Check to ensure the Number of Record matches
        [Test]
        public void GivenIndianCensusDataFile_WhenReaded_ShouldReturnCensusDataCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(5, totalRecord.Count);
        }

        //Wrong File Path
        //Tc 1.2 -  While giving incorrect CSV File it should Returns a custom Exception
        [Test]
        public void GivenWrongIndianCensusCodeFilePath_WhenRead_ShouldReturn_FILE_NOT_FOUND()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndianStateCensusFilePath, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, censusException.eType);
        }

        //WrongFileType
        //TC 1.3 - While giving incorrect type CSV File it should Returns a custom Exception
        [Test]
        public void GivenWrongIndianStateCensusFileType_WhenReaded_ShouldReturnINVALID_FILE_TYPE()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndianStateCensusFileType, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE, censusException.eType);
        }

        //TC 1.4 - While giving incorrect Delimeter it should Returns a custom Exception
        [Test]
        public void GivenWrongIndianCensusDelimiter_WhenReaded_ShouldReturnINCORRECT_DELIMITER()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, delimiterIndianCensusFilePath, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER, censusException.eType);
        }

        //WrongHeader
        //TC 1.5 - While giving wrong header it should Returns a custom Exception
        [Test]
        public void GivenWrongIndianCensusDataFilePath_WhenReaded_ShouldReturnINCORRECT_HEADER()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongHeaderIndianCensusFilePath, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_HEADER, censusException.eType);
        }
    }
}


