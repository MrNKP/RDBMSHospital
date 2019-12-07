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
        private void reloadDB()
        {
            db = new HospitalContext();
        }
        // patient
        public bool EditPatient(int id, string fn, string n, string fan, DateTime birth, int ss, int cs)
        {
            reloadDB();
            patient p = db.patients.Find(id);
            if (p != null)
            {
                p.family_name = fn;
                p.name = n;
                p.father_name = fan;
                p.bitrh = birth;
                p.soc_status = ss;
                p.cur_status = cs;
                //string command = "UPDATE Patient SET family_name = '" + fn + "', name = '" + n + "', father_name = '" + fan + "', birth = '" + birth + "', soc_status = " + ss + ", cur_status = " + cs + " WHERE id = " + id + ";";
                try
                {
                    db.SaveChanges();
                    //db.Database.ExecuteSqlCommand(command);
                    return true;
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
            reloadDB();
            patient p = db.patients.Find(id);
            if (p != null)
            {
                //string command = "DELETE FROM Patient WHERE id = " + id + ";";
                try
                {
                    db.patients.Remove(p);
                    // TODO удаление из смежных таблиц
                    db.SaveChanges();
                    //db.Database.ExecuteSqlCommand(command);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }
        public patient AddPatient(string fn, string n, string fan, DateTime birth, int ss, int cs)
        {
            reloadDB();
            patient p = db.patients.Where(e => (e.family_name.ToLower() == fn) && (e.name.ToLower() == n) && (e.father_name.ToLower() == fan) && (e.bitrh == birth) && (e.soc_status == ss) && (e.cur_status == cs)).FirstOrDefault();
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
                string command = "INSERT INTO Patient VALUES('" + fn + "', '" + n + "', '" + fan + "', '" + birth + "', " + ss + ", " + cs + ");";
                try
                {
                    //db.patients.Add(p);
                    //db.SaveChanges();
                    db.Database.ExecuteSqlCommand(command);
                    return p;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        //doctor
        public bool EditDoctor(int id, string fn, string n, string fan, int pos, Decimal qual, bool notNull)
        {
            reloadDB();
            doctor d = db.doctors.Find(id);
            if (d != null)
            {
                d.family_name = fn;
                d.name = n;
                d.father_name = fan;
                d.position = pos;
                /*
                if (qual != null && qual != "")
                    d.qualification = Convert.ToInt32(qual);
                else
                    d.qualification = null;
                    */
                
                if (notNull)
                    d.qualification = Convert.ToInt32(qual);
                else
                    d.qualification = null;
                    
                /*
                int q = Convert.ToInt32(qual);
                if (q != d.qualification)
                {
                    if (notNull)
                        d.qualification = q;
                    else
                        d.qualification = null;
                }
                */
                /*
                string command = "UPDATE Doctor SET family_name = '" + fn + "', name = '" + n + "', father_name = '" + fan + "', position = " + pos;
                if (notNull)
                {
                    int q = Convert.ToInt32(qual);
                    command += ", qualification = " + q;
                }
                command += " WHERE id = " + id + ";";
                */
                try
                {
                    db.SaveChanges();
                    //db.Database.ExecuteSqlCommand(command);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }
        public bool DeleteDoctor(int id)
        {
            reloadDB();
            doctor d = db.doctors.Find(id);
            if (d != null)
            {
                try
                {
                    db.doctors.Remove(d);
                    // TODO удаление из смежных таблиц
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }
        public bool AddDoctorNewSpecialization(int did, int sp)
        {
            doctor_to_specialization dts = db.doctor_to_specialization.Where(e => (e.docID == did) && (e.specID == sp)).FirstOrDefault();
            if (dts != null) return false;
            else
            {
                dts = new doctor_to_specialization();
                dts.docID = did;
                dts.specID = sp;
                try
                {
                    db.doctor_to_specialization.Add(dts);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool AddDoctorSpecialization(int did, int sp1, int sp2, bool notNull)
        {
            if (notNull)
            {
                doctor_to_specialization dts1 = db.doctor_to_specialization.Where(e => (e.docID == did) && (e.specID == sp1)).FirstOrDefault();
                doctor_to_specialization dts2 = db.doctor_to_specialization.Where(e => (e.docID == did) && (e.specID == sp2)).FirstOrDefault();
                if ((dts1 != null) || (dts2 != null)) return false;
                else
                {
                    dts1 = new doctor_to_specialization();
                    dts2 = new doctor_to_specialization();
                    dts1.docID = did;
                    dts1.specID = sp1;
                    dts2.docID = did;
                    dts2.specID = sp2;
                    try
                    {
                        db.doctor_to_specialization.Add(dts1);
                        db.doctor_to_specialization.Add(dts2);
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
            else
            {
                doctor_to_specialization dts1 = db.doctor_to_specialization.Where(e => (e.docID == did) && (e.specID == sp1)).FirstOrDefault();
                if (dts1 != null) return false;
                else
                {
                    dts1 = new doctor_to_specialization();
                    dts1.docID = did;
                    dts1.specID = sp1;
                    try
                    {
                        db.doctor_to_specialization.Add(dts1);
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }
        public doctor AddDoctor(string fn, string n, string fan, int pos, Decimal qual, bool notNull)
        {
            reloadDB();
            if (notNull)
            {
                int q = Convert.ToInt32(qual);
                doctor d = db.doctors.Where(e => (e.family_name.ToLower() == fn) && (e.name.ToLower() == n) && (e.father_name.ToLower() == fan) && (e.position == pos) && (e.qualification == q)).FirstOrDefault();
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
                    string command = "INSERT INTO Doctor VALUES('" + fn + "', '" + n + "', '" + fan + "', " + pos + ", " + q + ");";
                    try
                    {
                        //db.doctors.Add(d);
                        //db.SaveChanges();
                        db.Database.ExecuteSqlCommand(command);
                        return d;
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
            else
            {
                doctor d = db.doctors.Where(e => (e.family_name.ToLower() == fn.ToLower()) && (e.name.ToLower() == n.ToLower()) && (e.father_name.ToLower() == fan.ToLower()) && (e.position == pos)).FirstOrDefault();
                if (d != null) return null;
                else
                {
                    d = new doctor();
                    d.family_name = fn;
                    d.name = n;
                    d.father_name = fan;
                    d.position = pos;
                    string command = "INSERT INTO Doctor VALUES('" + fn + "', '" + n + "', '" + fan + "', " + pos + ", NULL);";
                    try
                    {
                        //db.doctors.Add(d);
                        //db.SaveChanges();
                        db.Database.ExecuteSqlCommand(command);
                        return d;
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
        }
        //result
        public bool EditResult(int id, int pid, int did, string diag, bool ot, int days, bool ca, DateTime st, DateTime pr, DateTime f, bool notNull)
        {
            reloadDB();
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
                if (notNull)
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
            reloadDB();
            result r = db.results.Find(id);
            if (r != null)
            {
                try
                {
                    db.results.Remove(r);
                    // TODO удаление из смежных таблиц
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }
        public result AddResult(int pid, int did, string diag, bool ot, int days, bool ca, DateTime st, DateTime pr, DateTime f, bool notNull)
        {
            reloadDB();
            if (notNull)
            {
                result r = db.results.Where(e => (e.patientId == pid) && (e.doctorId == did) && (e.diagnosis.ToLower() == diag.ToLower()) && (e.outpatient_treatment == ot) && (e.count_without_work == days) && (e.clinical_account == ca) && (e.start == st) && (e.predicted == pr) && (e.fact == f)).FirstOrDefault();
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
                    r.fact = f;
                    string command = "INSERT INTO Result VALUES(" + pid + ", " + did + ", '" + diag + "', ";
                    if (ot) command += '1';
                    else command += '0';
                    command += ", " + days + ", ";
                    if (ca) command += '1';
                    else command += '0';
                    command += ", '" + st + "', '" + pr + "', '" + f + "');";
                    try
                    {
                        //db.results.Add(r);
                        //db.SaveChanges();
                        db.Database.ExecuteSqlCommand(command);
                        return r;
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
            else
            {
                result r = db.results.Where(e => (e.patientId == pid) && (e.doctorId == did) && (e.diagnosis.ToLower() == diag.ToLower()) && (e.outpatient_treatment == ot) && (e.count_without_work == days) && (e.clinical_account == ca) && (e.start == st) && (e.predicted == pr)).FirstOrDefault();
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
                    string command = "INSERT INTO Result VALUES(" + pid + ", " + did + ", '" + diag + "', ";
                    if (ot) command += '1';
                    else command += '0';
                    command += ", " + days + ", ";
                    if (ca) command += '1';
                    else command += '0';
                    command += ", '" + st + "', '" + pr + "', NULL);";
                    try
                    {
                        //db.results.Add(r);
                        //db.SaveChanges();
                        db.Database.ExecuteSqlCommand(command);
                        return r;
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
        }
    }
}
