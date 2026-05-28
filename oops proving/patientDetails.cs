using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_proving
{
    class Hospital
    {
        string patientName;
        int page;
        string pmedicalhistory;
       
        public string PatientName
        {
            get { return patientName; }
            set
            {
               
                patientName = value;
            }
        }
        public int Page
        {
            get { return page; }
             
        }
        public string Pmedicalhistory
        {
         
            set { pmedicalhistory = value; }
        }
        public Hospital(string patientName, int page)
        {
            this.patientName = patientName;
            this.page = page;
        }
        public bool IsEligibleforsurgery()
        {
            return page >= 18;
        }
        internal class patientDetails
        {
        //    static void Main(string[] args)
        //    {
        //      Hospital p = new Hospital("Ramu",19);
        //        p.pmedicalhistory = "Diabetic";
        //        p.IsEligibleforsurgery();
        //        Console.WriteLine($"Patient name : {p.PatientName}  age : {p.page}");
                
        //    }
        }
    }
}
