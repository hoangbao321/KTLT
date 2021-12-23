using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

public class XL_LUU_TRU
{

    public static List<XL_NHOM_HANG> doc_nhom_hang()
    {
        //D:\1_LOI_CHAO_MO_DAU_1\4_LOI_CHAO_NGHIEP_VU_2\Du_lieu_1
        //var danh_sach_nhom_hang = new List<XL_NHOM_HANG>();
        //var duong_dan = HttpContext.Current.Server.MapPath(".\\Du_lieu_1\\");
        //var thu_muc_loai_hang = new DirectoryInfo(duong_dan);
        //foreach ( var  item in thu_muc_loai_hang.GetFiles("*.json"))
        //{
        //    var content = File.ReadAllText(item.FullName);
        //    var hang_hoa = JsonConvert.DeserializeObject<XL_NHOM_HANG>(content);
        //    danh_sach_nhom_hang.Add(hang_hoa);
        //}
        //return danh_sach_nhom_hang;

        var danh_sach_nhom_hang = new List<XL_NHOM_HANG>();
        var thu_muc_du_lieu = new DirectoryInfo( HttpContext.Current.Server.MapPath(".\\Du_lieu_1\\"));
        var du_lieu = thu_muc_du_lieu.GetDirectories("Nhom_hang")[0];
        //D:\1_LOI_CHAO_MO_DAU_1\4_LOI_CHAO_NGHIEP_VU_2\Du_lieu_1\Nhom_hang
        foreach (var item in du_lieu.GetFiles("*.json"))
        {
            var content = File.ReadAllText(item.FullName);
            
            var hang_hoa = JsonConvert.DeserializeObject<XL_NHOM_HANG>(content);
            danh_sach_nhom_hang.Add(hang_hoa);
        }
        return danh_sach_nhom_hang;
    }
    public static List<XL_NHAN_VIEN> doc_nhan_vien()
    {
        //var danh_sach_nhan_vien = new List<XL_NHAN_VIEN>();
        //var duong_dan = HttpContext.Current.Server.MapPath(".\\Du_lieu_1\\");
        ////D:\1_LOI_CHAO_MO_DAU_1\4_LOI_CHAO_NGHIEP_VU_2\Du_lieu_1\\
        //var thu_muc_nhan_vien = new DirectoryInfo(duong_dan);
        //foreach (var item in thu_muc_nhan_vien.GetFiles("*.json"))
        //{
        //    var content = File.ReadAllText(item.FullName);
        //    var nhan_vien = JsonConvert.DeserializeObject<XL_NHAN_VIEN>(content);
        //    danh_sach_nhan_vien.Add(nhan_vien);
        //}
        //return danh_sach_nhan_vien;

        var danh_sach_nhan_vien = new List<XL_NHAN_VIEN>();
        var thu_muc_du_lieu = new DirectoryInfo(HttpContext.Current.Server.MapPath(".\\Du_lieu_1\\"));
        var du_lieu = thu_muc_du_lieu.GetDirectories("Nhan_vien")[0];
        foreach (var item in du_lieu.GetFiles("*.json"))
        {
            var content = File.ReadAllText(item.FullName);
            var nhan_vien = JsonConvert.DeserializeObject<XL_NHAN_VIEN>(content);
            danh_sach_nhan_vien.Add(nhan_vien);
        }
        return danh_sach_nhan_vien;
    }
    public static void ghi_nhan_vien(XL_NHAN_VIEN nhan_vien)
    {
        var duong_dan = HttpContext.Current.Server.MapPath($".\\Du_lieu_1\\Nhan_Vien\\{nhan_vien.Ma_So}.json");
        StreamWriter file = new StreamWriter(duong_dan);
        var content = JsonConvert.SerializeObject(nhan_vien);
        file.WriteLine(content);
        file.Close();
    }


}
