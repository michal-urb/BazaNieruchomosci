using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaNieruchomosci.Models
{
    public class ImmovablePropertiesRepository : IImmovablePropertyRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IImmovablePropertyFactory _immovablePropertyFactory;

        public ImmovablePropertiesRepository(AppDbContext appDbContext, IImmovablePropertyFactory immovablePropertyFactory)
        {
            _appDbContext = appDbContext;
            _immovablePropertyFactory = immovablePropertyFactory;
        }

        public IEnumerable<ImmovableProperty> GetImmovableProperties()
        {
            List<ImmovableProperty> immovableProperties = new List<ImmovableProperty>();

            immovableProperties.AddRange(_appDbContext.Flats);
            immovableProperties.AddRange(_appDbContext.Houses);
            immovableProperties.AddRange(_appDbContext.CommercialSpaces);
            immovableProperties.AddRange(_appDbContext.BuildingPlots);

            return immovableProperties;
        }

        public ImmovableProperty GetImmovableProperty(string number)
        {
            List<ImmovableProperty> immovableProperties = new List<ImmovableProperty>();

            immovableProperties.AddRange(_appDbContext.Flats);
            immovableProperties.AddRange(_appDbContext.Houses);
            immovableProperties.AddRange(_appDbContext.CommercialSpaces);
            immovableProperties.AddRange(_appDbContext.BuildingPlots);

            return immovableProperties.FirstOrDefault(p => p.SerialNumber == number);
        }

        public void AddImmovableProperty(ImmovableProperty immovableProperty)
        {
            var newItem = _immovablePropertyFactory.GetProperty(immovableProperty);
            
            if (newItem is Flat)
                _appDbContext.Flats.Add(newItem as Flat);
            else if (newItem is House)
                _appDbContext.Houses.Add(newItem as House);
            else if (newItem is CommercialSpace)
                _appDbContext.CommercialSpaces.Add(newItem as CommercialSpace);
            else if (newItem is BuildingPlot)
                _appDbContext.BuildingPlots.Add(newItem as BuildingPlot);

            _appDbContext.SaveChanges();
        }

        public void DeleteImmovableProperty(ImmovableProperty immovableProperty)
        {
            if (immovableProperty is Flat)
                _appDbContext.Flats.Remove(immovableProperty as Flat);
            else if (immovableProperty is House)
                _appDbContext.Houses.Remove(immovableProperty as House);
            else if (immovableProperty is CommercialSpace)
                _appDbContext.CommercialSpaces.Remove(immovableProperty as CommercialSpace);
            else if (immovableProperty is BuildingPlot)
                _appDbContext.BuildingPlots.Remove(immovableProperty as BuildingPlot);

            _appDbContext.SaveChanges();
        }

        public void EditImmovableProperty(ImmovableProperty immovableProperty)
        {
            if (immovableProperty is Flat)
                _appDbContext.Flats.Update(immovableProperty as Flat);
            else if (immovableProperty is House)
                _appDbContext.Houses.Update(immovableProperty as House);
            else if (immovableProperty is CommercialSpace)
                _appDbContext.CommercialSpaces.Add(immovableProperty as CommercialSpace);
            else if (immovableProperty is BuildingPlot)
                _appDbContext.BuildingPlots.Add(immovableProperty as BuildingPlot);

            _appDbContext.SaveChanges();
        }


        //public BuildingPlot GetBuildingPlot(int id)
        //{
        //    return _appDbContext.BuildingPlots.FirstOrDefault(p => p.Id == id);
        //}

        //public IEnumerable<BuildingPlot> GetBuildingPlots()
        //{
        //    return _appDbContext.BuildingPlots;
        //}

        //public CommercialSpace GetCommercialSpace(int id)
        //{
        //    return _appDbContext.CommercialSpaces.FirstOrDefault(p => p.Id == id);
        //}

        //public IEnumerable<CommercialSpace> GetCommercialSpaces()
        //{
        //    return _appDbContext.CommercialSpaces;
        //}

        //public Flat GetFlat(int id)
        //{
        //    return _appDbContext.Flats.FirstOrDefault(p => p.Id == id);
        //}

        //public IEnumerable<Flat> GetFlats()
        //{
        //    return _appDbContext.Flats;
        //}

        //public House GetHouse(int id)
        //{
        //    return _appDbContext.Houses.FirstOrDefault(p => p.Id == id);
        //}

        //public IEnumerable<House> GetHouses()
        //{
        //    return _appDbContext.Houses;
        //}
    }
}
