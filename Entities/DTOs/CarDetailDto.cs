﻿using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string Colorname { get; set; }
        public int DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public List<CarImage> CarImages { get; set; }
    }
}
