using System.Runtime.Intrinsics.X86;

namespace ConsoleProgram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if문
            // 어떤 특정한 조건을 비교하여 조건이 맞다면 실행되는
            // 명령문입니다.
            // int monsterHP = 100;
            // 
            // // if의 조건이 거짓이면 if문이 실행되지 않습니다.
            // if(monsterHP > 0) // <- 조건이 들어가면 됩니다.
            // {
            //     // 내가 생각한 프로그램을 실행시켜주면 됩니다
            //     Console.WriteLine("몬스터가 아직 살아있습니다.");
            // }
            #endregion

            #region else if문
            // else if문이란?
            // if문의 조건이 틀릴 때 elsse if문의 조건이 맞다면
            // 실행되는 명령문입니다.


            // int playerHP = 100;
            // 
            // if (playerHP > 101)
            // {
            //     Console.WriteLine("캐릭터의 체력 100보다 큽니다.");
            // }
            // else if (playerHP > 90)
            // {
            //     // else if문은 계속 추가할 수 있습니다.
            //     Console.WriteLine("캐릭터의 체력은 90보다 큽니다. ");
            #endregion

            #region else 문
            // if문과 else if문의 조건이 다 틀리면
            // 실행되는 명령문입니다.

            int playerMP = 50;

            // A > B (>) : A가 B보다 크다.
            // A < B (<) : A가 B보다 작다.
            // A >= B (>=) : A가 B보다 크거나 같다.
            // A <= B (<=) : A가 B보다 작거나 같다.
            // A == B (==) : A와 B는 같다.
            // A != B (!=) : A와 B는 같지 않다.

            // if (playerMP == 100)
            // {
            //     Console.WriteLine("playerMP는 100입니다.");
            // }
            // else if(playerMP != 50)
            // {
            //     // else if문을 사용하려면 if문이 선언되어 있ㅑ 합니다.
            //     Console.WriteLine("playerMP는 50아닙니다.");
            // }
            // else
            // {
            //     // else문을 사용하려면 if문이 선언되어 있어야 합니다.
            //     // else if문은 없어도 됩니다.
            //     Console.WriteLine("해당 조건이 없습니다.");
            // }
            // 
            #endregion

            #region switch문
            // 어떤 결과에 따라 그 결과부터 실행되는 명령문입니다.
            // char alphabet = 'A';
            // 
            // switch (alphabet)
            // {
            //     case 'A': Console.WriteLine("A 입니다.");
            //         break;
            //     case 'B': Console.WriteLine("B 입니다.");
            //         break;
            //     case 'C': Console.WriteLine("C 입니다.");
            //         break;
            //     default : Console.WriteLine("예외 상황 발생");
            //         break;
            // }


            #endregion

            #region 상수
            // 프로그램이 실행되는 더 이상 변경할 수 없는
            // 메모리 공간입니다.

            // 컴파일 타임 상수 선언
            // 메모리 공간을 가지고 있는 상수를 심볼릭 상수라고 합니다.
            const int level = 99;

            // 메모리 공간을 가지고 있지 않은 상수를 리터럴 상수라고 합니다.
            // level = 255;

            // 원주율 3.14
            // NPC 이름 <- 상수

            #endregion

            #region for문
            // 초기식을 연산하여 조건식의 결과에 따라 특정한
            // 횟수만큼 반복하는 반복문입니다.

            // for문은 조건식이 계속 참이면 무한 반복됩니다.
            // for (int i = 1; i <= 5; i++)
            // {
            //     if (i == 3)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            //           3 * 5 15번 반복
            // for(int i = 0; i < 3; i++)
            // {
            //     //              5 반복
            //     for(int J = 0; J < 5; J++)
            //     {
            //         Console.WriteLine("Game");
            //     }
            #endregion

            #region 논리 연산자

            // AND 연산자
            // 두 개의 조건이 서로 같다면 실행되는 연산자입니다.

            // if (10 == 10 && 10 < 20)
            // {
            //    Console.WriteLine("두 개의 조건 성립됩니다.");
            // }
            // 
            // OR 연산자 (||)
            // 두 개의 조건 중 하나라도 참이면 실행되는 연산자입니다.
            // if(10 == 10 || 10 !=0)
            // {
            //    Console.WriteLine("한 개의 조건이 성립됩니다.");
            // }
            // 


            #endregion

            #region 사분면
            //사분면
            int x = 0;
            int y = 0;

            //  제 1 사분면 x가 0보다 크다면
            //             y가 0보다 크다면
            if(x > 0 && y > 0)
            {
                Console.WriteLine("제 1 사분면");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("제 2 사분면");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("제 3 사분면");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("제 4 사분면");
            }
            else if(y == 0 && x > 0 || x <0)
            {
                Console.WriteLine("x 절편");
            }
            else if (x == 0 && y > 0 || y < 0)
            {
                Console.WriteLine("y 절편");
            }
            else
            {
                Console.WriteLine("원점");
            }

            #endregion



        }
    }
}