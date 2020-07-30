using System.Collections.Generic;

namespace DataBase
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
        public virtual ICollection<Price> Prices { get; set; } = new List<Price>();
    }
}