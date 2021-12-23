using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    public class AddressBook
    {
        DataTable datatable = new DataTable();
        public void AddDataTable(List<Contact> contactlist)
        {
            datatable.Columns.Add("firstname");
            datatable.Columns.Add("lastname");
            datatable.Columns.Add("address");
            datatable.Columns.Add("city");
            datatable.Columns.Add("state");
            datatable.Columns.Add("zip").DataType = typeof(Int32);
            datatable.Columns.Add("phonenumber").DataType = typeof(Int64);
            datatable.Columns.Add("email");
            foreach (var item in contactlist)
            {
                datatable.Rows.Add(item.firstname, item.lastname, item.address, item.city, item.state, item.zip, item.phonenumber, item.email);
            }

        }
        public void Display()
        {
            var AddressTable = from data in datatable.AsEnumerable() select data;
            foreach (DataRow item in AddressTable)
            {
                Console.WriteLine(item.Field<string>("firstname") + " " + item.Field<string>("lastname") + " " + item.Field<string>("address") + " " + item.Field<string>("city") + " " + item.Field<string>("state") + " " + item.Field<int>("zip") + " " + item.Field<long>("phonenumber") + " " + item.Field<string>("email"));
            }
        }
        public void EditExistingContact(List<Contact> contactlist)
        {
            {
                try
                {
                    string Newname = "Gita";
                    var updateData = datatable.AsEnumerable().Where(x => x.Field<string>("firstname").Equals(Newname)).FirstOrDefault();
                    if (updateData != null)
                    {
                        updateData.SetField("Phonenumber", "895478520");
                        updateData.SetField("city", "Pune");
                        Console.WriteLine("\n PhoneNumber and city of {0} updated successfully!", Newname);
                        Display();
                    }
                    else
                    {
                        Console.WriteLine("There is no such record in the Address Book!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public void DeleteContact(string Name)
        {
            try
            {
                var rowdelete = datatable.AsEnumerable().Where(a => a.Field<string>("firstname").Equals(Name)).FirstOrDefault();
                if (rowdelete != null)
                {
                    rowdelete.Delete();
                    Console.WriteLine("\nContact with name '{0}' deleted ", Name);
                    Display();
                }
                else
                {
                    Console.WriteLine("Data Not found");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void RetrievePersonUsingCity(Contact contactlist)
        {
            var selectdata = datatable.AsEnumerable().Where(a => a.Field<string>("city").Equals(contactlist.city));
            foreach (var item in datatable.AsEnumerable())
            {
                Console.WriteLine("\tfirstname:" + item.Field<string>("firstname") + "\tlastname:" + item.Field<string>("lastname")+ "\taddress:" + item.Field<string>("address")+ "\tcity:" + item.Field<string>("City")+ "\tstate:" + item.Field<string>("State")+ "\tzip:" + item.Field<int>("zip")+ "\tphonenumber:" + item.Field<long>("phonenumber")+ "\temail:" + item.Field<string>("email"));
            }

        }
    }
}
        