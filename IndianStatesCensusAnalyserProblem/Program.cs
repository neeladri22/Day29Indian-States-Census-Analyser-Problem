﻿using System;

namespace IndianStateCensusAnalyserProblem
{
    internal class ProgramH
    {
        // CSV Firl Paths 
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";

        static string indianStateCensusFilePath = @"F:\Day29_Indian States Census Analyser Problem\IndianStatesCensusAnalyserProblem\CSV\IndiaStateCensusData.csv";



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Indian State Census Analyser Problem ");

            IndianCensusAdapter indianCensusAdapter = new IndianCensusAdapter();

            // Loading the Census Data File
            indianCensusAdapter.LoadCensusData(indianStateCensusFilePath, indianStateCensusHeaders);
        }
    }
}