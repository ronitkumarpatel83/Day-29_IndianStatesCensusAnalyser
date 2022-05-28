
using IndiaCensusDataDemo.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        IndiaCensusDataDemo.CSVAdapterFactory csv = null;
        //Dictionary<string, CensusDTO> totalRecords;
        Dictionary<string, CensusDTO> stateRecords;
        public string stateCensusPath = @"C:\Users\Ronit\source\repos\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\CSVFiles\IndiaStateCensusData.csv";
        [TestInitialize]
        public void SetUp()
        {
            csv = new IndiaCensusDataDemo.CSVAdapterFactory();
            // totalRecords = new Dictionary<string, CensusDTO>();
            stateRecords = new Dictionary<string, CensusDTO>();
        }
        /// TC 1.1
        /// Giving the correct path it should return the total count from the census
        [TestMethod]
        public void GivenStateCensusCSVShouldReturnRecords()
        {
            stateRecords = csv.LoadCsvData(IndiaCensusDataDemo.CensusAnalyser.Country.INDIA, stateCensusPath, "State,Population,AreaInSqKm,DensityPerSqKm");
            Assert.AreEqual(29, stateRecords.Count);
        }
    }
}
