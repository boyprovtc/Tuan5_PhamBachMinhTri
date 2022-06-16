﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tuan5_PhamBachMinhTri.Models;
namespace Tuan5_PhamBachMinhTri.Models
{
    public class Giohang
    {
        MyDataDataContext data = new MyDataDataContext();
        public int masach { get; set; }

        [Display(Name = "Ten sach")]
        public string tensach { get; set; }
        [Display(Name = "Anh bia")]
        public string hinh { get; set; }

        [Display(Name = "Gia Ban")]
        public string giaban { get; set; }

        [Display(Name = "So luong")]
        public string iSoluong { get; set; }
        [Display(Name = "Thanh tien")]
        public Double dThanhtien
        {
            get { return iSoluong * giaban; }
        }
        public Giohang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            iSoluong = 1;
        }
    }
}