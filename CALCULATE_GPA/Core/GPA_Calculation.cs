using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATE_GPA.Core
{
    internal class GPA_Calculation
    {
        public static string FindGrade(int score)
        {
            string grade = "";
            return score >= 70 && score <= 100 ? grade += "A" :
                   score >= 60 && score <= 69 ? grade += "B" :
                   score >= 50 && score <= 59 ? grade += "C" :
                   score >= 45 && score <= 49 ? grade += "D" :
                   score >= 40 && score <= 44 ? grade + "E" :
                   grade += "F";
        }

        public static int FindUnit(string grade)
        {
            int unit = 0;
            return grade == "A" ? unit += 5 :
                   grade == "B" ? unit += 4 :
                   grade == "C" ? unit += 3 :
                   grade == "D" ? unit += 2 :
                   grade == "E" ? unit += 1 :
                   unit += 0;
        }

        public static string GetRemark(string grade)
        {
            string remark = "";
            return grade == "A" ? remark += "Excellent" :
                   grade == "B" ? remark += "Very Good" :
                   grade == "C" ? remark += "Good" :
                   grade == "D" ? remark += "Fair" :
                   grade == "E" ? remark += "Pass" :
                   remark += "Fail";
        }

        public static int FindWeightPt(string courseUnit, int gradeUnit)
        {
            return int.Parse(courseUnit) * gradeUnit;
        }

        public static int AddCourseUnits(string[] courseUnit)
        {
            return courseUnit.Sum(int.Parse);
        }

        public static int AddWeightPts(int[] weightPt)
        {
            return weightPt.Sum();
        }

        public static void ValidateInput(string[] courseUnit)
        {
            if (courseUnit.Where(char.IsDigit).Count() != 5) throw new ArgumentException();  

        }

        public static int AddPassedCourseUnits(string[] courseUnit, int[] gradeUnit)
        {
            int totalCourseUnitPassed = 0;
            for(int i = 0; i < courseUnit.Length; i++)
            {
                if(gradeUnit[i] > 0)
                {
                    totalCourseUnitPassed += Convert.ToInt32(courseUnit[i]);
                }
            }return totalCourseUnitPassed;
        }

        public static string CalculateGPA(string[] courseUnit, int[] weightPt)
        {
            return (weightPt.Sum() / courseUnit.Sum(double.Parse)).ToString("F2");
        }

         

    }
}
