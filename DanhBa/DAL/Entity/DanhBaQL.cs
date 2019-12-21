using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhBa.DAL.Entity
{
    class DanhBaQL
    {
        [Key]
        public string maDB { get; set; }
        public string tenDB { get; set; }
        public string diachi { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }
        public string manhomDB { get; set; }
        [ForeignKey("manhomDB")]
        public virtual NhomDB NDB { get; set; }

        public static List<DanhBaQL> GeDB()
        {
            return new Context().DanhBaDbset.ToList();
        }
        public static List<DanhBaQL> GeDBtheoMaNhom(string manhom)
        {
            return new Context().DanhBaDbset.Where(e => e.manhomDB == manhom).ToList();
        }
        public static void AddDB(DanhBaQL sv)
        {
            var db = new Context();
            db.DanhBaDbset.Add(sv);
            db.SaveChanges();
        }
        public static void RemoveDB(DanhBaQL danhBa)
        {
            var db = new Context();
            var objSV = db.DanhBaDbset.Where(e => e.maDB == danhBa.maDB).FirstOrDefault();
            if (objSV != null)
                db.DanhBaDbset.Remove(objSV);
            db.SaveChanges();

        }
        public static void EditDB(DanhBaQL danhBa)
        {
            var db = new Context();
            var objSV = db.DanhBaDbset.Where(e => e.maDB == danhBa.maDB).FirstOrDefault();
            if (objSV != null)
            {
                objSV.tenDB = danhBa.tenDB;
                objSV.diachi = danhBa.diachi;
                objSV.email = danhBa.email;
                objSV.sdt = danhBa.sdt;
                objSV.manhomDB = danhBa.manhomDB;
            }
            db.SaveChanges();

        }
    }
}
