using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterEx.Models
{
    public class GeneralMedicalHistoryModel
    {
        public int GeneralMedicalHistoryID { get; set; }
        public int PatientID { get; set; }
        public string MaritalStatus { get; set; }
        public string Education { get; set; }
        public string BehavioralHistory { get; set; }
        public string Tobacco { get; set; }
        public string TobaccoQuantity { get; set; }
        public string TobaccoDuration { get; set; }
        public string Alcohol { get; set; }
        public string AlcoholQuantity { get; set; }
        public string AlcoholDuration { get; set; }
        public string Drug { get; set; }
        public string DrugType { get; set; }
        public string DrugDuration { get; set; }
        public string Dietary { get; set; }
        public string BloodType { get; set; }
        public string Rh { get; set; }
        public int? NumberOfChildren { get; set; }
        public string LMPStatus { get; set; }
        public bool MensesMonthlyYes { get; set; }
        public bool MensesMonthlyNo { get; set; }
        public string MensesFreq { get; set; }
        public string MedicalHistoryNotes { get; set; }
        public string HxObtainedBy { get; set; }
    }
}
