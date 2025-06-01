using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abpcqrstest.Items
{
    public class Item : Entity<int>
    {
        public string Name { get; set; }
    }
}
