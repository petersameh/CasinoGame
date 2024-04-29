using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public static class ExcelHelper
    {
       public static List<Question> ReadResource(string filePath)
        {
            int loop = 0;
            List<Question> questions = new List<Question>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Choose one of either 1 or 2:

                    // 1. Use the reader methods
                    do
                    { 
                        while (reader.Read())
                        {
                            if (loop == 0)
                            {
                                loop++;
                                continue;
                            }

                            questions.Add(new Question 
                            {
                                Id = int.Parse(reader[0].ToString()),
                                Type = reader[1].ToString(),
                                QuestionText = reader[2].ToString(),
                                Answer = reader[3].ToString(),
                                SourceFile = reader[4].ToString()
                            });
                            // reader.GetDouble(0);
                            loop++;
                        }
                    } while (reader.NextResult());

                    // 2. Use the AsDataSet extension method
                    var result = reader.AsDataSet();
                    return questions;

                    // The result of each spreadsheet is in result.Tables
                }
            }
        }
        
    }
}
