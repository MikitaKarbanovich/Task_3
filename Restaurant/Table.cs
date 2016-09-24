using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Rooms
{
    class Table
    {
        public string NameOfTable { get; set; }
        public bool IsVacant { get; set; }
        public int NumberOfSeats { get; set; }
        public Table(string nameOfTable, bool isVacant, int numberOfSeats)
        {
            NameOfTable = nameOfTable;
            IsVacant = isVacant;
            NumberOfSeats = numberOfSeats;
        }
    }
}
