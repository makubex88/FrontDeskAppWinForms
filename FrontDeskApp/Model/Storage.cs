using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDeskApp.Model
{
    public class Storage
    {
        public int Id { get; set; }
        public string StorageName { get; set; }
        public int CurrentOccupiedSmallStorage { get; set; }
        public int CurrentOccupiedMediumStorage { get; set; }
        public int CurrentOccupiedLargeStorage { get; set; }
        public int TotalOfSmallStorage { get; set; }
        public int TotalOfMediumStorage { get; set; }
        public int TotalOfLargeStorage { get; set; }
    }
}
