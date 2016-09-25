using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Rooms
{
    public class RoomStandart
    {
        private List<Table> tables = new List<Table>();
        public List<Table> Tables { get { return tables; } set { tables = value; } }
        public RoomStandart()
        {
            Table table1 = new Table("First", true, 4);
            Table table2 = new Table("Second", true, 8);
            Tables.Add(table1);
            Tables.Add(table2);
        }
        public int ChooseFreeTable()
        {
            int counter = 0;
            foreach (Table table in this.Tables)
            {
                counter++;
                if (table.IsVacant)
                {
                    Console.WriteLine("Table № {0} choosed by Client", table.NameOfTable);
                    table.IsVacant = false;
                    return counter;
                }
            }
            return 0;
        }
    }
}
