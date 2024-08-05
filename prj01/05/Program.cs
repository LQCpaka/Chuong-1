using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace prj_05
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Khởi tạo mảng
            int[] myArr = {2, 1, 4, 5, 7, 6, 9, 8}
            // Khởi tạo đối tượng
            SINHVIEN sv = new SINHVIEN {MaSV = "C01", HoTen = "Tran Linh", Tuoi = 22}
            // Khởi tạo danh sách đối tượng
            List<SINHVIEN> sinhvienS = new List<SINHVIEN>
            {
                new SINHVIEN{MaSV="A01",HoTen="Le Thi Lan",Tuoi=21},
                new SINHVIEN{MaSV="A012",HoTen="Le Thi B",Tuoi=22},
                new SINHVIEN{MaSV="A013",HoTen="Le Thi C",Tuoi=23}
            }

            // Truy xuatt61 
            // 1. Truy xuất mảng
            foreach (int n in myArr){
                Console.Write("{0,5}",n);
            }
            Console.WriteLine
            

            // 2. Truy xuất đối tượng => xem bài trước

            // Truy xuất danh sách đối tượng
            foreach (SINHVIEN in sinhvienS){
                Console.Write("{0,5}",n);
            }
            Console.ReadLine();
		}

        
	}
}