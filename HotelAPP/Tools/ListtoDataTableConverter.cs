using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPP.Tools
{
    public class ListtoDataTableConverter

    {
        public DataTable ToDataTable<T>(List<T> items)

        {

            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in Props)

            {

                //Setting column names as Property names

                dataTable.Columns.Add(prop.Name);

            }

            foreach (T item in items)

            {
                var row = dataTable.Rows.Add();

                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows

                    if (Props[i].PropertyType == typeof(byte[]))
                    {
                        row.ItemArray[i] = new ImageTool().ByteArrToImage((byte[])Props[i].GetValue(item, null));
                    }
                    else
                    {
                        row.ItemArray[i] = Props[i].GetValue(item, null);
                    }
                }
            }

            //put a breakpoint here and check datatable

            return dataTable;

        }

    }
}
