//Tôi cần kết nối với một databasse có Tên là DuLieu, trong đó có một table tên là CongViec, table có MaSach nvarchar(15) primary key, TenSach nText, GiaTien nvarchar(12). Hãy giúp tôi viết code kết nối với database và hiển thị dữ liệu trong table CongViec ra một DataGridView. Ngoài ra, hãy thêm chức năng thêm, sửa, xóa dữ liệu trong table CongViec thông qua các TextBox và Button trên Form.
//Để kết nối với cơ sở dữ liệu `DuLieu` và hiển thị dữ liệu từ bảng `CongViec` trong một `DataGridView`, bạn có thể sử dụng Entity Framework Core. Dưới đây là hướng dẫn chi tiết để thực hiện điều này, bao gồm các chức năng thêm, sửa, xóa dữ liệu. Hãy làm nay bên dưới
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PhamTuanHung_6551071040_VP103_LTTQ
{
    public class DuLieu_Context : DbContext
    {
        public DbSet<CongViec> CongViecs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình chuỗi kết nối đến cơ sở dữ liệu DuLieu
            optionsBuilder.UseSqlServer("Server=localhost;Database=DuLieu;Trusted_Connection=True;");
        }
    }
    public class CongViec
    {
        public string MaSach { get; set; } // nvarchar(15) primary key
        public string TenSach { get; set; } // nText
        public string GiaTien { get; set; } // nvarchar(12)
    }
}
