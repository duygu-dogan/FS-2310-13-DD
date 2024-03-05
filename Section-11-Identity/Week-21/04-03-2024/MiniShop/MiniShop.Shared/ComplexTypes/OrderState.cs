﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.ComplexTypes
{
    public enum OrderState
    {
        [Display(Name ="Sipariş alındı")]
        Recieved=0,
        [Display(Name = "Hazırlanıyor")]
        Preparing = 1,
        [Display(Name = "Sipariş gönderildi")]
        Sent = 2,
        [Display(Name = "Sipariş teslim edildi")]
        Delivered = 3
    }
}
