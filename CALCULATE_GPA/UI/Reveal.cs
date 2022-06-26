using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CALCULATE_GPA.Core;

namespace CALCULATE_GPA.UI
{
    internal class Reveal
    {
        public static void RevealDisplay()
        {
            Console.WriteLine("Kindly note that this program is for only 5 courses. Press 'Enter'.");
            Console.ReadLine();
            Console.WriteLine("Input your course & code");
            string courseCode1 = Console.ReadLine();
            Console.WriteLine("Input your course unit");
            string courseUnit1 = Console.ReadLine();
            Console.WriteLine("Input your score");
            double score1 = Convert.ToDouble(Console.ReadLine());
            string grade1 = GPA_Calculation.FindGrade((int)score1);
            int unit1 = GPA_Calculation.FindUnit(grade1);
            int weightPt1 = GPA_Calculation.FindWeightPt(courseUnit1, unit1);
            string remark1 = GPA_Calculation.GetRemark(grade1);

            Console.WriteLine("Input your course & code");
            string courseCode2 = Console.ReadLine();
            Console.WriteLine("Input your course unit");
            string courseUnit2 = Console.ReadLine();
            Console.WriteLine("Input your score");
            double score2 = Convert.ToDouble(Console.ReadLine());
            string grade2 = GPA_Calculation.FindGrade((int)score2);
            int unit2 = GPA_Calculation.FindUnit(grade2);
            int weightPt2 = GPA_Calculation.FindWeightPt(courseUnit2, unit2);
            string remark2 = GPA_Calculation.GetRemark(grade2);

            Console.WriteLine("Input your course & code");
            string courseCode3 = Console.ReadLine();
            Console.WriteLine("Input your course unit");
            string courseUnit3 = Console.ReadLine();
            Console.WriteLine("Input your score");
            double score3 = Convert.ToDouble(Console.ReadLine());
            string grade3 = GPA_Calculation.FindGrade((int)score3);
            int unit3 = GPA_Calculation.FindUnit(grade3);
            int weightPt3 = GPA_Calculation.FindWeightPt(courseUnit3, unit3);
            string remark3 = GPA_Calculation.GetRemark(grade3);

            Console.WriteLine("Input your course & code");
            string courseCode4 = Console.ReadLine();
            Console.WriteLine("Input your course unit");
            string courseUnit4 = Console.ReadLine();
            Console.WriteLine("Input your score");
            double score4 = Convert.ToDouble(Console.ReadLine());
            string grade4 = GPA_Calculation.FindGrade((int)score4);
            int unit4 = GPA_Calculation.FindUnit(grade4);
            int weightPt4 = GPA_Calculation.FindWeightPt(courseUnit4, unit4);
            string remark4 = GPA_Calculation.GetRemark(grade4);

            Console.WriteLine("Input your final course & code");
            string courseCode5 = Console.ReadLine();
            Console.WriteLine("Input your course unit");
            string courseUnit5 = Console.ReadLine();
            Console.WriteLine("Input your score");
            double score5 = Convert.ToDouble(Console.ReadLine());
            string grade5 = GPA_Calculation.FindGrade((int)score5);
            int unit5 = GPA_Calculation.FindUnit(grade5);
            int weightPt5 = GPA_Calculation.FindWeightPt(courseUnit5, unit5);
            string remark5 = GPA_Calculation.GetRemark(grade5);

            string[] allCourseUnit = { courseUnit1, courseUnit2, courseUnit3, courseUnit4, courseUnit5 };
            int[] allWeightPt = { weightPt1, weightPt2, weightPt3, weightPt4, weightPt5 };
            int[] allUnit = { unit1, unit2, unit3, unit4, unit5 };



            Console.WriteLine("|-------------------|------------------|-----------|------------------|--------------|-------------|");
            Console.WriteLine("|  Course & Code    |    Course Unit   |   Grade   |    Grade-Unit    |   Weight Pt  |   Remark    |");
            Console.WriteLine("|-------------------|------------------|-----------|------------------|--------------|-------------|");
            Console.WriteLine($"        {courseCode1}      |          {courseUnit1}       |      {grade1}    |        {unit1}         |     {weightPt1}       |   {remark1}               ");
            Console.WriteLine($"        {courseCode2}      |          {courseUnit2}       |      {grade2}    |        {unit2}         |     {weightPt2}       |   {remark2}               ");
            Console.WriteLine($"        {courseCode3}      |          {courseUnit3}       |      {grade3}    |        {unit3}         |     {weightPt3}       |   {remark3}               ");
            Console.WriteLine($"        {courseCode4}      |          {courseUnit4}       |      {grade4}    |        {unit4}         |     {weightPt4}       |   {remark4}               ");
            Console.WriteLine($"        {courseCode5}      |          {courseUnit5}       |      {grade5}    |        {unit5}         |     {weightPt5}       |   {remark5}               ");
            Console.WriteLine("|--------------------------------------------------------------------------------------------------|");

            Console.WriteLine($"Total Course Unit Registered is {GPA_Calculation.AddCourseUnits(allCourseUnit)}");
            Console.WriteLine($"Total Course Unit Passed is {GPA_Calculation.AddPassedCourseUnits(allCourseUnit, allUnit)}");
            Console.WriteLine($"Total Weight Point is {GPA_Calculation.AddWeightPts(allWeightPt)}");
            Console.WriteLine($"Your GPA is = {GPA_Calculation.CalculateGPA(allCourseUnit, allWeightPt)} to 2 decimal places.");
            
        }

    }
}
