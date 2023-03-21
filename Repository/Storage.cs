using LABA333.Controllers;
using LABA333.Repository;
using System;


namespace LABA333.Repository
{
    public static class Storage
    {
        public static EmployeeStorage EmployeeStorage { get; } = new EmployeeStorage();
        public static OrderStorage OrderStorage { get; } = new OrderStorage();

        public static PostStorage PostStorage { get; } = new PostStorage();
        public static KlientStorage KlientStorage { get; } = new KlientStorage();
        public static Number_zakazaStorage Number_zakazaStorage { get; } = new Number_zakazaStorage();
        public static SkladStorage SkladStorage { get; } = new SkladStorage();
        public static TovarStorage TovarStorage { get; } = new TovarStorage();
    }
}
