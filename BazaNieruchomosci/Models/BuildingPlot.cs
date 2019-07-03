using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaNieruchomosci.Models
{
    public class BuildingPlot : ImmovableProperty
    {
        private int _id;
        public override int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _serialNumber;
        public override string SerialNumber
        {
            get { return _serialNumber; }
            set { _serialNumber = value; }
        }
        private decimal _price;
        public override decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private string _area;
        public override string Area
        {
            get { return _area; }
            set { _area = value; }
        }
        private string _description;
        public override string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private string _street;
        public override string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        private string _place;
        public override string Place
        {
            get { return _place; }
            set { _place = value; }
        }
        private string _district;
        public override string District
        {
            get { return _district; }
            set { _district = value; }
        }
        private string _image;
        public override string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        private string _imageThumbnail;
        public override string ImageThumbnail
        {
            get { return _imageThumbnail; }
            set { _imageThumbnail = value; }
        }
        public string Region { get; set; }

        public BuildingPlot(BuildingPlotBuilder buildingPlotBuilder)
        {
            Id = buildingPlotBuilder.id;
            SerialNumber = buildingPlotBuilder.serialNumber;
            Price = buildingPlotBuilder.price;
            Area = buildingPlotBuilder.area;
            Description = buildingPlotBuilder.description;
            Street = buildingPlotBuilder.street;
            Place = buildingPlotBuilder.place;
            District = buildingPlotBuilder.district;
            Image = buildingPlotBuilder.image;
            ImageThumbnail = buildingPlotBuilder.imageThumbnail;
            Region = buildingPlotBuilder.region;
        }

        public BuildingPlot()
        {

        }

        public class BuildingPlotBuilder
        {
            public int id;
            public string serialNumber;
            public decimal price;
            public string area;
            public string description;
            public string street;
            public string place;
            public string district;
            public string image;
            public string imageThumbnail;
            public string region;

            public BuildingPlotBuilder Id(int id)
            {
                this.id = id;
                return this;
            }

            public BuildingPlotBuilder SerialNumber(string serialNumber)
            {
                this.serialNumber = serialNumber;
                return this;
            }

            public BuildingPlotBuilder Area(string area)
            {
                this.area = area;
                return this;
            }

            public BuildingPlotBuilder Description(string description)
            {
                this.description = description;
                return this;
            }

            public BuildingPlotBuilder District(string district)
            {
                this.district = district;
                return this;
            }

            public BuildingPlotBuilder Image(string image)
            {
                this.image = image;
                return this;
            }

            public BuildingPlotBuilder ImageThumbnail(string imageThumbnail)
            {
                this.imageThumbnail = imageThumbnail;
                return this;
            }

            public BuildingPlotBuilder Place(string place)
            {
                this.place = place;
                return this;
            }

            public BuildingPlotBuilder Price(decimal price)
            {
                this.price = price;
                return this;
            }

            public BuildingPlotBuilder Street(string street)
            {
                this.street = street;
                return this;
            }

            public BuildingPlotBuilder Region(string region)
            {
                this.region = region;
                return this;
            }

            public BuildingPlot Build()
            {
                return new BuildingPlot(this);
            }
        }
    }
}
