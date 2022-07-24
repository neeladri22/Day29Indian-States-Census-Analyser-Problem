
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
    }
}


