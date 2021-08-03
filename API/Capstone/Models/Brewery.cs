﻿using Capstone.Models;

namespace Capstone.Models
{
    public class Brewery
    {
        public int BreweryId { get; set; }
        public string BreweryName { get; set; }
        public int BreweryAddressId { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string History { get; set; }
        public string DateEstablished { get; set; }       
    }
}

