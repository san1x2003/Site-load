using System;
using LABA333.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace LABA333.Repository
{
    public class KlientStorage
    {
        private Dictionary<int, Klient> Klients { get; } = new Dictionary<int, Klient>();

        public void Create(Klient Klient)
        {
            Klients.Add(Klient.Id_klient, Klient);
        }

        public Klient Read(int Id_klient)
        {
            return Klients[Id_klient];
        }

        public Klient Update(int Id_klient, Klient newKlient)
        {
            Klients[Id_klient] = newKlient;
            return Klients[Id_klient];
        }

        public bool Delete(int Id_klient)
        {
            return Klients.Remove(Id_klient);
        }
    }
}