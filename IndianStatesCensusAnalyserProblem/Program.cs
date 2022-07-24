using System;

namespace IndianStateCensusAnalyserProblem
{
    internal class ProgramH
    {
        // CSV Firl Paths 
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";

        static string indianStateCensusFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\IndiaStateCensusData.csv";
        static string wrongIndianStateCensusFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\IndiaData.csv";
        static string wrongIndianStateCensusFileType = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\IndianStateCensus.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Indian State Census Analyser Problem ");

            IndianCensusAdapter indianCensusAdapter = new IndianCensusAdapter();

            // Loading the Census Data File
            indianCensusAdapter.LoadCensusData(indianStateCensusFilePath, indianStateCensusHeaders);

            //1.2
            indianCensusAdapter.LoadCensusData(wrongIndianStateCensusFilePath, indianStateCensusHeaders);

            //1.3
            indianCensusAdapter.LoadCensusData(wrongIndianStateCensusFileType, indianStateCensusHeaders);

        }
    }
}