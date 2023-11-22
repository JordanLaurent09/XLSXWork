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
                string studentCode = studentsSheet.Cells[1, i + 1].Text;

                string? studentName = studentsSheet.Cells[2, i + 1].Text;

                string? studentSurname = studentsSheet.Cells[3, i + 1].Text;

                string studentAge = studentsSheet.Cells[4, i + 1].Text;

                string? studentFaculty = studentsSheet.Cells[5, i + 1].Text;

                string studentCourse = studentsSheet.Cells[6, i + 1].Text;

                string? studentGroup = studentsSheet.Cells[7, i + 1].Text;

                students.Add(new Student(studentName, studentSurname, studentAge, studentFaculty, studentCourse, studentGroup, studentCode));
            }

            return students;
        }

    }
}
