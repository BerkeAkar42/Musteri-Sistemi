using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Models;
using DAL.Data;

namespace Service.Service
{
    public class MusteriService
    {
        public void Add(Musteri item)
        {
            if (item is not null)
            {
                VeriTabani.Add(item);
            }
        }


        public void Remove(Musteri item)
        {
            if (item is not null)
            {
                VeriTabani.Remove(item);
            }
        }

        public void AllRemove()
        {
            VeriTabani.AllRemove();
        }

        public List<Musteri> GetAll()
        {
            return VeriTabani.GetAllVT();
        }

        public Musteri GetOne(int id)
        {
            foreach (var item in GetAll())
            {
                if (item.MusteriID == id)
                {
                    return item;
                }
            }

            return null;
        }


        public Musteri VarMiYokMu(int id)
        {
            foreach (var item in VeriTabani.GetAllVT())
            {
                if (item.MusteriID == id)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
