using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class XL_THE_HIEN
{
    public static string Chuoi_HTML_danh_sach_nhom_hang(XL_NHOM_HANG hang)
    {
        var chuoi = $"<br> <b>{hang.ten}</b> <br>"
                   + $"<br> <img src='HINH/{hang.ma_so}.jpg' width='100' height='50'/><br>";
        return chuoi;
    }
    public static string Chuoi_HTML_nhan_vien(XL_NHAN_VIEN nhan_vien, string Loi_chao)
    {
        var Chuoi_HTML_LOI_CHAO = $"<div>{Loi_chao} <br> Day la ung dung <b>web luu tru doi tuong</b> dau tien cua toi </div>"
             + $"<img src = 'HINH/{nhan_vien.Ma_So}.jpg' width='100' height='100'/><br>" ;
        return Chuoi_HTML_LOI_CHAO;
    }
    public static string Chuoi_HTML_hinh_anh_khach_hang_random(string Loi_chao)
    {
        var n = XL_NGHIEP_VU.So_random(0, 4);
        var Chuoi_HTML_LOI_CHAO = $"<img src='HINH/NGUOI_DUNG_{n}.jpg' width='200' height='100'/><br><h3>{Loi_chao}</h3>" +
            $"<br/>Đây là trang <b>web nghiệp vụ 2 </b> của tôi </br > Danh sách các nhóm hàng hiện nay ";
        return Chuoi_HTML_LOI_CHAO;
    }

}
