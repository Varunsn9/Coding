using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;


namespace Coding.Csv_File
{
    public class DataFetchingCsv
    {
        //fetch data from csv file
        public static void Main(string[] args)
        {
            string path = @"D:\VisualStudioRepos\AzureDevOps\Coding\Coding\Csv_File\CsvData.csv";

            // Create a new file stream and reader
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs))
            {
                // Read the header line (if present)
                string headerLine = reader.ReadLine();

                // Loop over each line of the file
                while (!reader.EndOfStream)
                {
                    // Read the next line
                    string line = reader.ReadLine();

                    // Split the line by the comma separator
                    string[] values = line.Split(',');

                    // Access the values of each column by index
                    string column1 = values[0];
                    string column2 = values[1];
                    string column3 = values[2];
                    // ...
                    Console.WriteLine(column1 + " " + column2 + " " + column3);
                }
            }
        }
    }
    class Program
    {
        //fetch data from excel
        static void bain(string[] args)
        {
            string filePath = "D:\\VisualStudioRepos\\AzureDevOps\\Coding\\Coding\\Csv_File\\Data.xlsx";
            Application excel = new Application();
            Workbook wb = excel.Workbooks.Open(filePath);
            Worksheet ws = wb.Worksheets["DATA"];

            var range = ws.UsedRange;

            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                    {
                        Console.WriteLine(range.Cells[i, j].Value2);
                    }
                }
            }

            wb.Close();
            Marshal.ReleaseComObject(ws);
            Marshal.ReleaseComObject(wb);
            Marshal.ReleaseComObject(excel);
        }
        //write data to csv file
        static void ain(string[] args)
        {
            // Specify the file path
            string filePath = @"D:\VisualStudioRepos\AzureDevOps\Coding\Coding\Csv_File\CsvData.csv";

            // Create a new StreamWriter object
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write the header row
                writer.WriteLine("Name, Age, Email");

                // Write some data
                writer.WriteLine("John Doe, 35, john@example.com");
                writer.WriteLine("Jane Doe, 28, jane@example.com");
                writer.WriteLine("Bob Smith, 42, bob@example.com");
            }

            Console.WriteLine("Data written to file.");
        }
    }
}
