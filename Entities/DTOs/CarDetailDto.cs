﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.DTOs
{
   public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public string ModelYear { get; set; }
        public string Descriptions { get; set; }
    }
}
