using System;
using LABA333.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace LABA333.Repository
{
    public class OrderStorage
    {
        private Dictionary<int, Order> Orders { get; } = new Dictionary<int, Order>();

        public void Create(Order order)
        {
            Orders.Add(order.id_client, order);
        }

        public Order Read(int id_client)
        {
            return Orders[id_client];
        }

        public Order Update(int id_client, Order newOrder)
        {
            Orders[id_client] = newOrder;
            return Orders[id_client];
        }

        public bool Delete(int id_сlient)
        {
            return Orders.Remove(id_сlient);
        }
    }
}