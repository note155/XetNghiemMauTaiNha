﻿using System.ComponentModel.DataAnnotations;

namespace duanxetnghiem.Data.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public string? CapHuyen { get; set; }
        public string? CapXa { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public bool Gioitinh { get; set; }
        public DateTime Ngaysinh {  get; set; }
        public string? Quanhe {  get; set; }
    }
}
