using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Aritsara
{



    internal abstract class Trash
    {
        public void Color()
        {

        }
    }
    class BiodegradableWast : Trash                 //ขยะย่อยสลายได้: ถังขยะ
    {
        private void Degradation() 
        {
        }
        public void color()
        {

            Console.WriteLine(" The Trash :Color Green"); //ถังขยะสีเขียว
        }
    }
    class Generalwaste : Trash                     //ขยะทั่วไป: ถังขยะ              
    {
        public void color()
        {
            Console.WriteLine(" The Trash :Color Yellow"); //ถังขยะสีเหลือง


        }
    }
    class Recyclewaste : Trash                   //ขยะรีไซเคิล: ถังขยะ
    {
        public void color()
        {
            Console.WriteLine("The Trash :Color Blue");   //ถังขยะสีเขียว
        }
    }
    class Hazardouswaste : Trash                 //ขยะอันตราย: ถังขยะ
    {
        public void color()
        {
            Console.WriteLine(" The Trash :Color Red");  //ถังขยะสีแดง
        }
    }
    class select //คลาสเลือก
    {
        public void Select()
        {
            string num = Console.ReadLine();
            if (num == "1")                   //ถ้าเลือก 1 จะแสดงผลเป็นถังขยะสีเขียว
            {
                BiodegradableWast bio = new BiodegradableWast(); //ขยะย่อยสลายได้
                bio.color();
            }
            else if (num == "2")             //ถ้าเลือก 2 จะเเสดงผลเป็นถังขยะสีเหลือง
            {
                Generalwaste whole = new Generalwaste();        //ขยะทั่วไป
                whole.color();
            }
            else if (num == "3")             //ถ้าเลือก 3 จะเเสดงผลเป็นถังขยะสีน้ำเงิน
            {
                Recyclewaste re = new Recyclewaste();          //ขยะรีไซเคิล
                re.color();
            }
            else if (num == "4")             //ถ้าเลือก 4 จะเเสดงผลเป็นถังขยะสีแดง
            {
                Hazardouswaste hazar = new Hazardouswaste();  //ขยะอันตราย
                hazar.color();
            }
            else
            {
                Console.WriteLine("error");  //ถ้าเลือกหมายเลขที่ไม่ใช่1-4จะเเสดงผลเป็น"error"
            }
        }
        class Program
        {

            static void Main(string[] args)
            {
                select t = new select();
                t.Select();
            }
        }
    }
}
       




