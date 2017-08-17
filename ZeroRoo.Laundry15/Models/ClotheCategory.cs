using System;
using System.Collections.Generic;
using Laundry.LibCore.Models;

namespace Laundry.LibCore.Models
{
    public class ClotheCategory
    {
        public int ID { get; set; }

        public string Text { get; set; }

        public List<Price> ClotheInfos { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}