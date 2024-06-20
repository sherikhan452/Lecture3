using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
	internal class Program
	{
		static void Main(string[] args)
		{


			/********************* Class 1 ***********************/

			//Console.WriteLine("Enter Student Name");
			//String name = Console.ReadLine();
			//Console.WriteLine("Enter Student Roll No");
			//int roll =int.Parse (Console.ReadLine());
			//Console.WriteLine("Enter Maths Marks");
			//int m = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter Urdu Marks");
			//int u = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter Physics Marks");
			//int P = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter Islamiyat Marks");
			//int I = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter Comp Scie Marks");
			//int cs = int.Parse(Console.ReadLine());

			//int total_marks = m + u + P + I + cs;
			////int mar = 500;
			//float marks_obt = total_marks * 100 / 500;


			//Console.WriteLine("Student Name is: "+name);
			//Console.WriteLine("Student Roll No is: " + roll);
			//Console.WriteLine("Student Maths is: " + m);
			//Console.WriteLine("Student Total Marks is: " + total_marks);
			//Console.WriteLine("Student Percentage is: " + marks_obt+"%");



			/********************* Class 2 **************************/

			//if (marks_obt>=80)
			//{
			//	Console.WriteLine("Hurray Your Grade is: A-1");
			//}
			// else if (marks_obt >= 70)
			//{
			//	Console.WriteLine("Yup Your Grade is: A");
			//}

			// else if (marks_obt >= 60)
			//{
			//	Console.WriteLine("Yup Your Grade is: B");
			//}

			// else if (marks_obt >= 50)
			//{
			//	Console.WriteLine("Keep it up Your Grade is: C");
			//}

			//else
			//{
			//	Console.WriteLine("Fail");
			//}



			/********************* Class 3  **************************/


			//int a;
			//Console.WriteLine("Enter Table Number");
			//int b=int.Parse(Console.ReadLine());

			//for (a=1;a<=10;a++)
			//{



			//	Console.WriteLine(b+ " * " +a+ " = "+b*a);

			//}




			//Jump Statement 


			Console.WriteLine("Continue Statement");

			int d;

			for (d=1;d<=10;d++)
			{
				if (d==7)
				{
					continue;
				}

				Console.WriteLine(d);

			}
			Console.WriteLine("Loop Terminated");

			Console.WriteLine("Break Statement");

			int e;

			for (e = 1; e <= 10; e++)
			{
				if (e== 7)
				{
					continue;
				}

				Console.WriteLine(e);

			}
			Console.WriteLine("Loop Terminated");



			Console.ReadLine();



		}
	}
}
