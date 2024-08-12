using System;

namespace TimViTriTrongMang
{
    class Program
    {
        static void Main(string[]args)
        {
            string[] students = {"Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};
            Console.Write("Nhap vao ten hoc sinh muon tim: ");
            string name= Console.ReadLine();
            while(true)
            {
                if (name is string)
                {
                    break;
                }
                else
                {
                    Console.Write("Nhap vao ten hoc sinh muon tim: ");
                }
               
            }
            int count=0;
            foreach(string nameStudents in students)
            {
                if(nameStudents==name)
                {
                    Console.WriteLine("Vi tri cua hoc sinh {0} la: {1}", name,Array.IndexOf(students, name));
                }   
                else
                {
                    count++;
                }             
            }
            while(true)
            {
                if (count==students.Length)
                {
                    Console.Write("Khong co sinh vien {0} trong danh sach!",name);
                    break;
                }
                else
                break;
            }
         
        }
    }
}