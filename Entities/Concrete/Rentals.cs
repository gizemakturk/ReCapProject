using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    class Rentals:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public int CarId { get; set; }
        public DateTime? RentDate { get; set; }
        //soru işareti null olması için
        public DateTime ReturnDate { get; set; }
        

    }
}
