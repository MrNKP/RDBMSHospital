using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDBMSHospital.Views;

namespace RDBMSHospital.DataBaseManage
{
    class DBManage
    {
        private HospitalContext db;
        public DBManage(HospitalContext context)
        {
            db = context;
        }
        //views
        /*
        public List<ExtResult> GetExtResults()
        {
            var k = db.results.Select(p => new ExtResult
            {
                id = p.id,
                patientFamilyName = p.patient.family_name,
                patientName = p.patient.name,
                patientFatherName = p.patient.father_name,
                doctorFamilyName = p.doctor.family_name,
                doctorName = p.doctor.name,
                doctorFatherName = p.doctor.father_name,
                diagnosis = p.diagnosis,
                outpatient_treatment = p.outpatient_treatment,
                count_without_work = p.count_without_work,
                clinical_account = p.clinical_account,
                start = p.start,
                predicted = p.predicted,
                fact = p.fact
            });
            return k.ToList();
        }
        public List<ExtPatient> GetExtPatients()
        {
            var k = db.patients.Select(p => new ExtPatient
            {
                id = p.id,
                familyName = p.family_name,
                name = p.name,
                fatherName = p.father_name,
                birth = p.bitrh,
                soc_status = p.social_status.soc_status,
                curr_status = p.current_status.curr_status
            });
            return k.ToList();
        }
        public List<ExtDoctor> GetExtDoctors()
        {
            var k = db.doctors.Select(p => new ExtDoctor
            {
                id = p.id,
                familyName = p.family_name,
                name = p.name,
                fatherName = p.father_name,
                position = p.doctor_position.position,
                qualification = p.qualification
            });
            return k.ToList();
        }
        */
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
        //doctor
        public bool EditDoctor(int id, string fn, string n, string fan, int pos, string qual)
        {
            doctor d = db.doctors.Find(id);
            if (d != null)
            {
                d.family_name = fn;
                d.name = n;
                d.father_name = fan;
                d.position = pos;
                if (qual != null && qual != "")
                    d.qualification = Convert.ToInt32(qual);
                else
                    d.qualification = null;
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
        public bool DeleteDoctor(int id)
        {
            doctor d = db.doctors.Find(id);
            if (d != null)
            {
                db.doctors.Remove(d);
                // TODO удаление из смежных таблиц
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public doctor AddDoctor(string fn, string n, string fan, int pos, string qual)
        {
            if (qual != null && qual != "")
            {
                int q = Convert.ToInt32(qual);
                doctor d = db.doctors.Where(e => (e.family_name == fn) && (e.name == n) && (e.father_name == fan) && (e.position == pos) && (e.qualification == q)).FirstOrDefault();
                if (d != null) return null;
                else
                {
                    d = new doctor();
                    d.family_name = fn;
                    d.name = n;
                    d.father_name = fan;
                    d.position = pos;
                    //d.qualification = Convert.ToInt32(qual);
                    d.qualification = q;
                    db.doctors.Add(d);
                    db.SaveChanges();
                    return d;
                }
            }
            else
            {
                doctor d = db.doctors.Where(e => (e.family_name == fn) && (e.name == n) && (e.father_name == fan) && (e.position == pos)).FirstOrDefault();
                if (d != null) return null;
                else
                {
                    d = new doctor();
                    d.family_name = fn;
                    d.name = n;
                    d.father_name = fan;
                    d.position = pos;
                    db.doctors.Add(d);
                    db.SaveChanges();
                    return d;
                }
            }
        }
        //result
        public bool EditResult(int id, int pid, int did, string diag, bool ot, int days, bool ca, DateTime st, DateTime pr, string f)
        {
            result r = db.results.Find(id);
            if (r != null)
            {
                r.patientId = pid;
                r.doctorId = did;
                r.diagnosis = diag;
                r.outpatient_treatment = ot;
                r.count_without_work = days;
                r.clinical_account = ca;
                r.start = st;
                r.predicted = pr;
                if (f != null && f != "")
                    r.fact = Convert.ToDateTime(f);
                else
                    r.fact = null;
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
        public bool DeleteResult(int id)
        {
            result r = db.results.Find(id);
            if (r != null)
            {
                db.results.Remove(r);
                // TODO удаление из смежных таблиц
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public result AddResult(int pid, int did, string diag, bool ot, int days, bool ca, DateTime st, DateTime pr, string f)
        {
            if (f != null && f != "")
            {
                result r = db.results.Where(e => (e.patientId == pid) && (e.doctorId == did) && (e.diagnosis == diag) && (e.outpatient_treatment == ot) && (e.count_without_work == days) && (e.clinical_account == ca) && (e.start == st) && (e.predicted == pr) && (e.fact == Convert.ToDateTime(f))).FirstOrDefault();
                if (r != null) return null;
                else
                {
                    r = new result();
                    r.patientId = pid;
                    r.doctorId = did;
                    r.diagnosis = diag;
                    r.outpatient_treatment = ot;
                    r.count_without_work = days;
                    r.clinical_account = ca;
                    r.start = st;
                    r.predicted = pr;
                    r.fact = Convert.ToDateTime(f);
                    db.results.Add(r);
                    db.SaveChanges();
                    return r;
                }
            }
            else
            {
                result r = db.results.Where(e => (e.patientId == pid) && (e.doctorId == did) && (e.diagnosis == diag) && (e.outpatient_treatment == ot) && (e.count_without_work == days) && (e.clinical_account == ca) && (e.start == st) && (e.predicted == pr)).FirstOrDefault();
                if (r != null) return null;
                else
                {
                    r = new result();
                    r.patientId = pid;
                    r.doctorId = did;
                    r.diagnosis = diag;
                    r.outpatient_treatment = ot;
                    r.count_without_work = days;
                    r.clinical_account = ca;
                    r.start = st;
                    r.predicted = pr;
                    db.results.Add(r);
                    db.SaveChanges();
                    return r;
                }
            }
        }
    }
}
