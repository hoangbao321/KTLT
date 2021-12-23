using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class XL_NGHIEP_VU
{
    public static string Tao_loi_chao_tat_ca()
    {
        var Loi_chao = "loi chao tat ca moi nguoi";
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
        var ngay = DateTime.Now;
        nhan_vien.danh_sach_lan_dang_nhap.Add(ngay);

        var list_ngay_dang_nhap = "";
        nhan_vien.danh_sach_lan_dang_nhap.ForEach(thanh_phan => list_ngay_dang_nhap += thanh_phan + " ");
        var Loi_Chao = $"Xin chao nhan vien: {nhan_vien.Ho_ten}<br>So lan dang nhap la: {nhan_vien.danh_sach_lan_dang_nhap.Count} <br> " +
            $"danh sach dang nhap: {list_ngay_dang_nhap}";
        return Loi_Chao;
    }
    //public static bool kiem_tra_hop_le_khach_hang (string ho_ten, out string Loi_Chao )
    //{
    //    Loi_Chao = "";
    //    var hop_le = ho_ten.Trim() != "";
    //    if( hop_le )
    //    {
    //        Loi_Chao = "Xin chào: bố mày là số 1 " + ho_ten;
    //    }
    //    return hop_le;
    //}
    public static bool kiem_tra_hop_le_khach_hang(string ho_ten, ref string Loi_chao)
    {
        var hop_le = ho_ten != ""; // khác null là sai "" ko phải là null
        if (hop_le)
        {
            Loi_chao = $"Xin chào: {ho_ten} ";
        }
        return hop_le;
    }
}
