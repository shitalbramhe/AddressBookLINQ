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
            var AddressTable = from data in datatable.AsEnumerable() select data;
            foreach (DataRow item in AddressTable)
            {
                Console.WriteLine(item.Field<string>("firstname") + " " + item.Field<string>("lastname") + " " + item.Field<string>("address") + " " + item.Field<string>("city") + " " + item.Field<string>("state") + " " + item.Field<int>("zip") + " " + item.Field<long>("phonenumber") + " " + item.Field<string>("email"));
            }
        }
    }
}
