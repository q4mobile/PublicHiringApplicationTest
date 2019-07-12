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
            // now parse string fileContent in CsvTable object
            var result = new CsvTable();
            var rowsArr = ConvertToLines(fileContent);

            // header first
            var HeaderRow = new CsvRow();
            if (containsHeader)
            {
                HeaderRow = ConvertLinetoRow(rowsArr[0]);
            }
            result.HeaderRow = HeaderRow;
            // table rows
            var DataRows = new List<CsvRow>();
            if (rowsArr.Length > 0)
            {
                for (var i = (containsHeader ? 1 : 0); i < rowsArr.Length; i++)
                {
                    DataRows.Add(ConvertLinetoRow(rowsArr[i]));
                }
            }
            result.Rows = DataRows;

            return result;
        }
        // helper methods, here for now
        private string[] ConvertToLines(string text)
        {
            return text.Split(new[] { "\r\n", "\r", "\n" },StringSplitOptions.RemoveEmptyEntries);
        }
        // helper methods, here for now
        private CsvRow ConvertLinetoRow(string text)
        {
            // assuming a perfect formated csv
            var dataRow = new CsvRow();
            var rowCols = text.Split(',');
            for (var j = 0; j < rowCols.Length; j++)
            {
                var col = new CsvColumn(rowCols[j]);
                dataRow.Columns.Add(col);
            }
           return dataRow;
        }
    }

}
