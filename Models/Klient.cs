﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LABA333.Models
{
    public class Klient

    {
        public int Id_klient { get; set; }
        public string name { get; set; } = string.Empty;

        public string email { get; set; } = string.Empty;

        public int phone_number { get; set; }

        public string address { get; set; } = string.Empty;



    }

}