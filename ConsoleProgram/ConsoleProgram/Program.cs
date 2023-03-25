namespace ConsoleProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 변수(Variable)
            /*
            // 데이터를 저장할 수 있는 메모리 공간을 생성하는 것입니다.

            // bool -> 1 byte (참과 거짓)
            // char -> 1 byte (문자)
            // short -> 2 byte (정수)
            // int -> 4 byte (정수)
            // float -> 4 byte (실수)
            // double -> 8 byte (실수)

            // =(대입 연산자) : 오른쪽에 있는 피연자의 값을  
            // 왼쪽에 있는 변수에 저장하는 연산자입니다.
            char grade = 'S';
            int health = 100; 
            float attack = 36.5f;

            // Console.WriteLine( ) : 특정한 문자열을 출력하는 함수 (개행이 실행됩니다.)
            Console.WriteLine("grade 변수의 값 : " + grade);
            Console.WriteLine("Hello, World!");

            // Console.Write( ) : 특정한 문자열을 출력하는 함수 (개행이 실행되지 않는다.)
            Console.Write("health 변수의 값 : " + health + " / ");
            Console.Write("attack 변수의 값 : " + attack);
            */
            #endregion


            #region 프로그램 실행 순서

            // true(참) 1
            // false(거짓) 0

            bool condition = true;
            condition = false;

            int data = 100;
            data = 999;

            float pi = 3.141592f;
            pi = 5.5f;

            #endregion
        }
        #region 변수의 이름 규칙

        // 1. 변수의 이름은 숫자로 사용할 수 없습니다.
        // ex) int 1count = 0;

        // 2. 변수의 이름으 키워드를 사용할 수 없습니다.
        // ex) int int = 0;

        //3. 변수의 이름에 공백이 포함될 수 없습니다.
        // ex) int league of = 10;

        // 4. 변수의 이름으로 특수문자 "_"만 가능합니다.
        // ex) int count_down = 50;

        // 5. 변수의 대소문자를 구분합니다.
        // ex) int value = 99;
        // ex) int VALUE = 20;

        // 6. 변수의 이름은 중복될 수 없습니다.
        #endregion

    }
    
}