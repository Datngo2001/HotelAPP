using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace HotelAPP
{
    public partial class Customer
    {
        HotelDB hotelDB = new HotelDB();

        public Customer getByID(int id)
        {
            hotelDB = new HotelDB();
            try
            {
                Customer customer = (from c in hotelDB.Customers
                                     where c.id == id
                                     select c).First();
                return customer;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Customer> getAllCustomer()
        {
            try
            {
                var list = (from c in hotelDB.Customers
                            select c).ToList();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool addCustomer(Customer customer)
        {
            try
            {
                hotelDB.Customers.Add(customer);
                hotelDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool deleteCustomer(int id)
        {
            try
            {
                Customer customer = (from c in hotelDB.Customers
                                     where c.id == id
                                     select c).First();
                hotelDB.Customers.Remove(customer);
                hotelDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool editCustomer(Customer customer)
        {
            try 
            {
                var newCustomer = hotelDB.Customers.Single(c => c.id == customer.id);
                newCustomer.fname = customer.fname;
                newCustomer.lname = customer.lname;
                newCustomer.gender = customer.gender;
                newCustomer.bdate = customer.bdate;
                newCustomer.phone = customer.phone;
                newCustomer.address = customer.address;
                newCustomer.roomID = customer.roomID;
                newCustomer.dayIn = customer.dayIn;
                newCustomer.dayOut = customer.dayOut;
                newCustomer.number = customer.number;
                hotelDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
