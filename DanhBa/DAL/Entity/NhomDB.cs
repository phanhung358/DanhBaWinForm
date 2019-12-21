using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhBa.DAL.Entity
{
    class NhomDB
    {
        [Key]
        public string manhomDB { get; set; }
        public string tennhomDB { get; set; }

        public static List<NhomDB> GeNhom()
        {
            return new Context().NhomDanhBaDbset.ToList();
        }
        public static void AddNhom(NhomDB nhom)
        {
            var db = new Context();
            db.NhomDanhBaDbset.Add(nhom);
            db.SaveChanges();
        }
        public static void RemoveNhom(NhomDB nhom)
        {
            var db = new Context();
            var objSV = db.NhomDanhBaDbset.Where(e => e.manhomDB == nhom.manhomDB).FirstOrDefault();
            if (objSV != null)
                db.NhomDanhBaDbset.Remove(objSV);
            db.SaveChanges();
        }
        public static void EditNhom(NhomDB nhom)
        {
            var db = new Context();
            var objSV = db.NhomDanhBaDbset.Where(e => e.manhomDB == nhom.manhomDB).FirstOrDefault();
            if (objSV != null)
            {
                objSV.tennhomDB = nhom.tennhomDB;
            }
            db.SaveChanges();

        }
    }
}
