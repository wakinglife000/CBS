using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammar
{
    class Program
    {
        static void Main(string[] args)
        {
            // do...while 반복문: while 조건이 참일 때만 do 내용 반복 실행
            string snum;
            int num;
            do
            {
                Console.Write("숫자를 입력하세요(끝낼 때는 0) ");
                snum = Console.ReadLine();

                //공백 예외처리
                if (string.IsNullOrEmpty(snum))
                {
                    Console.WriteLine("입력값이 없어 프로그램을 종료합니다.");
                    break;
                }

                num = Convert.ToInt32(snum);
             
                // quest1 : for -> foreach
                // quest2 : if ... else -> switch
                // quest3 : do ... while -> while

                // for 반복문
                int sum = 0;
                for (int i = 1; i <= num; i++)
                {
                    sum = sum + i;
                }

                // if...else 조건문
                if (num == 0)
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                }
                else
                {
                    Console.WriteLine("1~{0}까지의 합계는 {1}입니다.", num, sum);
                }
                

                /*quest2
                switch (num)
                {
                    case 0:
                        Console.WriteLine("프로그램을 종료합니다.");
                        break;

                    default:
                        Console.WriteLine("1~{0}까지의 합계는 {1}입니다.", num, sum);
                        break;
                }
                */

            /**/


            } while (num != 0); //0이 아니면(true) 계속 실행/ 0일 때(false) 중지
        }
    }
}
