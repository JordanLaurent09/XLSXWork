using OfficeOpenXml;

namespace DGV_Excel_Operations
{
    static class ExcelWork
    {
        //private static List<Student> _students = new List<Student>();

        // получение данных из файла
        public static List<Student> GetExcelData()
        {
            LicenseContext lc = LicenseContext.NonCommercial;
            List<Student> students = new List<Student>();
            ExcelPackage studentsBook = new ExcelPackage("StudentData.xlsx");
            ExcelWorksheet studentsSheet = studentsBook.Workbook.Worksheets["Students"];

            for(int i = 0; i < studentsSheet.Workbook.Worksheets.Count; i++)
            {
                string studentCode = studentsSheet.Cells[i + 1, 1].Text;

                string? studentName = studentsSheet.Cells[i + 1, 2].Text;

                string? studentSurname = studentsSheet.Cells[i + 1, 3].Text;

                string studentAge = studentsSheet.Cells[i + 1, 4].Text;

                string? studentFaculty = studentsSheet.Cells[i + 1, 5].Text;

                string studentCourse = studentsSheet.Cells[i + 1, 6].Text;

                string? studentGroup = studentsSheet.Cells[i + 1, 7].Text;

                students.Add(new Student(studentName, studentSurname, studentAge, studentFaculty, studentCourse, studentGroup, studentCode));
            }

            return students;
        }

    }
}
