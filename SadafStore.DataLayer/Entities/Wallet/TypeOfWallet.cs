﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SadafStore.DataLayer.Entities.Wallet
{
    public class TypeOfWallet
    {
        public TypeOfWallet()
        {

        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [Required]
        [MaxLength(150)]
        public string TypeTitle { get; set; }

        #region Relations
        public virtual List<Wallet> Wallets { get; set; }
        #endregion
    }
}
