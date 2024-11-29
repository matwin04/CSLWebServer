using ColossalFramework;
using System;
using System.Xml.Linq;
using System.Xml.Serialization;
namespace CSLWebServer{
    public static class cityData{
        public static void exportCityData(){
            //Get City Population
            uint population = Singleton<DistrictManager>.instance.m_districts.m_buffer[0].m_populationData.m_finalCount;

            //Get City Name
            string cityName = Singleton<SimulationManager>.instance.m_metaData.m_CityName;
            SimulationManager simulationManager = Singleton<SimulationManager>.instance;
            string gameDate = simulationManager.m_currentGameTime.ToShortDateString();
            string gameTime = simulationManager.m_currentGameTime.ToShortTimeString();

            //Create XML Structure
            var xml = new XElement("CityData",
                new XElement("CityName",cityName),
                new XElement("Population",population),
                new XElement("GameDate",gameDate),
                new XElement("GameTime",gameTime)
            );

            //Save XML File
            xmlHandler.saveXML(xml,"CityData.xml");
        }
    }
}