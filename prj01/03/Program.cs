using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace prj_03
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Sử dụng kiểu vô danh (Anonymous type)
            var hs  = new { Ma = "C05", Ten = "Tran thi Lan", Tuoi = 20};
            Console.WriteLine("Doi tuong vo danh co Ma: {0} - Ten: {1} - Tuoi: {2}", hs.Ma, hs.Ten,hs.Tuoi);
            Console.Read();
		}
	}
}