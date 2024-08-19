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
            bool check =false;  
            int i;
            for(i=0;i<students.Length;i++)
            {
                if(String.Compare(name,students[i],true)==0)
                {
                    Console.WriteLine("Vi tri cua hoc sinh {0} la: {1}", name,i);
                    check = true;                   
                }                          
            }            
            if (check==false)
            {
                Console.Write("Khong co sinh vien {0} trong danh sach!",name);                   
            }
             
            
        }
    }
}