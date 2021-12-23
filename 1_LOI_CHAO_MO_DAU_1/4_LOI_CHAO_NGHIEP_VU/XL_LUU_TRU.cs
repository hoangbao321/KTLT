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
        var danh_sach_nhan_vien = new List<XL_NHAN_VIEN>();

        // var thu_muc_du_lieu = new DirectoryInfo(HttpContext.Current.Server.MapPath("D:\\1_LOI_CHAO_MO_DAU_1\\3_LOI_CHAO_LUU_TRU_DANH_SACH\\Du_lieu_1\\"));

        var thu_muc_du_lieu = new DirectoryInfo(HttpContext.Current.Server.MapPath(".\\Du_lieu_1\\"));

        foreach (var item in thu_muc_du_lieu.GetFiles("*.json"))
        {
            var content = File.ReadAllText(item.FullName);
            var nhan_vien = JsonConvert.DeserializeObject<XL_NHAN_VIEN>(content);
            danh_sach_nhan_vien.Add(nhan_vien);
        }
        return danh_sach_nhan_vien;
    }
    public static void ghi_nhan_vien(XL_NHAN_VIEN g)
    {
        //var duong_dan = $"D:\\1_LOI_CHAO_MO_DAU_1\\2_LOI_CHAO_LUU_TRU_DOI_TUONG\\Du_lieu_1\\{g.Ma_So}.json";
        var duong_dan = HttpContext.Current.Server.MapPath($".\\Du_lieu_1\\{g.Ma_So}.json");
        StreamWriter file = new StreamWriter(duong_dan);
        string content = JsonConvert.SerializeObject(g);
        file.Write(content);
        file.Close();
    }
}
