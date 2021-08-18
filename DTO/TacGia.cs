﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSach.DTO
{
    [Table("TacGia")]
    public class TacGia
    {
        public TacGia()
        {
            Sachs = new HashSet<Sach>();
        }

        [Key]
        public int ID_TacGia { get; set; }
        public string TenTacGia { get; set; }

        public virtual ICollection<Sach> Sachs { get; set; }
    }
}
