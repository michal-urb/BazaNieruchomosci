using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaNieruchomosci.Models
{
    public class CommercialSpace : ImmovableProperty
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
        public string Use { get; set; }
        public bool Parking { get; set; }

        public CommercialSpace()
        {

        }

        public CommercialSpace(CommercialSpaceBuilder commercialSpaceBuilder)
        {
            Id = commercialSpaceBuilder.id;
            SerialNumber = commercialSpaceBuilder.serialNumber;
            Price = commercialSpaceBuilder.price;
            Area = commercialSpaceBuilder.area;
            Description = commercialSpaceBuilder.description;
            Street = commercialSpaceBuilder.street;
            Place = commercialSpaceBuilder.place;
            District = commercialSpaceBuilder.district;
            Image = commercialSpaceBuilder.image;
            ImageThumbnail = commercialSpaceBuilder.imageThumbnail;
            YearOfBuilding = commercialSpaceBuilder.yearOfBuilding;
            Use = commercialSpaceBuilder.use;
            Parking = commercialSpaceBuilder.parking;
        }

        public class CommercialSpaceBuilder
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
            public int yearOfBuilding;
            public string use;
            public bool parking;

            public CommercialSpaceBuilder Id(int id)
            {
                this.id = id;
                return this;
            }

            public CommercialSpaceBuilder SerialNumber(string serialNumber)
            {
                this.serialNumber = serialNumber;
                return this;
            }

            public CommercialSpaceBuilder Area(string area)
            {
                this.area = area;
                return this;
            }

            public CommercialSpaceBuilder Description(string description)
            {
                this.description = description;
                return this;
            }

            public CommercialSpaceBuilder District(string district)
            {
                this.district = district;
                return this;
            }

            public CommercialSpaceBuilder Image(string image)
            {
                this.image = image;
                return this;
            }

            public CommercialSpaceBuilder ImageThumbnail(string imageThumbnail)
            {
                this.imageThumbnail = imageThumbnail;
                return this;
            }

            public CommercialSpaceBuilder Parking(bool parking)
            {
                this.parking = parking;
                return this;
            }

            public CommercialSpaceBuilder Place(string place)
            {
                this.place = place;
                return this;
            }

            public CommercialSpaceBuilder Price(decimal price)
            {
                this.price = price;
                return this;
            }

            public CommercialSpaceBuilder Street(string street)
            {
                this.street = street;
                return this;
            }

            public CommercialSpaceBuilder Use(string use)
            {
                this.use = use;
                return this;
            }

            public CommercialSpaceBuilder YearOfBuilding(int yearOfBuilding)
            {
                this.yearOfBuilding = yearOfBuilding;
                return this;
            }

            public CommercialSpace Build()
            {
                return new CommercialSpace(this);
            }
        }
    }
}
