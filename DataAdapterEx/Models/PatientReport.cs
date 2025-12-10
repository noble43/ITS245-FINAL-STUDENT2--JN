using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapterEx.Models
{
    public class PatientReport
    {
        //Home Password: toor
        private string connectionString = "server=localhost;database=patientdb;uid=root;pwd=password;";

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
                    string historyQuery = @"SELECT * FROM generalmedicalhistory WHERE PatientID = @PatientID";
                    MySqlCommand cmdHistory = new MySqlCommand(historyQuery, conn);
                    cmdHistory.Parameters.AddWithValue("@PatientID", patientID);

                    MySqlDataReader historyReader = cmdHistory.ExecuteReader();

                    string medicalHistoryText = "";
                    while (historyReader.Read())
                    {
                        while (historyReader.Read())
                        {
                            medicalHistoryText += $"Tobacco: {historyReader["Tobacco"]}\n";
                            medicalHistoryText += $"Alcohol: {historyReader["Alcohol"]}\n";
                            medicalHistoryText += $"Drug Use: {historyReader["Drug"]}\n";
                            medicalHistoryText += $"Dietary: {historyReader["Dietary"]}\n";
                            medicalHistoryText += $"Blood Type: {historyReader["BloodType"]}\n";
                            medicalHistoryText += $"Notes: {historyReader["MedicalHistoryNotes"]}\n";
                            medicalHistoryText += "----------------------\n";
                        }

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
                        immunizationsText += $"Vaccine: {immunizationReader["Vaccine"]}\n";
                        immunizationsText += $"Date: {immunizationReader["ImmunizationDate"]}\n";
                        immunizationsText += $"Comments: {immunizationReader["Comments"]}\n";
                        immunizationsText += "----------------------\n";
                    }
                    immunizationReader.Close();

                    // Retrieve medication history
                    string medicationQuery = @"SELECT * FROM patientmedications WHERE PatientID = @PatientID";
                    MySqlCommand cmdMedication = new MySqlCommand(medicationQuery, conn);
                    cmdMedication.Parameters.AddWithValue("@PatientID", patientID);

                    MySqlDataReader medicationReader = cmdMedication.ExecuteReader();

                    string medicationText = "";
                    while (medicationReader.Read())
                    {
                        medicationText += $"Medication: {medicationReader["Medication"]}\n";
                        medicationText += $"Amount: {medicationReader["MedicationAmt"]}\n";
                        medicationText += $"Unit: {medicationReader["MedicationUnit"]}\n";
                        medicationText += $"Start Date: {medicationReader["MedicationStartDate"]}\n";
                        medicationText += $"End Date: {medicationReader["MedicationEndDate"]}\n";
                        medicationText += $"Instructions: {medicationReader["Instructions"]}\n";
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

                    // Current EXE folder → bin\Debug
                    string exeFolder = Application.StartupPath;

                    // Create Reports folder inside bin\Debug
                    string reportsFolder = Path.Combine(exeFolder, "Reports");

                    if (!Directory.Exists(reportsFolder))
                    {
                        Directory.CreateDirectory(reportsFolder);
                    }

                    // Unique file name
                    string fileName = $"PatientReport_{patientID}_{DateTime.Now:yyyyMMddHHmmss}.txt";
                    string filePath = Path.Combine(reportsFolder, fileName);

                    // ✅ Write file
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.Write(reportContent);
                    }

                    // ✅ Open the file automatically
                    try
                    {
                        Process.Start(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not open the report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // ✅ Confirm
                    MessageBox.Show($"Report saved to:\n{filePath}", "Report Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "❌ ERROR generating report:\n\n" + ex.Message,"Report Failure", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }
    }
} 
