﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GH.DAL.Model
{
    public class StaffPosition
    {
        [Key]
        public Guid kStaffPositionId { get; set; }

        [StringLength(50)]
        public String sDescription { get; set; }

        public DateTime? dtDateAdd { get; set; }

        public DateTime? dtDateUpdate { get; set; }


        public StaffPosition()
        {
            dtDateAdd = DateTime.Now;
        }
    }
}
