using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Martin_Manuel_Lab6.Models

{
    public class ShopList
    {
        [PrimaryKey,AutoIncrement]
        public int ID{get; set;}
        public string Description {get; set;}
        public DateTime Date {get; set;}
    }
}
