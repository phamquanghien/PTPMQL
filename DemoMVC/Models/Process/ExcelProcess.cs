using ClosedXML.Excel;
using System.Reflection;
namespace DemoMVC.Models.Process
{
    public class ExcelProcess
    {
        public List<T> Read<T>(Stream stream, int sheetIndex = 1) where T : new()
        {
            var result = new List<T>();

            using (var workbook = new XLWorkbook(stream))
            {
                var worksheet = workbook.Worksheet(sheetIndex);
                var rows = worksheet.RangeUsed().RowsUsed();

                var headerRow = rows.First();
                var headers = headerRow.Cells()
                                       .Select((cell, index) => new
                                       {
                                           Name = cell.GetValue<string>().Trim(),
                                           Index = index + 1
                                       })
                                       .ToList();

                var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (var row in rows.Skip(1))
                {
                    var item = new T();

                    foreach (var prop in properties)
                    {
                        var header = headers.FirstOrDefault(h =>
                            h.Name.Equals(prop.Name, StringComparison.OrdinalIgnoreCase));

                        if (header == null) continue;

                        var cell = row.Cell(header.Index);
                        if (cell.IsEmpty()) continue;
                        var value = cell.GetValue<string>();
                        try
                        {
                            var convertedValue = Convert.ChangeType(value, prop.PropertyType);
                            prop.SetValue(item, convertedValue);
                        }
                        catch
                        {
                        }
                    }

                    result.Add(item);
                }
            }

            return result;
        }
    }
}