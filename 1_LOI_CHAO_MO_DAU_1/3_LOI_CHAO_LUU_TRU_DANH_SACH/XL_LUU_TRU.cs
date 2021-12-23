using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

public class XL_LUU_TRU
{
    public static List<XL_NHAN_VIEN> doc_nhan_vien()
    {
        var nhan_vien = new List<XL_NHAN_VIEN>();
        //var duong_dan = $"D:\\1_LOI_CHAO_MO_DAU_1\\3_LOI_CHAO_LUU_TRU_DANH_SACH\\Du_lieu_1\\danh_sach_nhan_vien.json"; //ok
        var duong_dan = HttpContext.Current.Server.MapPath($".\\Du_lieu_1\\danh_sach_nhan_vien.json");
        if (File.Exists(duong_dan))
        {
            StreamReader file = new StreamReader(duong_dan);
            string Chuoi_luu_tru = file.ReadLine();
            nhan_vien = JsonConvert.DeserializeObject< List<XL_NHAN_VIEN> >(Chuoi_luu_tru);
            file.Close();
        }
        return nhan_vien;
    }
    public static void ghi_nhan_vien(List<XL_NHAN_VIEN> g)
    {
        //var duong_dan = $"D:\\1_LOI_CHAO_MO_DAU_1\\3_LOI_CHAO_LUU_TRU_DANH_SACH\\Du_lieu_1\\danh_sach_nhan_vien.json";
        var duong_dan = HttpContext.Current.Server.MapPath($".\\Du_lieu_1\\danh_sach_nhan_vien.json");
        StreamWriter file = new StreamWriter(duong_dan);
        string content = JsonConvert.SerializeObject(g);
        file.Write(content);
        file.Close(); 
    }
}
