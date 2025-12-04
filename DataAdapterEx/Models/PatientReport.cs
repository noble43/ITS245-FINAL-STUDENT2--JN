using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterEx.Models
{
    public class PatientReport
    {
        private string connectionString = "server=localhost;database=patientdb;uid=root;pwd=toor;";

        /// <summary>
        /// Generates a text report for the patient with the given PatientID.
        /// Includes the username of the person who created the report.
        /// </summary>
        public void GenerateReport(int patientID, string createdByUsername)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Retrieve patient demographics
                    string demographicsQuery = @"SELECT * FROM patientdemographics WHERE PatientID = @PatientID";
                    MySqlCommand cmdDemographics = new MySqlCommand(demographicsQuery, conn);
                    cmdDemographics.Parameters.AddWithValue("@PatientID", patientID);

                    MySqlDataReader reader = cmdDemographics.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        Console.WriteLine("Patient not found.");
                        return;
                    }

                    reader.Read();

                    string patientName = $"{reader["PtFirstName"]} {reader["PtMiddleInitial"]} {reader["PtLastName"]}";
                    string hospitalMR = reader["HospitalMR#"].ToString();
                    string address = $"{reader["HomeAddress"]}, {reader["HomeCity"]}";
                    string suffix = reader["Suffix"].ToString();

                    reader.Close();

                    // Retrieve patient medical history
                    string historyQuery = @"SELECT * FROM patientmedicalhistory WHERE PatientID = @PatientID";
                    MySqlCommand cmdHistory = new MySqlCommand(historyQuery, conn);
                    cmdHistory.Parameters.AddWithValue("@PatientID", patientID);

                    MySqlDataReader historyReader = cmdHistory.ExecuteReader();

                    string medicalHistoryText = "";
                    while (historyReader.Read())
                    {
                        medicalHistoryText += $"Condition: {historyReader["Condition"]}\n";
                        medicalHistoryText += $"Date Diagnosed: {historyReader["DateDiagnosed"]}\n";
                        medicalHistoryText += $"Notes: {historyReader["Notes"]}\n";
                        medicalHistoryText += "----------------------\n";
                    }
                    historyReader.Close();

                    // Retrieve immunizations history
                    string immunizationsQuery = @"SELECT * FROM immunizationshistorytable WHERE PatientID = @PatientID";
                    MySqlCommand cmdImmunizations = new MySqlCommand(immunizationsQuery, conn);
                    cmdImmunizations.Parameters.AddWithValue("@PatientID", patientID);

                    MySqlDataReader immunizationReader = cmdImmunizations.ExecuteReader();

                    string immunizationsText = "";
                    while (immunizationReader.Read())
                    {
                        immunizationsText += $"Vaccine: {immunizationReader["VaccineName"]}\n";
                        immunizationsText += $"Date Administered: {immunizationReader["DateAdministered"]}\n";
                        immunizationsText += $"Notes: {immunizationReader["Notes"]}\n";
                        immunizationsText += "----------------------\n";
                    }
                    immunizationReader.Close();

                    // Retrieve medication history
                    string medicationQuery = @"SELECT * FROM medicationhistorytable WHERE PatientID = @PatientID";
                    MySqlCommand cmdMedication = new MySqlCommand(medicationQuery, conn);
                    cmdMedication.Parameters.AddWithValue("@PatientID", patientID);

                    MySqlDataReader medicationReader = cmdMedication.ExecuteReader();

                    string medicationText = "";
                    while (medicationReader.Read())
                    {
                        medicationText += $"Medication: {medicationReader["MedicationName"]}\n";
                        medicationText += $"Dosage: {medicationReader["Dosage"]}\n";
                        medicationText += $"Frequency: {medicationReader["Frequency"]}\n";
                        medicationText += $"Start Date: {medicationReader["StartDate"]}\n";
                        medicationText += $"End Date: {medicationReader["EndDate"]}\n";
                        medicationText += $"Notes: {medicationReader["Notes"]}\n";
                        medicationText += "----------------------\n";
                    }
                    medicationReader.Close();

                    // Create report text
                    string reportContent = $"Patient Report\n";
                    reportContent += "====================\n";
                    reportContent += $"Name: {patientName} {suffix}\n";
                    reportContent += $"Hospital MR#: {hospitalMR}\n";
                    reportContent += $"Address: {address}\n";
                    reportContent += "----------------------\n";
                    reportContent += "Medical History:\n";
                    reportContent += medicalHistoryText;
                    reportContent += "----------------------\n";
                    reportContent += "Immunizations:\n";
                    reportContent += immunizationsText;
                    reportContent += "----------------------\n";
                    reportContent += "Medication History:\n";
                    reportContent += medicationText;
                    reportContent += "====================\n";
                    reportContent += $"Report created by: {createdByUsername}\n";
                    reportContent += $"Report created on: {DateTime.Now}\n";

                    // Save the report to a text file
                    string fileName = $"PatientReport_{patientID}_{DateTime.Now:yyyyMMddHHmmss}.txt";
                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

                    File.WriteAllText(filePath, reportContent);

                    Console.WriteLine($"Report generated successfully at: {filePath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error generating report: " + ex.Message);
            }
        }
    }
} 
