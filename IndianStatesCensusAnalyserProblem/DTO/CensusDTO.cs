using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyserProblem.POCO
{
    public class CensusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public long housingUnits;
        public long totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;


        public CensusDTO(StateCodeDAO stateCodeDao)
        {
            this.serialNumber = stateCodeDao.serialNumber;
            this.stateName = stateCodeDao.stateName;
            this.tin = stateCodeDao.tin;
            this.stateCode = stateCodeDao.stateCode;
        }
        public CensusDTO(CensusDataDAO CensusDataDao)
        {
            this.state = CensusDataDao.state;
            this.population = CensusDataDao.population;
            this.area = CensusDataDao.area;
            this.density = CensusDataDao.density;
        }
       
    }
}