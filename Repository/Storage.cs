using LABA333.Repository;
using System;


namespace LABA333.Repository
{
    public static class Storage
    {
        public static EmployeeStorage EmployeeStorage { get; } = new EmployeeStorage();
        public static OrderStorage OrderStorage { get; } = new OrderStorage();

    }
}
