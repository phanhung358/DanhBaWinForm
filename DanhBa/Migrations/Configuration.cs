namespace DanhBa.Migrations
{
    using DanhBa.DAL.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DanhBa.DAL.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DanhBa.DAL.Context context)
        {
            context.DanhBaDbset.AddOrUpdate(new DanhBaQL
            {
                maDB = "1",
                tenDB = "Thái",
                diachi = "Phú An",
                email = "nqthaib1@gmail.com",
                sdt = "07012468789",
                manhomDB = "1"
            }, new DanhBaQL
            {
                maDB = "2",
                tenDB = "Hùng",
                diachi = "Phú An",
                email = "phanhung.12a1.pdl@gmail.com",
                sdt = "0778564265",
                manhomDB = "1"
            }, new DanhBaQL
            {
                maDB = "3",
                tenDB = "Thuận",
                diachi = "Huế",
                email = "thuandaica0306@gmail.com",
                sdt = "07012468789",
                manhomDB = "1"
            }, new DanhBaQL
            {
                maDB = "4",
                tenDB = "Ba",
                diachi = "Phú An",
                email = "",
                sdt = "0978206832",
                manhomDB = "2"
            }, new DanhBaQL
            {
                maDB = "5",
                tenDB = "Mạ",
                diachi = "Phú An",
                email = "",
                sdt = "0395597663",
                manhomDB = "2"
            }, new DanhBaQL
            {
                maDB = "6",
                tenDB = "Xếp",
                diachi = "Phú An",
                email = "nqthaib1@gmail.com",
                sdt = "07012468789",
                manhomDB = "3"
            });
            context.NhomDanhBaDbset.AddOrUpdate(new NhomDB
            {
                manhomDB = "1",
                tennhomDB = "Bạn Bè"
            }, new NhomDB
            {
                manhomDB = "2",
                tennhomDB = "Gia Đình"
            }, new NhomDB
            {
                manhomDB = "3",
                tennhomDB = "Công Việc"
            });
        }
    }
}
