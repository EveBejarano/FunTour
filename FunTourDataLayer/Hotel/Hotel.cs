﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FunTourDataLayer.Reservation;

namespace FunTourDataLayer.Hotel
{
    public class Hotel: IEntityToReload
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hotel()
        {
            this.TravelPackage = new HashSet<TravelPackage>();
            this.ReservedRoom = new HashSet<ReservedRoom>();
        }

        [Key]
        public int Id_Hotel { get; set; }
        public string Name { get; set; }

        public float Price { get; set; }

        public string Description { get; set; }

        public int NotReservedRooms { get; set; }
        
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TravelPackage> TravelPackage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservedRoom> ReservedRoom { get; set; }

        IEnumerable<object> IEntityToReload.DesearializeJson(string data)
        {
            throw new NotImplementedException();
        }



        IEnumerable<object> IEntityToReload.MappingJson(object APIResponse)
        {
            throw new NotImplementedException();
        }
        

        void IEntityToReload.ReLoadTable()
        {
            throw new NotImplementedException();
        }
    }
}