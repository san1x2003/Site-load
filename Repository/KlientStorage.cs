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

        public Klient Read(int Id)
        {
            return Klients[Id];
        }

        public Klient Update(int Id, Klient newKlient)
        {
            Klients[Id] = newKlient;
            return Klients[Id];
        }

        public bool Delete(int Id)
        {
            return Klients.Remove(Id);
        }
    }
}