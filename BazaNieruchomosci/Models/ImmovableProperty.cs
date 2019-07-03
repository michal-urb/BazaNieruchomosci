using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaNieruchomosci.Models
{
    public class ImmovableProperty
    {
        //public abstract int Id { get; set; }
        //public abstract string SerialNumber { get; set; }
        //public abstract decimal Price { get; set; }
        //public abstract string Area { get; set; }
        //public abstract string Description { get; set; }
        //public abstract string Street { get; set; }
        //public abstract string Place { get; set; }
        //public abstract string District { get; set; }

        public virtual int Id { get; set; }
        public virtual string SerialNumber { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string Area { get; set; }
        public virtual string Description { get; set; }
        public virtual string Street { get; set; }
        public virtual string Place { get; set; }
        public virtual string District { get; set; }
        public virtual string Image { get; set; }
        public virtual string ImageThumbnail { get; set; }
    }
}
