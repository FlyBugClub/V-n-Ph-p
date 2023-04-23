using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using VanPhap.Model;

namespace VanPhap
{
    internal class VanPhapDAO
    {
        DataClasses1DataContext db = new DataClasses1DataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        public List<ChiTietSo> SelectAll()
        {
            List<ChiTietSo> humans = db.ChiTietSos.ToList();
            return humans;
        }
        public List<PhatTu> SelectAllPhatTu()
        {
            List<PhatTu> humans = db.PhatTus.ToList();
            return humans;
        }
        public ChiTietSo SelectByID(int ID)
        {
            ChiTietSo human = db.ChiTietSos.SingleOrDefault(b => b.IDSo == ID);
            return human;
        }



        public List<ChiTietSo> SelectByKeyword(String keyword)
        {
            List<ChiTietSo> humans = db.ChiTietSos.Where(b => b.HoTen.Contains(keyword)).ToList();
            return humans;
        }
        public bool Insert(ChiTietSo newHuman)

        {
            try
            {
                db.ChiTietSos.InsertOnSubmit(newHuman);
                db.SubmitChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool Update(ChiTietSo newHuman)
        {

            ChiTietSo dbHuman = db.ChiTietSos.SingleOrDefault(b => b.IDSo == newHuman.IDD);

            if (dbHuman != null)
            {
                try
                {
                    dbHuman.HoTen = newHuman.HoTen;
                    
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;
        }
        public bool Delete(int humanID)
        {
            ChiTietSo dbHuman = db.ChiTietSos.SingleOrDefault(b => b.IDD== humanID);
            if (dbHuman != null)
            {
                try
                {
                    db.ChiTietSos.DeleteOnSubmit(dbHuman);
                    db.SubmitChanges();
                    return true;

                }
                catch { return false; }
            }
            return false;
        }
    }
            
}

