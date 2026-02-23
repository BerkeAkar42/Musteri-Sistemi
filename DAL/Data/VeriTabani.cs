using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.JSON_Data_Save;
using Entity.Models;

namespace DAL.Data
{
    public static class VeriTabani
    {
        private static List<Musteri> MusteriVT;
        static JSON_Katdet jsonVeriKaydet = new JSON_Katdet();
        public static int IdSayac;

        static VeriTabani()
        {
            if (MusteriVT is null)
            {
                MusteriVT = new List<Musteri>();
            }
            MusteriVT = jsonVeriKaydet.MusteriListRead();

            //ID'yi elimizde tutuyoruz!!!
            int uzunluk = MusteriVT.Count;
            IdSayac = MusteriVT[uzunluk - 1].MusteriID + 1;
        }


        public static void Add(Musteri item)
        {
            MusteriVT.Add(item);
            Save();
        }

        public static void Remove(Musteri item)
        {
            MusteriVT.Remove(item);
        }

        public static void AllRemove()
        {
            MusteriVT.Clear();
        }

        public static List<Musteri> GetAllVT()
        {
            return MusteriVT;
        }


        public static void Save()
        {
            jsonVeriKaydet.Save();
        }
    }
}
