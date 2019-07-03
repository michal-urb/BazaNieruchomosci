using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaNieruchomosci.Models
{
    public interface IImmovablePropertyRepository
    {
        IEnumerable<ImmovableProperty> GetImmovableProperties();

        ImmovableProperty GetImmovableProperty(string number);

        void AddImmovableProperty(ImmovableProperty immovableProperty);

        void EditImmovableProperty(ImmovableProperty immovableProperty);

        void DeleteImmovableProperty(ImmovableProperty immovableProperty);

        //IEnumerable<CommercialSpace> GetCommercialSpaces();

        //CommercialSpace GetCommercialSpace(int id);

        //IEnumerable<Flat> GetFlats();

        //Flat GetFlat(int id);

        //IEnumerable<House> GetHouses();

        //House GetHouse(int id);

        //IEnumerable<BuildingPlot> GetBuildingPlots();

        //BuildingPlot GetBuildingPlot(int id);
    }
}
