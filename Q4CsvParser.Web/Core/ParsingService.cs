using System;
using System.Collections.Generic;
using Q4CsvParser.Contracts;
using Q4CsvParser.Domain;

namespace Q4CsvParser.Web.Core
{
    /// <summary>
    /// This file must be unit tested.
    /// </summary>
    public class ParsingService : IParsingService
    {
        /// <summary>
        /// Accepts a string with the contents of the csv file in it and should return a parsed csv file.
        /// </summary>
        /// <param name="fileContent"></param>
        /// <param name="containsHeader"></param>
        /// <returns></returns>
        public CsvTable ParseCsv(string fileContent, bool containsHeader)
        {
            //TODO fill in your logic here
            //throw new NotImplementedException();

            // now parse string fileContent in CsvTable object
            var result = new CsvTable();

            // for now to avoid mixed EOF
            string content = fileContent.Replace("\r\n", "\n"); 
            var rows = content.Split('\n');

            //header first
            if (containsHeader)
            {
                var HeaderRow = new CsvRow();

                result.HeaderRow = HeaderRow;
            }
            if (rows.Length > 0)
            {
                var DataRows = new List<CsvRow>();

                for(var i=0; i<rows.Length; i++)
                {
                    var dataRow = new CsvRow();

                    var rowCols = rows[i].Split(',');
                    for (var j = 0; j < rowCols.Length; j++)
                    {
                        // each column value
                        var col = new CsvColumn(rowCols[j]);
                        dataRow.Columns.Add(col);
                    }
                    DataRows.Add(dataRow);
                }
                result.Rows = DataRows;
            }
            return result;
        }
    }

}
