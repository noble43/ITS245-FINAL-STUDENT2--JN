using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterEx.Models
{
    public static class ReportGenerator
    {
        public static string GeneratePatientReport(
            DataTable demo,
            DataTable medhx,
            DataTable immun,
            DataTable meds,
            string createdByUser)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("===============================================");
            sb.AppendLine("           PATIENT MEDICAL REPORT");
            sb.AppendLine("===============================================");
            sb.AppendLine("Generated: " + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));
            sb.AppendLine("Created By User: " + createdByUser);
            sb.AppendLine("-----------------------------------------------");
            sb.AppendLine();

            // DEMOGRAPHICS
            sb.AppendLine("*************** DEMOGRAPHICS ***************");
            if (demo.Rows.Count > 0)
            {
                DataRow r = demo.Rows[0];
                foreach (DataColumn c in demo.Columns)
                {
                    sb.AppendLine($"{c.ColumnName}: {r[c]}");
                }
            }
            sb.AppendLine();

            // GENERAL MEDICAL HISTORY
            sb.AppendLine("******** GENERAL MEDICAL HISTORY ***********");
            if (medhx.Rows.Count > 0)
            {
                DataRow r = medhx.Rows[0];
                foreach (DataColumn c in medhx.Columns)
                {
                    sb.AppendLine($"{c.ColumnName}: {r[c]}");
                }
            }
            sb.AppendLine();

            // IMMUNIZATIONS
            sb.AppendLine("************* IMMUNIZATIONS ****************");
            foreach (DataRow r in immun.Rows)
            {
                sb.AppendLine($"Vaccine: {r["Vaccine"]} | Date: {r["ImmunizationDate"]} | Delivery: {r["Delivery"]}");
            }
            sb.AppendLine();

            // MEDICATIONS
            sb.AppendLine("*************** MEDICATIONS ****************");
            foreach (DataRow r in meds.Rows)
            {
                sb.AppendLine($"Medication: {r["Medication"]} | Amt: {r["MedicationAmt"]} {r["MedicationUnit"]}");
            }

            return sb.ToString();
        }
    }
}
