﻿using SeedData.Models;

namespace SeedData
{
    public static class GetData
    {
        //quary

        public static List<CustomerCategory> GetCategories()
        {
            List<CustomerCategory> categories = new List<CustomerCategory>();
            categories.Add(new CustomerCategory() { Id = 1, Name = "normal" });
            categories.Add(new CustomerCategory() { Id = 2, Name = "VIP" });
            categories.Add(new CustomerCategory() { Id = 3, Name = "Blocked" });
            return categories;
        }

        public static List<CustomerCategory> GetCategories(IEnumerable<Customer> customers)
        {
            List<CustomerCategory> categories = new List<CustomerCategory>();
            categories.Add(new CustomerCategory()
            {
                Id = 1,
                Name = "normal",
                customer = from cust in customers
                           where cust.categoryId == 1
                           select cust
            });
            categories.Add(new CustomerCategory()
            {
                Id = 2,
                Name = "VIP",
                customer = from cust in customers
                           where cust.categoryId == 2
                           select cust
            });
            categories.Add(new CustomerCategory()
            {
                Id = 3,
                Name = "Blocked",
                customer = from cust in customers
                           where cust.categoryId == 3
                           select cust
            });
            return categories;
        }

        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { id = 101, name = "Radwa Khaled", age = 21, isActive = true, joinDate = new DateTime(2022, 10, 15), categoryId = 1, spendAverage = 1500.9m, telephone = 123456789 });
            customers.Add(new Customer { id = 102, name = "Abdullah Ashraf", age = 26, isActive = false, joinDate = new DateTime(2023, 1, 3), categoryId = 1, spendAverage = 2500.9m, telephone = 987654321 });
            customers.Add(new Customer { id = 103, name = "Azza Khaled", age = 25, isActive = true, joinDate = new DateTime(2023, 5, 17), categoryId = 2, spendAverage = 3000.0m, telephone = 741852963 });
            customers.Add(new Customer { id = 104, name = "Ghada Hassan", age = 48, isActive = true, joinDate = new DateTime(2022, 8, 30), categoryId = 1, spendAverage = 4500.11m, telephone = 369852147 });
            customers.Add(new Customer { id = 105, name = "Essam Anwer", age = 48, isActive = true, joinDate = new DateTime(2023, 2, 27), categoryId = 1, spendAverage = 2000.0m, telephone = 102365214 });
            customers.Add(new Customer { id = 106, name = "Hadir Ayman mohamed", age = 18, isActive = true, joinDate = new DateTime(2022, 11, 8), categoryId = 1, spendAverage = 8110.9m, telephone = 14256363 });
            customers.Add(new Customer { id = 106, name = "Abdellrahman Ashraf", age = 18, isActive = true, joinDate = new DateTime(2022, 11, 8), categoryId = 1, spendAverage = 8110.9m, telephone = 14256363 });
            customers.Add(new Customer { id = 107, name = "Abdullrahman Ahmed", age = 31, isActive = false, joinDate = new DateTime(2022, 12, 24), categoryId = 1, spendAverage = 1900.0m, telephone = 259874689 });
            customers.Add(new Customer { id = 107, name = "Mayar mostafa", age = 31, isActive = false, joinDate = new DateTime(2022, 12, 24), categoryId = 1, spendAverage = 1900.0m, telephone = 259874689 });
            customers.Add(new Customer { id = 108, name = "Salim Mohamed", age = 3, isActive = true, joinDate = new DateTime(2023, 4, 8), categoryId = 2, spendAverage = 1800.4m, telephone = 123698789 });
            customers.Add(new Customer { id = 109, name = "Merna Hazem", age = 25, isActive = false, joinDate = new DateTime(2023, 10, 31), categoryId = 1, spendAverage = 1250.6m, telephone = 121111189 });
            customers.Add(new Customer { id = 110, name = "mona samir", age = 29, isActive = true, joinDate = new DateTime(2023, 8, 18), categoryId = 1, spendAverage = 1854.9m, telephone = 122222289 });
            customers.Add(new Customer { id = 111, name = "ahmed abdullah ahmed", age = 37, isActive = true, joinDate = new DateTime(2023, 7, 12), categoryId = 2, spendAverage = 9632.2m, telephone = 123333339 });
            customers.Add(new Customer { id = 112, name = "donia samir", age = 88, isActive = true, joinDate = new DateTime(2023, 11, 13), categoryId = 4, spendAverage = 9632.2m, telephone = 123333339 });
            return customers;
        }

        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            return orders;
        }
    }
}
