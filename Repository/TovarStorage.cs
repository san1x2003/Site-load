using System;
using LABA333.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace LABA333.Repository
{
    public class TovarStorage
    {
        private Dictionary<int, Tovar> Tovars { get; } = new Dictionary<int, Tovar>();

        public void Create(Tovar Tovar)
        {
            Tovars.Add(Tovar.Id_product, Tovar);
        }

        public Tovar Read(int id_product)
        {
            return Tovars[id_product];
        }

        public Tovar Update(int id_product, Tovar newTovar)
        {
            Tovars[id_product] = newTovar;
            return Tovars[id_product];
        }

        public bool Delete(int id_product)
        {
            return Tovars.Remove(id_product);
        }
    }
}