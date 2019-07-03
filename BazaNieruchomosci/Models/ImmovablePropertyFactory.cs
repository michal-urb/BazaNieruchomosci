using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaNieruchomosci.Models
{
    public class ImmovablePropertyFactory : IImmovablePropertyFactory
    {
        public ImmovableProperty GetProperty(ImmovableProperty immovableProperty)
        {
            ImmovableProperty property = null;

            if (immovableProperty.Description.ToUpper().Contains("MIESZKANIE"))
                property = new Flat.FlatBuilder()
                    .SerialNumber(Guid.NewGuid().ToString())
                    .Price(immovableProperty.Price)
                    .Area(immovableProperty.Area)
                    .Description(immovableProperty.Description)
                    .Street(immovableProperty.Street)
                    .Place(immovableProperty.Place)
                    .District(immovableProperty.District)
                    .Image(immovableProperty.Image)
                    .ImageThumbnail(immovableProperty.ImageThumbnail)
                    .Build();

            else if (immovableProperty.Description.ToUpper().Contains("DOM"))
                property = new House.HouseBuilder()
                    .SerialNumber(Guid.NewGuid().ToString())
                    .Price(immovableProperty.Price)
                    .Area(immovableProperty.Area)
                    .Description(immovableProperty.Description)
                    .Street(immovableProperty.Street)
                    .Place(immovableProperty.Place)
                    .District(immovableProperty.District)
                    .Image(immovableProperty.Image)
                    .ImageThumbnail(immovableProperty.ImageThumbnail)
                    .Build();

            else if (immovableProperty.Description.ToUpper().Contains("DZIAŁKA"))
                property = new BuildingPlot.BuildingPlotBuilder()
                    .SerialNumber(Guid.NewGuid().ToString())
                    .Price(immovableProperty.Price)
                    .Area(immovableProperty.Area)
                    .Description(immovableProperty.Description)
                    .Street(immovableProperty.Street)
                    .Place(immovableProperty.Place)
                    .District(immovableProperty.District)
                    .Image(immovableProperty.Image)
                    .ImageThumbnail(immovableProperty.ImageThumbnail)
                    .Build();

            else if (immovableProperty.Description.ToUpper().Contains("LOKAL"))
                property = new CommercialSpace.CommercialSpaceBuilder()
                    .SerialNumber(Guid.NewGuid().ToString())
                    .Price(immovableProperty.Price)
                    .Area(immovableProperty.Area)
                    .Description(immovableProperty.Description)
                    .Street(immovableProperty.Street)
                    .Place(immovableProperty.Place)
                    .District(immovableProperty.District)
                    .Image(immovableProperty.Image)
                    .ImageThumbnail(immovableProperty.ImageThumbnail)
                    .Build();

            return property;
        }
    }
}
