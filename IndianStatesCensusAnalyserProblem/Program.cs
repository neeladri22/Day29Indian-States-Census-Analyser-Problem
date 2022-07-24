using System;

namespace IndianStateCensusAnalyserProblem
{
    internal class ProgramH
    {
        // CSV Firl Paths 
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";

        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";

        static string indianStateCensusFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\IndiaStateCensusData.csv";
        static string wrongIndianStateCensusFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\IndiaData.csv";
        static string wrongIndianStateCensusFileType = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\IndianStateCensus.txt";
        static string delimiterIndianCensusFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\IndianStateCesusDelimeter.csv";
        static string wrongHeaderIndianCensusFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\WrongIndiaStateCensusData.csv";

        static string indianStateCodeFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\IndiaStateCodes.csv";
        static string wrongIndianStateCodeFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\StateCodeData.csv";
        static string wrongIndianStateCodeFileType = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\IndiaStateCodes.txt";
        static string delimiterIndianStateCodeFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\DelimiterIndiaStateCodes.csv";
        static string wrongHeaderStateCodeFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSV\WrongHeaderIndiaStateCodes.csv";


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

            //1.4
            indianCensusAdapter.LoadCensusData(delimiterIndianCensusFilePath, indianStateCensusHeaders);

            //1.5
            indianCensusAdapter.LoadCensusData(wrongHeaderIndianCensusFilePath, indianStateCensusHeaders);

            // Loading the State census Data File
            indianCensusAdapter.LoadCensusData(indianStateCodeFilePath, indianStateCodeHeaders);

            //2.2
            indianCensusAdapter.LoadCensusData(wrongIndianStateCodeFilePath, indianStateCodeHeaders);

            //2.3
            indianCensusAdapter.LoadCensusData(wrongIndianStateCodeFileType, indianStateCodeHeaders);
            //2.4
            indianCensusAdapter.LoadCensusData(delimiterIndianStateCodeFilePath, indianStateCodeHeaders);
            //2.5
            indianCensusAdapter.LoadCensusData(wrongHeaderStateCodeFilePath, indianStateCodeHeaders);


        }
    }
}