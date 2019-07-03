using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaNieruchomosci.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.BuildingPlots.Any() && !context.Flats.Any() && 
                !context.Houses.Any() && !context.CommercialSpaces.Any())
            {
                context.BuildingPlots.Add(
                     new BuildingPlot.BuildingPlotBuilder()
                     .SerialNumber(Guid.NewGuid().ToString())
                     .Area("20 a")
                     .Description("Działka budowlana o pow. 20 arów")
                     .District("Dolnośląskie")
                     .Place("Wrocław")
                     .Price(200000)
                     .Region("Las")
                     .Street("ul. Długa 10")
                     .Build()
                    );
                context.CommercialSpaces.Add(
                    new CommercialSpace.CommercialSpaceBuilder()
                    .SerialNumber(Guid.NewGuid().ToString())
                    .Area("100 mkw")
                    .Description("Lokal biurowy o pow. 100 mkw")
                    .District("Dolnośląskie")
                    .Parking(true)
                    .Place("Wrocław")
                    .Price(500000)
                    .Street("ul. Strzegomska 30")
                    .Use("Lokal biurowy")
                    .YearOfBuilding(2018)
                    .Build()
                    );
                context.Flats.Add(
                    new Flat.FlatBuilder()
                    .SerialNumber(Guid.NewGuid().ToString())
                    .Area("50 mkw")
                    .Balcony(true)
                    .Description("Mieszkanie o pow. 50 mkw")
                    .District("Dolnoslaskie")
                    .Floor(2)
                    .Lift(true)
                    .Place("Wroclaw")
                    .Price(350000)
                    .Rooms(3)
                    .Street("ul. Kwiatowa 18")
                    .Build()
                    );
                context.Houses.Add(
                    new House.HouseBuilder()
                    .SerialNumber(Guid.NewGuid().ToString())
                    .Area("120 mkw")
                    .Description("Dom o pow. 120 mkw")
                    .District("Dolnoslaskie")
                    .Floor(2)
                    .Place("Wroclaw")
                    .PlotArea("15 a")
                    .Price(300000)
                    .Rooms(4)
                    .Street("ul. Polna 15")
                    .YearOfBuilding(2014)
                    .Build()
                    );

                context.SaveChanges();
            }
        }
    }
}
