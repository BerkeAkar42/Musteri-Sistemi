using DAL.Data;
using Entity.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace DAL.JSON_Data_Save
{
    internal class JSON_Katdet
    {
        string MusteriPath = @"C:\Users\Berke\Desktop\c#_Kursu\ASP.NET_CORE_WEB_API\FullProject\API\bin\Debug\net9.0\veriler.json";
        string MusteriIdPath = @"C:\Users\Berke\Desktop\c#_Kursu\ASP.NET_CORE_WEB_API\FullProject\API\bin\Debug\net9.0\musteriId.json";

        public void Save()
        {
            //Muşteri verilerini kayıt ediyor.
            if (File.Exists(MusteriPath))
            {
                var json = JsonConvert.SerializeObject(VeriTabani.GetAllVT());
                File.WriteAllText(MusteriPath, json);
            }

            //Musteri ID Kayıt etme
            //if (File.Exists(MusteriPath))
            //{
            //    var json = JsonConvert.SerializeObject(VeriTabani.IdSayac);
            //    File.WriteAllText(MusteriIdPath, json);
            //}
        }

        public List<Musteri> MusteriListRead()
        {
            //Muşteri verilerini okuyor.
            if (File.Exists(MusteriPath))
            {
                var json = File.ReadAllText(MusteriPath);
                return JsonConvert.DeserializeObject<List<Musteri>>(json);
            }
            return new List<Musteri>();
        }


        //public int MusteriIdRead()
        //{
        //    if (File.Exists(MusteriIdPath))
        //    {
        //        var json = File.ReadAllText(MusteriIdPath);
        //        return JsonConvert.DeserializeObject(json);
        //    }
        //}


        
    }
}
