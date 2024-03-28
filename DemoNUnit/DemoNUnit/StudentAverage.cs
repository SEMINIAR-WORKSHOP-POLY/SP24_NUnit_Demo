using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNUnit
{
    public class StudentAverage
    {
        public string getAverageRank(double averageScore)
        {
            if(averageScore < 0 || averageScore > 10)
            {
                throw new ArgumentException("Diem trung binh khong hop le, diem chi trong pham vi tu 0-10");
            }
            if(averageScore >= 9)
            {
                return "Xuất sắc";
            }else if(averageScore >= 8)
            {
                return "Giỏi";
            }
            else if (averageScore >= 7)
            {
                return "Khá";
            }
            else if (averageScore >= 5)
            {
                return "Trung bình";
            }
            else
            {
                return "Yếu";
            }
        }
    }
}
