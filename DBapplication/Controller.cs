using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        string Citizen;
        string Hospital;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public int InsertDoctor(string fname, int id, string Gender)
        {
            string query = "INSERT INTO Doctor (First_Name, ID, Gender) " +
                            "Values ('" + fname + "','" + id + "','" + Gender + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertPrescrip(int DID, int PID, string Med, string Date)
        {
            string query = "INSERT INTO Prescription (Dname, Dnumber, Mgr_SSN, Mgr_Start_Date) " +
                            "Values ('" + DID + "','" + PID + "','" + Med + "'," + Convert.ToDateTime(Date) + "); ";
            return dbMan.ExecuteNonQuery(query);
        }
     

        public int DeleteSupplier(string snum)
        {
            string query = "DELETE FROM S WHERE S#='" + snum + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeleteProject(int Pnumber)
        {
            string query = "DELETE FROM Project WHERE Pnumber='" + Pnumber + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateSupplier(string snum, string city)
        {
            string query = "UPDATE S SET City='" + city + "' WHERE S#='" + snum + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateEmployee(int SSN, int Salary)
        {
            string query = "UPDATE Employee SET Salary='" + Salary + "' WHERE SSN='" + SSN + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectAllDoctors()
        {
            string query = "SELECT * FROM Doctor;";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectAllPatients()
        {
            string query = "SELECT * FROM Patients;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllPrescriptions()
        {
            string query = "SELECT * FROM Prescription;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectManagerName(int Dnumber)
        {
            string query = "SELECT Fname FROM Employee, Department WHERE Dnumber=' " + Dnumber + " ' AND SSN=Mgr_SSN ;";
            return dbMan.ExecuteReader(query);
        }

        public int CountSuppliers()
        {
            string query = "SELECT COUNT(S#) FROM S;";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int CountMaleEmployeesWorksOnProject(int Pnumber)
        {
            string query = "SELECT COUNT(Essn) FROM Works_On, Employee WHERE Pno=' " + Pnumber + "' AND Sex='M' AND Essn=SSN ;";
            return (int)dbMan.ExecuteScalar(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////

        public int InsertHospital(string hospital_id, string hospital_name, string address, int capacity, bool availability, int passcode)
        {
            string query = "INSERT INTO Hospital (Hospital_ID, H_Name, Address, Capacity, Availabilty, Passcode) " +
                            "Values ('" + hospital_id + "','" + hospital_name + "','" + address + "','" + capacity + "','" + availability + "','" + passcode + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertService(string service_id, string s_name, string s_type)
        {
            string query = "INSERT INTO Service (Service_ID, S_Name, S_Type) " +
                            "Values ('" + service_id + "','" + s_name + "','" + s_type + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertVaccine(string vaccine_id, string v_name, string supplier, int amount, int doses)
        {
            string query = "INSERT INTO Vaccine (Vaccine_ID, V_Name, Supplier, Amount, Doses) " +
                            "Values ('" + vaccine_id + "','" + v_name + "','" + supplier + "','" + amount + "','" + doses + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertRequest(string nat_it, string s_id, string h_id)
        {

            string query = "INSERT INTO Request " +
                            "Values ('" + nat_it + "','" + s_id + "','" + h_id + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectACitizen(string NAT_Id)
        {
            string query = "SELECT * FROM Citizens WHERE National_ID ='" + NAT_Id + "';";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateAvailability(bool check)
        {
            string query = "UPDATE Hospital SET Availabilty='" + check + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsuranceCompany(string company_id, string c_name, float Dis)
        {
            string query = "INSERT INTO Insurance_Company (Company_ID, C_Name, Discount) " +
                            "Values ('" + company_id + "','" + c_name + "','" + Dis + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateVaccine(string id, int amount)
        {
            string query = "UPDATE Vaccine SET Amount='" + amount + "' WHERE Vaccine_ID='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateCitizenPassword(string id, string pass)
        {
            string query = "UPDATE Citizens SET Password='" + pass  + "' WHERE National_ID='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertStaffMember(string national_id, string fname, string lname, string field, string graduated, string certificate)
        {
            string query = "INSERT INTO Medical_Staff (National_ID, FName, LName, Field, Graduated_From, Certificate) " +
                            "Values ('" + national_id + "','" + fname + "','" + lname + "','" + field + "','" + graduated + "','" + certificate + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertCitizen(string national_id, string fname, string lname, int age,string address ,string insurance_id, bool vaccinated, int pastinfections, string pass)
        {
            string query = "INSERT INTO Citizens (National_ID, FName, LName, Age, Address, Insurance_ID, Vaccinated, No#ofPast_Infections, Password) " +
                            "Values ('" + national_id + "','" + fname + "','" + lname + "','" + age + "','" + address + "','" + insurance_id + "','" + vaccinated + "','" + pastinfections + "','" + pass + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertOfferedBy(string hosp_id, string s_id)
        {
            string query = "INSERT INTO Offered_By (Service_ID, Hospital_ID) " +
                            "Values ('" + s_id + "','" + hosp_id + "');";
            return dbMan.ExecuteNonQuery(query);
        }

      
        public int DeleteStaffMember(string id)
        {
            string query = "DELETE FROM Medical_Staff WHERE National_ID='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectPatientRequest()
        {
            string query = "SELECT National_ID, FName, Age, Vaccinated, S_name FROM Citizens, Request, Service " +
                "WHERE Ser_ID= Service_ID AND Nat_ID=National_ID  ;";
            return dbMan.ExecuteReader(query);
        }

        public int DeleteRequest(string id)
        {
            string query = "DELETE FROM Request WHERE Nat_ID='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertWorkIn(string hospital_id, string national_id)
        {
            string query = "INSERT INTO Work_In (Hospital_ID, National_ID) " +
                            "Values ('" + hospital_id + "','" + national_id + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectPass(string id)
        {
            string query = "SELECT Password FROM Citizens WHERE National_ID = '" + id + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectPassCode(string id)
        {
            string query = "SELECT Passcode FROM Hospital WHERE Hospital_ID = '" + id + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectServiceID(string sName)
        {
            string query = "SELECT Service_ID FROM Service WHERE S_Name = '" + sName + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectHospitalID(string hName)
        {
            string query = "SELECT Hospital_ID FROM Hospital WHERE H_Name = '" + hName + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllServices()
        {
            string query = "SELECT * FROM Service;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectServiceNames()
        {
            string query = "SELECT S_Name FROM Service;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectHospitalService(string ID)
        {
            string query = "SELECT H_Name FROM Hospital, Offered_By WHERE Service_ID = '" + ID + "' AND Hospital.Hospital_ID = Offered_By.Hospital_ID";
            return dbMan.ExecuteReader(query);
        }

        public int InsertPatient(string national_id, string health, string status, bool critical)
        {
            string query = "INSERT INTO Patients (Nat_ID, Health_Condition, Current_Status, Critical) " +
                            "Values ('" + national_id + "','" + health + "','" + status + "','" + critical + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeletePatient(String id)
        {
            string query = "DELETE FROM Patients WHERE Nat_ID='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public void SetCitizen(string C)
        {
            Citizen = C;
        }

        public string GetCitizen()
        {
            return Citizen;
        }

        public void SetHospital(string C)
        {
            Hospital = C;
        }

        public string GetHospital()
        {
            return Hospital;
        }
    }
}
