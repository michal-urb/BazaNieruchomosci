using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaNieruchomosci.Models
{
    public class House : ImmovableProperty
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
        public int YearOfBuilding { get; set; }
        public int Rooms { get; set; }
        public int Floor { get; set; }
        public string PlotArea { get; set; }

        public House()
        {

        }

        public House(HouseBuilder flatBuilder)
        {
            Id = flatBuilder.id;
            SerialNumber = flatBuilder.serialNumber;
            Price = flatBuilder.price;
            Area = flatBuilder.area;
            Description = flatBuilder.description;
            Street = flatBuilder.street;
            Place = flatBuilder.place;
            District = flatBuilder.district;
            Image = flatBuilder.image;
            ImageThumbnail = flatBuilder.imageThumbnail;
            Rooms = flatBuilder.rooms;
            Floor = flatBuilder.floor;
            YearOfBuilding = flatBuilder.yearOfBuilding;
            PlotArea = flatBuilder.plotArea;
        }

        public class HouseBuilder
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
            public int rooms;
            public int floor;
            public string plotArea;
            public int yearOfBuilding;

            public HouseBuilder Id(int id)
            {
                this.id = id;
                return this;
            }

            public HouseBuilder SerialNumber(string serialNumber)
            {
                this.serialNumber = serialNumber;
                return this;
            }

            public HouseBuilder Area(string area)
            {
                this.area = area;
                return this;
            }

            public HouseBuilder Description(string description)
            {
                this.description = description;
                return this;
            }

            public HouseBuilder District(string district)
            {
                this.district = district;
                return this;
            }

            public HouseBuilder Image(string image)
            {
                this.image = image;
                return this;
            }

            public HouseBuilder ImageThumbnail(string imageThumbnail)
            {
                this.imageThumbnail = imageThumbnail;
                return this;
            }

            public HouseBuilder Place(string place)
            {
                this.place = place;
                return this;
            }

            public HouseBuilder Price(decimal price)
            {
                this.price = price;
                return this;
            }

            public HouseBuilder Street(string street)
            {
                this.street = street;
                return this;
            }

            public HouseBuilder Rooms(int rooms)
            {
                this.rooms = rooms;
                return this;
            }

            public HouseBuilder Floor(int floor)
            {
                this.floor = floor;
                return this;
            }

            public HouseBuilder YearOfBuilding(int yearOfBuilding)
            {
                this.yearOfBuilding = yearOfBuilding;
                return this;
            }

            public HouseBuilder PlotArea(string plotArea)
            {
                this.plotArea = plotArea;
                return this;
            }

            public House Build()
            {
                return new House(this);
            }
        }
    }
}
