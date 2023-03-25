namespace ConsoleProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수(Variable)란?
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
        }
    }
}