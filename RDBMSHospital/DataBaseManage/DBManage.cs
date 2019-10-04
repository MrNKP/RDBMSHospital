using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDBMSHospital.DataBaseManage
{
    class DBManage
    {
        private HospitalContext db;
        public DBManage(HospitalContext context)
        {
            db = context;
        }
        // patient
        public bool EditPatient(int id, string fn, string n, string fan, DateTime birth, int ss, int cs)
        {
            patient p = db.patients.Find(id);
            if (p != null)
            {
                p.family_name = fn;
                p.name = n;
                p.father_name = fan;
                p.bitrh = birth;
                p.soc_status = ss;
                p.cur_status = cs;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        public bool DeletePatient(int id)
        {
            patient p = db.patients.Find(id);
            if (p != null)
            {
                db.patients.Remove(p);
                // TODO удаление из смежных таблиц
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public patient AddPatient(string fn, string n, string fan, DateTime birth, int ss, int cs)
        {
            patient p = db.patients.Where(e => (e.family_name == fn) && (e.name == n) && (e.father_name == fan) && (e.bitrh == birth) && (e.soc_status == ss) && (e.cur_status == cs)).FirstOrDefault();
            if (p != null) return null;
            else
            {
                p = new patient();
                p.family_name = fn;
                p.name = n;
                p.father_name = fan;
                p.bitrh = birth;
                p.soc_status = ss;
                p.cur_status = cs;
                db.patients.Add(p);
                db.SaveChanges();
                return p;
            }
        }
    }
}
