﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity
{
  public  class standard_details
    {
        public int Id { get; set; }
        public string standard_id { get; set; }
        public string standard_name { get; set; }
        public int? item_id { get; set; }
        public string item_name { get; set; }
        public double? salary { get; set; }
    }
}
