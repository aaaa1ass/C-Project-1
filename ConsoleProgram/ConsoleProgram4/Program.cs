using System.Collections;
using System.Runtime.Serialization.Formatters;

namespace ConsoleProgram4
{
    // 클래스
    // 사용자 정의 데이터 유형으로 속성과 포함되어
    // 있으며, 클래스를 통해 객체를 생성하여 접근하고 사용할
    // 수 있는 집합체입니다.

    class Monster
    {
        // 접근 지정자

        // 기본 접근 지정자가 private로 설정됩니다.

        // public : 클래스의 속성을 어디에서든지 접근할 수 있는
        // 접근 지정자입니다.

        // private : 클래스의 속성을 내부에서만 할 수 있으며,
        // 외부와 자기가 상속하고 있는 클래스에서는 접근이 불가능한 접근 지정자입니다.

        // protected : 클래스의 속성을 내부와 자기가 상속하고 있는 클래스에서만
        // 접근이 가능하며, 외부에서는 접근이 불가능한 접근 지정자입니다.

        // 바이트 패딩이란?
        // 멤버 변수를 메모리에서 CPU로 읽을 때
        // 한 번에 읽을 수 있도록, 컴파일러가 
        // 레지스터 브롥에 맞추어 바이트 패딩 해주는
        // 최적화 작업입니다.

        public char grade;     // 1 BYTE
        private int health;    // 4 BYTE
        public double defense; // 8 BYTE

        public void Attack()
        {
            Console.WriteLine("공격");
        }
    }

    class Unit
    {
        // 상속이란?
        // 상위 클래스의 속서을 하위 클래스가 사용할 수
        // 있도록 설정해주는 기능입니다.

        public string name;
        protected int health;
        private float killScore;

        // 생성자
        // 클래스의 인스턴스가 생성되는 시점에서 자동으로 
        // 호출되는 특수한 멤버 함수입니다.
        public Unit()
        {
            // 생성자의 경우 객체가 생성될 때 단 한 번만 호출되며,
            // 생성자는 반환형이 존재하지 않습니다.
            Console.WriteLine("Unit 클래스가 생성되었습니다.");
        }
    }

    class Marine : Unit
    {
        public Marine()
        {
            Console.WriteLine("Marine 클래스가 생성되었습니다.");
        }

        // 함수의 오버로딩
        // 같은 이름의 함수를 매개 변수의 자료형과 매개변수의 갯수로
        // 구분하여 여러 개를 선언할 수 있는 기능입니다.

        public void Skill()
        {
            Console.WriteLine("Steam Pack");
        }
        
        public void Skill(int damage)
        {
            Console.WriteLine("damage : " + damage);
        }

        public void Skill(string name)
        {
            Console.WriteLine("skill name : " + name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 클래스
            // Monster monster1 = new Monster();
            //
            // monster1.grade = 'A';
            // monster1.Attack();
            //
            // Monster monster2 = new Monster();
            //
            // monster2.grade = 'B';
            // monster2.Attack();
            #endregion

            #region 배열
            // 같은 자료형의 변수들로 이루어진 유한 집합입니다.
            //
            // 배열의 선언
            // int 4 BYTE * 5 = 20 BYTE
            // int[] itemList = new int[5];
            // 
            // 배열의 경우 첫 번째 원소는 0 부터 시작합니다.
            // itemList[0] = 10;
            // itemList[1] = 20;
            // itemList[2] = 30;
            // itemList[3] = 40;
            // itemList[4] = 50;
            //
            // 배열은 원하는 원소에 값을 저장할 수 있으며,
            // 배열의 크기는 컴파일 되는 시점부터 고정된
            // 메모리 공간을 가지게 됩니다.
            // for (int i = 0; i < itemList.Length; i++);
            // {
            //     Console.WriteLine("itemList[i]");
            // }
            #endregion

            #region 박싱과 언박싱
            // 값 타입 : byte, bool, chat, short, int, long, double, decimal, struct
            // 참조 타입 : Class, array, Delegate, object
            //
            // 박싱이란?
            // 값 형식을 참조 형식으로 변환해주는 과정입니다.
            //
            // int data = 100; // 값 타입
            // 
            // object obj = data; // 참조 타입
            // Console.WriteLine(obj);
            // 
            // 언박싱이란?
            // 참조형식을 값 형식으로 변환하는 과정입니다.
            // 
            // int result = (int)obj;
            // Console.WriteLine(result);
            // 
            // ArrayList arrayList = new ArrayList();
            // arrayList[0] = 10;
            // arrayList[1] = "Kim";
            #endregion

            #region 상속
            // Unit unit = new Unit();
            Marine marine = new Marine();
            marine.Skill("Steam Pack");
            marine.Skill(5);

            #endregion

            #region 네이밍 컨벤션

            // 네이밍 컨벤션

            // camel case(카멜 표기법) <- 변수, 매개 변수
            // 첫 번째 단어를 제외하고 첫 글자를 대문자로 표기하는 표기법입니다.
            // ex) int countDown;

            // pascal case(파스칼 표기법) <- 함수, 클래스 이름, 구조체 이름
            // 단어의 첫 글자를 대문자로 표기하는 표기법입니다.
            // ex) int PlayerHealth;

            // snake case(스네이크 표기법}
            // 전부 소문자로 표기하고, 단어 사이에 _를 표기하는 표기법입니다.
            // ex) data_player
            
            
            #endregion
        }
    }
}