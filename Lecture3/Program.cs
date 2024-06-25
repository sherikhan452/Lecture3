using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
	internal class Program
	{

		//public static void sum(int a,int b)
		//{
		//	int result = a + b;
		//	Console.WriteLine("The Sum Result is: "+result);
			
		//}



		public static void sub(int c,int d)
		{
			int result=c - d;
			Console.WriteLine(result);
		}

		public static void add(int c, int d)
		{
			int result = c + d;
			Console.WriteLine(result);
			
		}

		public static void mul(int c, int d)
		{
			int result = c * d;
			Console.WriteLine(result);

		}

		public static void div(int c, int d)
		{
			int result = c / d;
			Console.WriteLine(result);

		}
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


			//Console.WriteLine("Continue Statement");

			//int d;

			//for (d=1;d<=10;d++)
			//{
			//	if (d==7)
			//	{
			//		continue;
			//	}

			//	Console.WriteLine(d);

			//}
			//Console.WriteLine("Loop Terminated");

			//Console.WriteLine("Break Statement");

			//int e;

			//for (e = 1; e <= 10; e++)
			//{
			//	if (e== 7)
			//	{
			//		continue;
			//	}

			//	Console.WriteLine(e);

			//}
			//Console.WriteLine("Loop Terminated");

			//Console.ReadLine();

			//int a;
			//for (a = 1; a<=10; a++)
			//{

			//	Console.WriteLine(4+"*"+a+"="+4*a);
			//}

			//int b = 1;
			//while (b < 10)
			//{
			//	Console.WriteLine(b);
			//	b++;
			//}

			//String confirm;
			//do
			//{
			//	Console.WriteLine("Enter Any num");
			//	int c=int.Parse(Console.ReadLine());
			//	Console.WriteLine("Enter Any num 2");
			//	int d = int.Parse(Console.ReadLine());

			//	int result = c + d;
			//	Console.WriteLine("The Addition is: "+result);
			//	Console.WriteLine("Do you want to CONTINUE Type\n Yes | No");
			//	 confirm=Console.ReadLine();
			//}

			//while (confirm=="Yes");



			//             Class 5             / /

			

			Console.WriteLine("Enter Any Num");
			int num1=int.Parse(Console.ReadLine());
			
			Console.WriteLine("Enter Any Num 2");
			int num2 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter Any Opr");
			string opr = Console.ReadLine();

			if (opr.Equals("+"))
			{
				Program.add(num1, num2);

			}
			else if (opr.Equals("-"))
			{
				Program.sub(num1, num2);
			}
			else if (opr.Equals("*"))
			{
				Program.mul(num1, num2);
			}
			else if (opr.Equals("/"))
			{
				Program.div(num1, num2);
			}
			else
			{
				Console.WriteLine("The Opr io Not Matched");
			}

			

			Console.ReadLine();


		}
	}
}
