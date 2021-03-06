﻿using System.ComponentModel.DataAnnotations;

namespace FunTourDataLayer.Locality
{
    public class City
    {
        [Key]
        public int Id_City { get; set; }

        public string Name { get; set; }

        public string CP { get; set; }

        public Province Province { get; set; }
    }
}
