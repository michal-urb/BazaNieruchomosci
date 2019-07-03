using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BazaNieruchomosci.Models.House;

namespace BazaNieruchomosci.Models
{
    public class MockImmovablePropertyRepository : IImmovablePropertyRepository
    {
        //private List<House> houses = new List<House>();
        //private List<Flat> flats = new List<Flat>();
        //private List<CommercialSpace> commercialSpaces = new List<CommercialSpace>();
        //private List<BuildingPlot> buildingPlots = new List<BuildingPlot>();
        private List<ImmovableProperty> immovableProperties = new List<ImmovableProperty>();

        public MockImmovablePropertyRepository()
        {
            //if (houses == null && flats == null && commercialSpaces == null && buildingPlots == null)
            //{
            //    LoadImmovableProperties();
            //}
            if (immovableProperties == null)
            {
                LoadImmovableProperties();
            }
        }

        public void AddImmovableProperty(ImmovableProperty immovableProperty)
        {
            throw new NotImplementedException();
        }

        public void DeleteImmovableProperty(ImmovableProperty immovableProperty)
        {
            throw new NotImplementedException();
        }

        public void EditImmovableProperty(ImmovableProperty immovableProperty)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ImmovableProperty> GetImmovableProperties()
        {
            return immovableProperties;
        }

        public ImmovableProperty GetImmovableProperty(string number)
        {
            return immovableProperties.FirstOrDefault(p => p.SerialNumber == number);
        }

        //public BuildingPlot GetBuildingPlot(int id)
        //{
        //    return buildingPlots.FirstOrDefault(p => p.Id == id);
        //}

        //public IEnumerable<BuildingPlot> GetBuildingPlots()
        //{
        //    return buildingPlots;
        //}

        //public CommercialSpace GetCommercialSpace(int id)
        //{
        //    return commercialSpaces.FirstOrDefault(p => p.Id == id);
        //}

        //public IEnumerable<CommercialSpace> GetCommercialSpaces()
        //{
        //    return commercialSpaces;
        //}

        //public Flat GetFlat(int id)
        //{
        //    return flats.FirstOrDefault(p => p.Id == id);
        //}

        //public IEnumerable<Flat> GetFlats()
        //{
        //    return flats;
        //}

        //public House GetHouse(int id)
        //{
        //    return houses.FirstOrDefault(p => p.Id == id);
        //}

        //public IEnumerable<House> GetHouses()
        //{
        //    return houses;
        //}

        private void LoadImmovableProperties()
        {
            immovableProperties = new List<ImmovableProperty>
            {
                new House.HouseBuilder()
                .SerialNumber(Guid.NewGuid().ToString())
                .Area("120 mkw")
                .Description("Dom o pow. 120 mkw")
                .District("Dolnoslaskie")
                .Floor(2)
                .Id(1)
                .Place("Wroclaw")
                .PlotArea("15 a")
                .Price(300000)
                .Rooms(4)
                .Street("ul. Polna 15")
                .YearOfBuilding(2014)
                .Build(),

                new Flat.FlatBuilder()
                .SerialNumber(Guid.NewGuid().ToString())
                .Area("50 mkw")
                .Balcony(true)
                .Description("Mieszkanie o pow. 50 mkw")
                .District("Dolnoslaskie")
                .Floor(2)
                .Id(2)
                .Lift(true)
                .Place("Wroclaw")
                .Price(350000)
                .Rooms(3)
                .Street("ul. Kwiatowa 18")
                .Build(),

                new BuildingPlot.BuildingPlotBuilder()
                .SerialNumber(Guid.NewGuid().ToString())
                .Area("20 a")
                .Description("Działka budowlana o pow. 20 arów")
                .District("Dolnośląskie")
                .Id(3)
                .Place("Wrocław")
                .Price(200000)
                .Region("Las")
                .Street("ul. Długa 10")
                .Build(),

                new CommercialSpace.CommercialSpaceBuilder()
                .SerialNumber(Guid.NewGuid().ToString())
                .Area("100 mkw")
                .Description("Lokal biurowy o pow. 100 mkw")
                .District("Dolnośląskie")
                .Id(4)
                .Parking(true)
                .Place("Wrocław")
                .Price(500000)
                .Street("ul. Strzegomska 30")
                .Use("Lokal biurowy")
                .YearOfBuilding(2018)
                .Build()
            };

            //House house = new House.HouseBuilder()
            //    .SerialNumber(Guid.NewGuid().ToString())
            //    .Area("120 mkw")
            //    .Description("Dom o pow. 120 mkw")
            //    .District("Dolnoslaskie")
            //    .Floor(2)
            //    .Id(1)
            //    .Place("Wroclaw")
            //    .PlotArea("15 a")
            //    .Price(300000)
            //    .Rooms(4)
            //    .Street("ul. Polna 15")
            //    .YearOfBuilding(2014)
            //    .Build();

            //houses.Add(house);

            //Flat flat = new Flat.FlatBuilder()
            //    .SerialNumber(Guid.NewGuid().ToString())
            //    .Area("50 mkw")
            //    .Balcony(true)
            //    .Description("Mieszkanie o pow. 50 mkw")
            //    .District("Dolnoslaskie")
            //    .Floor(2)
            //    .Id(2)
            //    .Lift(true)
            //    .Place("Wroclaw")
            //    .Price(350000)
            //    .Rooms(3)
            //    .Street("ul. Kwiatowa 18")
            //    .Build();

            //flats.Add(flat);

            //BuildingPlot plot = new BuildingPlot.BuildingPlotBuilder()
            //    .SerialNumber(Guid.NewGuid().ToString())
            //    .Area("20 a")
            //    .Description("Działka budowlana o pow. 20 arów")
            //    .District("Dolnośląskie")
            //    .Id(3)
            //    .Place("Wrocław")
            //    .Price(200000)
            //    .Region("Las")
            //    .Street("ul. Długa 10")
            //    .Build();

            //buildingPlots.Add(plot);

            //CommercialSpace space = new CommercialSpace.CommercialSpaceBuilder()
            //    .SerialNumber(Guid.NewGuid().ToString())
            //    .Area("100 mkw")
            //    .Description("Lokal biurowy o pow. 100 mkw")
            //    .District("Dolnośląskie")
            //    .Id(4)
            //    .Parking(true)
            //    .Place("Wrocław")
            //    .Price(500000)
            //    .Street("ul. Strzegomska 30")
            //    .Use("Lokal biurowy")
            //    .YearOfBuilding(2018)
            //    .Build();

            //commercialSpaces.Add(space);
        }
    }
}
