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
        public void AddDataTable()
        {
            datatable.Columns.Add("firstname");
            datatable.Columns.Add("lastname");
            datatable.Columns.Add("address");
            datatable.Columns.Add("city");
            datatable.Columns.Add("state");
            datatable.Columns.Add("zip").DataType = typeof(Int32);
            datatable.Columns.Add("phonenumber").DataType = typeof(Int32);
            datatable.Columns.Add("email"); 
        }
    }
}
