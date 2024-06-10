using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataLayer
{
    public class DataClass
    {
        private readonly string filePath = "calculations.txt";

        public void SaveToFile(string result)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving calculations: {ex.Message}");
            }
        }

        

        

        public DataTable GetAllFromFile()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Result", typeof(string));

            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = i + 1;
                        row["Result"] = lines[i];
                        dt.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while getting calculations: {ex.Message}");
            }

            return dt;
        }
    }
}
