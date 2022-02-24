﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyWeb.Models
{
    [Index(nameof(OperaId), Name = "IX_Comments_OperaID")]
    public partial class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public string UserComment { get; set; }
        public DateTime LastModified { get; set; }
        [Column("OperaID")]
        public int OperaId { get; set; }

        [ForeignKey(nameof(OperaId))]
        [InverseProperty("Comments")]
        public virtual Opera Opera { get; set; }
    }
}