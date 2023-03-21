using System;
using LABA333.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace LABA333.Repository
{
    public class SkladStorage
    {
        private Dictionary<int, Sklad> Sklads { get; } = new Dictionary<int, Sklad>();

        public void Create(Sklad Sklad)
        {
            Sklads.Add(Sklad.Id_sklad, Sklad);
        }

        public Sklad Read(int Id_sklad)
        {
            return Sklads[Id_sklad];
        }

        public Sklad Update(int Id_sklad, Sklad newSklad)
        {
            Sklads[Id_sklad] = newSklad;
            return Sklads[Id_sklad];
        }

        public bool Delete(int Id_sklad)
        {
            return Sklads.Remove(Id_sklad);
        }
    }
}