using System.Security.Cryptography.X509Certificates;

namespace ConsoleProgram3
{
    class GameObject
    {
        int scale;
    }

    internal class Program
    {
        #region 함수
        // 정적 변수
        // 프로그램이 실행될 때 메모리에 가게 되며,
        // 프로그램이 종료될 때 메모리에서 사라지는 변수입니다.

        // 함수란?
        // 하나의 특별한 목적의 작업을 수행하기 위해 독립적으로
        // 설계된 코드의 집합입니다.

        // 함수 선언 방법
        // (자료형) (함수의 이름) (매개 변수)
        // void : 값을 변환하지 않는 반환형입니다.
        static void Attack()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("공격");
            }
        }

        // 반환형이 존재하는 함수는 값을 무조건 변환해야 합니다.
        static int Damage()
        {
            // 값을 반환할 때 반환에 알맞는 자료형의
            // 값을 반환해야 합니다.
            return 100;
        }

        // 매개 변수란?
        // 함수의 정의에서 전달받은 인수를 함수 내부로
        // 전달하기 위해 사용하는 변수입니다.
        // static void Stat(int x) // <- 지역 변수
        // {
        //     Console.WriteLine("매개 변수 x의 값 : " + x);
        // }
        // static int Calculator(int x, int y)
        // {
        //     return x + y;
        // }
        static void ItemData(int count)
        {
            count += 100;
        }
        static void Main(string[] args)
        {
            // void 함수()   
            // Attack();
            //
            // // int 함수()
            // Console.WriteLine(Damage());
            //
            // // void 함수(int)
            // // 인수란?
            // // 함수가 호출될 때 매개 변수에 실제로
            // // 전달되는 값입니다.
            // Stat(100);
            //
            // // int 함수(int, int)
            // Console.WriteLine(Calculater(10, 20));

            #endregion
            #region
            // in 키워드
            static void ItemInformation(in int data)
            {
                // 읽기 전용
                Console.WriteLine("data의 값 : " + data);
            }

            // 재귀 함수
            // 어떤 함수에서 자신을 다시 호출하여 작업을
            // 수행하는 함수입니다.
            // static void Process(int count)
            // {
            //     Console.WriteLine("작업 처리");
            // 
            //     if(count == 1)
            //     {
            //         return;
            //     }
            //     
            //     Process(count - 1);
            // }
            // 
            #endregion
            #region 매개변수 한정자
            // int item = 100;
            // ItemData(ref item);
            //ItemData(item);

            // out 키워드 외부에 있는 변수를 초기화하지 않아도
            // 인수로 전달할 수 있습니다.
            // float ray;
            // 
            // RaycastHit(out ray);
            // 
            // Console.WriteLine("ray의 값 : " + ray);

            // out 키워드
            // static void RaycastHit(out float ray)
            {
                // out 키워드는 함수 내부에 값을 무조건
                // 초기화해주어야 합니다.
                // ray = 99.9f;
            }

            int dataBase = 30;
            ItemInformation(dataBase);

            #endregion

        }
    }
}