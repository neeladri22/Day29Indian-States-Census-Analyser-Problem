
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

        static string indianStateCensusFilePath = @"E:\LFP158\Assignment\Day 29\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\CSV\IndiaStateCensusData.csv";

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
    }
}


