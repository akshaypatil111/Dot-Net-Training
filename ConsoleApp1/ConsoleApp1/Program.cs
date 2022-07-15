using Azure;
using Azure.Data.Tables;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new TableClient(new Uri("https://levelll.table.core.windows.net"), "table1", new TableSharedKeyCredential("levelll", "3A3CSahUbol4nV8pIy+6U6DXi3V5rvB80UJq7KGBnyVATxzsGWktzsp98S+NGqlFWP546L8TIEKO+AStIpzZ/w=="));
            Pageable<TableEntity> queryableTable = client.Query<TableEntity>();
            foreach (TableEntity item in queryableTable)
            {
                Console.WriteLine(item.GetString("Name"));
            }
        }
    }
}