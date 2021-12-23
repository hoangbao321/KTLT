using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

public class XL_LUU_TRU
{
    public static XL_NHAN_VIEN doc_nhan_vien(string ma_so)
    {
        var nhan_vien = (XL_NHAN_VIEN)null; // phải có cái này nếu cái điều kiện hợp lệ nằm ngoài if Request POST
        //var duong_dan = $"D:\\1_LOI_CHAO_MO_DAU_1\\2_LOI_CHAO_LUU_TRU_DOI_TUONG\\Du_lieu_1\\{ma_so}.json"; //ok
        var duong_dan = HttpContext.Current.Server.MapPath($".\\Du_lieu_1\\{ma_so}.json");
        if (File.Exists(duong_dan))
        {
            StreamReader file = new StreamReader(duong_dan);
            string Chuoi_luu_tru = file.ReadLine();
            nhan_vien = JsonConvert.DeserializeObject<XL_NHAN_VIEN>(Chuoi_luu_tru);
            file.Close();
        }
        return nhan_vien;
    }

    //public static XL_NHAN_VIEN doc_nhan_vien(string ma_so)
    //{
    //    var nhan_vien = (XL_NHAN_VIEN)null;
    //    var duong_dan = HttpContext.Current.Server.MapPath($".\\Du_lieu_1\\{ma_so}.json");
    //    if (File.Exists(duong_dan))
    //    {
    //        nhan_vien = new XL_NHAN_VIEN() ;
    //        var Chuoi_luu_tru = File.ReadAllText(duong_dan);
    //        var Xu_ly = new JavaScriptSerializer();
    //        nhan_vien = (XL_NHAN_VIEN)Xu_ly.Deserialize(Chuoi_luu_tru, nhan_vien.GetType());
    //    }
    //    return nhan_vien;
    //}

    public static void ghi_nhan_vien(XL_NHAN_VIEN g)
    {
        //var duong_dan = $"D:\\1_LOI_CHAO_MO_DAU_1\\2_LOI_CHAO_LUU_TRU_DOI_TUONG\\Du_lieu_1\\{g.Ma_So}.json";
        var duong_dan = HttpContext.Current.Server.MapPath($".\\Du_lieu_1\\{g.Ma_So}.json");
        StreamWriter file = new StreamWriter(duong_dan);
        string content = JsonConvert.SerializeObject(g);
        file.Write(content);
        file.Close();
    }

    //public static void ghi_nhan_vien(XL_NHAN_VIEN nhan_vien)
    //{
    //    var Xu_ly = new JavaScriptSerializer();
    //    var Chuoi_luu_tru = Xu_ly.Serialize(nhan_vien);
    //    var Duong_dan = HttpContext.Current.Server.MapPath($".\\Du_lieu_1\\{nhan_vien.Ma_So}.json");
    //    File.WriteAllText(Duong_dan, Chuoi_luu_tru);
    //}

}
