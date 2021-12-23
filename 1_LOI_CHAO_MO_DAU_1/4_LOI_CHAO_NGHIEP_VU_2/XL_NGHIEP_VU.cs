using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

public class XL_NGHIEP_VU
{
    public static string Tao_loi_chao_tat_ca()
    {
        var Loi_chao = "Xin chao tat ca Khách hàng";
        return Loi_chao;
    }
    public static int So_random(int max, int min )
    {
        var rand = new Random();
        var n = rand.Next(max, min);
        return n;
    }
    public static string Tao_loi_chao_khach_hang(string ho_ten)
    {
        var Loi_chao = $"Xin chào: {ho_ten}";
        return Loi_chao;
    }
    public static XL_NHAN_VIEN nhan_vien(List<XL_NHAN_VIEN> danh_sach_nhan_vien, string ma_so)
    {
        var nhan_vien = danh_sach_nhan_vien.FirstOrDefault(thanh_phan => thanh_phan.Ma_So == ma_so);
        return nhan_vien;
    }

    public static string tao_loi_chao_nhan_vien(XL_NHAN_VIEN nhan_vien)
    {
        //nhan_vien.danh_sach_lan_dang_nhap.Add(DateTime.Now);
        //var list_ngay_dang_nhap = "";
        //nhan_vien.danh_sach_lan_dang_nhap.ForEach(thanh_phan => list_ngay_dang_nhap += thanh_phan + " ");
        //var Loi_Chao = $"Xin chao nhan vien: {nhan_vien.Ho_ten}<br>So lan dang nhap la: " +
        //    $"{nhan_vien.danh_sach_lan_dang_nhap.Count} <br>" +
        //    $"danh sach dang nhap: <br>{list_ngay_dang_nhap}</br>";
        //return Loi_Chao;

        var list_ngay_dang_nhap = "";
        nhan_vien.danh_sach_lan_dang_nhap.ForEach(thanh_phan => list_ngay_dang_nhap += thanh_phan + " ");
        var Loi_Chao = $"Xin chao nhan vien: {nhan_vien.Ho_ten}<br>So lan dang nhap la: " +
            $"{nhan_vien.danh_sach_lan_dang_nhap.Count} <br>" +
            $"danh sach dang nhap: <br>{list_ngay_dang_nhap}</br>";
        return Loi_Chao;
    }
    // Lưu ý nếu là out thì thì trên dòng var hop_le phải có Loi_chao = "";
    public static bool kiem_tra_hop_le_khach_hang(string ho_ten, ref string Loi_chao)
    {
        var hop_le = ho_ten != "";
        if (hop_le)
        {
            Loi_chao = $"Xin chào: {ho_ten} ";
        }
        return hop_le;
    }
    ////in ra sản phẩm nhân viên phụ trách - cách bảo
    //public static List<XL_NHOM_HANG> tao_danh_sach_nhom_hang_duoc_phan_cong(XL_NHAN_VIEN nhan_vien)
    //{
    //    var danh_sach_nhom_hang = new List<XL_NHOM_HANG>(); // của nhân viên 
    //    var thu_muc_du_lieu = new DirectoryInfo(HttpContext.
    //        Current.Server.MapPath($".\\Du_lieu_1\\"));
    //    var du_lieu = thu_muc_du_lieu.GetDirectories("Nhom_hang")[0];
    //    //D:\1_LOI_CHAO_MO_DAU_1\4_LOI_CHAO_NGHIEP_VU_2\Du_lieu_1\Nhom_hang

    //    //for (int i = 0; i < nhan_vien.danh_sach_ma_so_nhom_hang.Count; i++)
    //    //{
    //    //    foreach (var item_1 in du_lieu.GetFiles($"{nhan_vien.danh_sach_ma_so_nhom_hang[i]}.json"))
    //    //    {
    //    //        var content = File.ReadAllText(item_1.FullName);
    //    //        var hang_hoa = JsonConvert.DeserializeObject<XL_NHOM_HANG>(content);
    //    //        danh_sach_nhom_hang.Add(hang_hoa);
    //    //    }
    //    //}
    //    foreach( var item in nhan_vien.danh_sach_ma_so_nhom_hang)
    //    {
    //        foreach (var item_1 in du_lieu.GetFiles($"{item}.json"))
    //        {
    //            var content = File.ReadAllText(item_1.FullName);
    //            var hang_hoa = JsonConvert.DeserializeObject<XL_NHOM_HANG>(content);
    //            danh_sach_nhom_hang.Add(hang_hoa);
    //        }
    //    }
    //    return danh_sach_nhom_hang;
    //}

    public static List<XL_NHOM_HANG> tao_danh_sach_nhom_hang_duoc_phan_cong(XL_NHAN_VIEN nhan_vien, List<XL_NHOM_HANG>
        danh_sach_nhom_hang)
    {
        //var danh_sach_phan_cong = new List<XL_NHOM_HANG>();
        //foreach (var  item in nhan_vien.danh_sach_ma_so_nhom_hang)
        //{
        //    var san_pham= danh_sach_nhom_hang.FirstOrDefault(hang => hang.ma_so==item );
        //    danh_sach_phan_cong.Add(san_pham);
        //}
        //return danh_sach_phan_cong;

        // dùng Findindex 
        ////var danh_sach_phan_cong = new List<XL_NHOM_HANG>();
        ////foreach (var item in nhan_vien.danh_sach_ma_so_nhom_hang)
        ////{
        ////    var hang = danh_sach_nhom_hang.FindIndex(thanh_phan => thanh_phan.ma_so == item);
        ////    danh_sach_phan_cong.Add(danh_sach_nhom_hang[hang]);
        ////}
        ////return danh_sach_phan_cong;

        var danh_sach_phan_cong = new List<XL_NHOM_HANG>();
        nhan_vien.danh_sach_ma_so_nhom_hang.ForEach(thanh_phan =>
        {
            var Nhom_hang =danh_sach_nhom_hang.FirstOrDefault(thanh_phan_1 => thanh_phan_1.ma_so == thanh_phan);
            danh_sach_phan_cong.Add(Nhom_hang);
        });
        return danh_sach_phan_cong;
    }
    public static XL_NHAN_VIEN dang_nhap_nhan_vien(List<XL_NHAN_VIEN> danh_sach_nhan_vien, string ten_dang_nhap, string mat_khau)
    {
        //// nếu ko có chữ null sẽ tạo thành file .json 
        //var nhan_vien_1 = (XL_NHAN_VIEN)null;
        //foreach ( var  nv  in danh_sach_nhan_vien)
        //{
        //    if(nv.ten_dang_nhap==ten_dang_nhap && nv.mat_khau==mat_khau)
        //    {
        //         nhan_vien_1 = nv;
        //    }
        //}
        //return nhan_vien_1;

        var nhan_vien = danh_sach_nhan_vien.FirstOrDefault(thanh_phan =>  thanh_phan.ten_dang_nhap == ten_dang_nhap && 
        thanh_phan.mat_khau == mat_khau );
        if (nhan_vien != null)
        {
            nhan_vien.danh_sach_lan_dang_nhap.Add(DateTime.Now);
        }
        return nhan_vien;
    }

}
