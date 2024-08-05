using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace prj_04
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Áp dụng generic xây dựng hàm hoán vị
            int n1 =5, n2 = 7;
            Console.WriteLine("Truoc khi hoan vi: n1= {0}, n2 = {1}",n1,n2);
            HoanViNguyen(n1,n2);
            Console.WriteLine("Sau khi hoan vi: n1= {0}, n2 = {1}",n1,n2);
            
            
            string s1 = "Hello", s2 = "Goodbye";
            Console.WriteLine("Truoc khi hoan vi: s1 = {0}, S2={1}",s1,s2);
            HoanViChuoi(s1,s2);
            Console.WriteLine("Sau khi hoan vi: s1 = {0}, S2={1}",s1,s2);

            // Sử dụng generic cho các kiểu dữ liệu khác nhau như sau
            int a = 10, b b = 15;
            float x = 2.5f, y = 3.7f;
            string s3 = "HTML", s4 = "PHP";

            Console.WriteLine("Truoc khi hoan vi: a= {0}, b = {1}",a,b);
            HoanVi<int>(ref a, ref b);
            Console.WriteLine("Sau khi hoan vi: a= {0}, b = {1}",a,b);

            Console.WriteLine("Truoc khi hoan vi: a= {0}, b = {1}",x,y);
            HoanVi<float>(ref x, ref y);
            Console.WriteLine("Sau khi hoan vi: a= {0}, b = {1}",x,y);

            Console.WriteLine("Truoc khi hoan vi: a= {0}, b = {1}",s3,s4);
            HoanVi<string>(ref s3, ref s4);
            Console.WriteLine("Sau khi hoan vi: a= {0}, b = {1}",s3,s4);
            Console.Read();
		}

        // Hàm hoán vị hai số nguyên
        public static void HoanViNguyen(ref int a,ref int b){
            int temp = a;
            a = b;
            b = temp;
        }
        // Hàm Hoán vị 2 chuỗi
        public static void HoanViNguyen(ref string s1, ref string s2){
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }

        // 3. Sử dụng generic khai báo hàm hoán vị cho chuổi và số nguyên
        public staic void HoanVi<T>(ref T a, ref T b){
            T temp = a;
            a = b;
            b = temp;
        }
	}
}