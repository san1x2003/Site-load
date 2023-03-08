using System.ComponentModel.DataAnnotations;

namespace LABA333.Models
{
    public class Order
    {
        [Key]
        public int id_client { get; set; }

        public int id_post { get; set; }

        public int id_warehouse { get; set; }

        public int id_product { get; set; }

        public int id_order { get; set; }

        public int number_contract { get; set; }

        public DateTime date_of_execution { get; set; }

        public string address { get; set; }

        public int EmployeeId { get; set; }


    }

}