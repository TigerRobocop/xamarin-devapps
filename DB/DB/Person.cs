using System;
using SQLite;

namespace DB
{
    [Table("Person")]
    public class Person
    {
        [Column("Id")]
        public int Id
        {
            get;
            set;
        }
        [Column("Name")]
        public string Name
        {
            get;
            set;
        }
        [Column("City")]
        public string City
        {
            get;
            set;
        }
    }
}
