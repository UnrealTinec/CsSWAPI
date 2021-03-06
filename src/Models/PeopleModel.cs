﻿using System;
using System.Collections.Generic;

namespace SWAPI_TestCs.src.Models
{
    //Represents the People fromt the SWAPI listed under https://swapi.dev/api/people/
    public class PeopleModel : Model
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string Hair_color { get; set; }
        public string Skin_color { get; set; }
        public string Eye_color { get; set; }
        public string Birth_year { get; set; }
        public string Gender { get; set; }
        public string Homeworld { get; set; }
        public List<string> Films { get; set; } //List with links
        public List<string> Species { get; set; } //List with links
        public List<string> Vehicles { get; set; } //List with links
        public List<string> Starships { get; set; } //List with links
 

    }
}
