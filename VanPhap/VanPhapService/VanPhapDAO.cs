using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanPhapShared;
using System.Configuration;
namespace VanPhapService
{
    internal class VanPhapDAO
    {
            DataClasses1DataContext db = new DataClasses1DataContext();
            public List<ChiTietSo> SelectAll()
            {
                db.ObjectTrackingEnabled = false;
                List<ChiTietSo> humans = db.ChiTietSos.ToList();
                return humans;
            }
            public ChiTietSo SelectByID(int humanID)
            {
                db.ObjectTrackingEnabled = false;
                ChiTietSo human = db.ChiTietSos.SingleOrDefault(b => b.ID == humanID);
                return human;
            }



            public List<ChiTietSo> SelectByKeyword(String keyword)
            {
                db.ObjectTrackingEnabled = false;
                List<ChiTietSo> humans = db.ChiTietSos.Where(b => b.HoTen_Unicode.Contains(keyword)).ToList();
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
                catch { return false; }
            }
            public bool Update(ChiTietSo newHuman)
            {

                ChiTietSo dbHuman = db.ChiTietSos.SingleOrDefault(b => b.ID == newHuman.ID);

                if (dbHuman != null)
                {
                    try
                    {
                        dbHuman.HoTen_Unicode = newHuman.HoTen_Unicode;
                        dbHuman.PhapDanh_Unicode = newHuman.PhapDanh_Unicode;
                        dbHuman.NamNu = newHuman.NamNu;
                        dbHuman.IDNamSinh = newHuman.IDNamSinh;
                        db.SubmitChanges();
                        return true;
                    }
                    catch { return false; }
                }
                return false;
            }
            public bool Delete(int humanID)
            {
                ChiTietSo dbHuman = db.ChiTietSos.SingleOrDefault(b => b.ID == humanID);
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

