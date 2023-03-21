using System;
using LABA333.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace LABA333.Repository
{
    public class Number_zakazaStorage
    {
        private Dictionary<int, Number_zakaza> Number_zakazas { get; } = new Dictionary<int, Number_zakaza>();

        public void Create(Number_zakaza Number_zakaza)
        {
            Number_zakazas.Add(Number_zakaza.number_zakaz, Number_zakaza);
        }

        public Number_zakaza Read(int number_zakaz)
        {
            return Number_zakazas[number_zakaz];
        }

        public Number_zakaza Update(int number_zakaz, Number_zakaza newNumber_zakaza)
        {
            Number_zakazas[number_zakaz] = newNumber_zakaza;
            return Number_zakazas[number_zakaz];
        }

        public bool Delete(int number_zakaz)
        {
            return Number_zakazas.Remove(number_zakaz);
        }
    }
}