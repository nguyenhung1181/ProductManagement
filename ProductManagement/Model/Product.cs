using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Model
{
    public class Product
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string AvatarPath { get; set; }
    }

    public class Icons
    {
        public string IconPath { get; set; }
    }
}
