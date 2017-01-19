using System;

/*
    변수, 상수
    변수 : 값을 저장할 수 있는 메모리 공간
    - 정수형, 실수형, 문자형, 논리형, 특수형 
    정수형 : int, byte, short, long 
    -> signd , unsignd 부호의 
    -> 정수형이 담을 수 있는 용량의 범위(진법, 보수)
    실수형 : float, double, demical
    -> 범위값이 아닌 최소, 최대값 그리고 정밀값 이라고 표현 한다.
    -> float 소수점 6째 자리, double 는 소수점 15번 째 자리
    문자형 : char , string 
    -> cahr 2byte 유니코드 사용
    논리형 : bool
    -> true , false
    특수형 : var

    변수 선언 : 타입 변수 : ;
    
    상수 : 값을 변경할 수 없는 메모리 공간
    reteral : 값이 이름인 상수
    
    symbolic : 값과 별개로 이름을 따로 가지고 있는 상수 
    const : 

    - 접미사 : 상수들도 자료형이 존재한다. 그 형을 다른 형으로 변할 수 있다.(float)
      (실수 상소의 기본형은 double)


    연산자 

    조건문, 분기문

    반복문

    메모리 영역

  메서드 == 함수(기능)
  - "기능"들을 묶은 최소의 단위
  -프로그램의 기능 최소 단위
  -메서드명 기능을 대변한다.

    메서드의 종류
    -일반 메서드, 정적 메서드
    일반 메서드 : 객체.메서드명(값)
    정적 메서드 : static이 붙는 메서드 클래스명.메서드명(값)

    메서드 사용 방법
    한정자 반환타입 메서드명(매개변수){}

    한정자   : public, protected, private
    반환타입 : int, void, float
    메서드명 : 여러가지... 기능에 대한 메서드 명들

    일반 메서드에서 메서드 명을 사용 할 수 있다.(this call의 의미)
    this call : 메서드 자기 자신이기 때문에 사용 가능 함
    Ex) 
    int m_Num = 10;
    public void NomalM()
    {
    this.m_Num = 1;
    }

    반환 타입 앞에 아무것도 없을 경우 private가 생략 되어있다.
    정적 메서드에서 메서드를 사용하려면 Static로 선언 한 메서드가 필요하다.
    EX) 
    Static int m_SNum = 10;
    Static public void StaticM()
    {
       m_SNum = 0;
    }
////////////////////////////////////////
  매개변수
  - 외부값으로 초기화 하는 메서드 내의 지역 변수
  멤버변수 : 클래스 내부에 속해있는 변수, 해당 객체가 살아있는 동안 계속 유지
  지역변수 : {} 특정 지역 내에서 사용, 지역이 끝남과 동시에 소멸되는 변수
 
    매개변수에서 사용하는 키워드
    _ Out : 출력강제(무조건 한번은 대입해줘야 한다. 값이 아닌 위치)
    - Ref : 참조(읽기,쓰기 둘 다 가능, 입력해놓고 아무것도 안 해도 됨)
    -> 연관성이 없는 것들이 여러개 일 때 사용 함.

    디폴트(선택적) 매개변수
    -매개변수의 기본값을 미리 지정
    - 초기화값이 없을경우 기본값으로 초기화

     ex) void test(int _Num = 10);
         void test();
      test(100);, test();
      반환타입, 메서드명, 매개변수가 달라 오버로딩 정의법은 성립하지만
      호출 형태가 같아 둘중에 하나만 호출 되거나 둘 다 호출이 안될 수 있다.
     
    메서드 오버로딩
     - 반환타입에 관계없이 메서드명은 같고, 매개변수가 다른 메서드 정의법
     - 궁국적으로 호출형태가 다른 메서드 정의법
    
    가변길이 매개변수
    - 배열을 바꾸고 싶을 때 (int 밖에 못 씀. 대신에 매개변수의 길이를 무한정으로 늘릴 수 있음)
    int Sum(params int[]arg)
    {
    }

    명명된 매개변수
    -호출하는 순간 값을 대입한다.
    void Test2(int _Score, string _Name){}
    Test2(100, "김명길"); - 일반적으로 사용하는 방법
    Test2(_Name : "김명길", _Score:100) - 네임태그를 붙여서 순서에 관계없이 사용 가능


     객체 지향 프로그래밍(OOP)
    - 모든 데이터를 객체로 취급하여 그 스스로만으로도 동작하고,
      다른 객체의 부품으로도 사용할 수 있도록 프로그래밍 하는 방식

     클래스
     - 데이터와 기능을 하나의 자료형으로 구현할 수 있는 문법

    객체
    - 클래스로 생성된 변수

    클래스 정의 방법
    class 클래스명
    {
     
    }

    객체 선언 방법
    한정자
    - public 외부접근 가능
    - prtected 외부접근 불가능 (파생 클래스만 허용)
    - private 외부접근 불가 내부에서만 사용 가능

    클래스 객체 = new 클래스

    생성자 소멸자
     - 객체가 생성된 직후 자동으로 호출하는 메서드
     - 반환타입이 없음, 메서드 오버로딩 가능
     - 정의하지 않을 경우 기본 생성자 제공
     - 생성시 매개변수를 넣을 수 있음
    
    생성자 문법
    public 클래스명(매개변수)
    {
      
    } 
    public 클래스명(변수1,변수2...)
    {
    }
    클래스명 객체명 = new 클래스명(값,값,값...)
    ///////////////////////////////////////////////////////
    소멸자

    - 객체가 소멸하기 직전에 호출하는 메서드
    - ~클래스명(), 메서드 오버로딩x 
    - 정의하지 않을경우 기본 소멸자 제공
        
                 ( 컴 파 일   시   크 기 가  결 정)    (run time시에 크키가 결정)
    메모리영역    code   -               data -   bss -     heap -   stack
    함수 제어문 상수 영역(신경 ㄴㄴ) 전역변수 전역변수  동적할당  지역변수
                                     (정적변수 ,상수들) (실시간) (heap의 위치값)
   동적할당 : heap에 저장 된 데이터(new를 사용해서 선언하는 모든 메서드들)
   heap에 할당된다 -> stack에 heap의 위치값을 가지고 heap에는 값이 있는것.
   정적할당 : 무조건 stack에만 저장 된 데이터
   자료구조에서 후입선출 방식의 그대로 따다 써서 stack이라고 부른다.
   
    - code 영역 : 실행코드(제어문, 함수 등등)
    - stack 영역 : 힙의 위치값, 메모장같은, 잡다한것
                   지역변수, 메서드 호출 위치
    - Heap 영역 : 동적할당된 데이터
    - data, bss : 프로그램실행시에 생성되서, 프로그램이 종료시에 없어지는
                  정적변수, 상수
     일반변수 정적할당 : 스택
     클래스는 동적할당 : 힙(스택 : 힙의 위치, 힙 : 실제 값)

    얕은 복사 깊은 복사
    얕은 복사 : 일반적인 복사(대입)
                스택값 대입
    얕은복사는 힙의 위치가 같아서 힙이 바뀌면 스택의 값이 둘 다 바뀌는게 단점
    int B = 10;
    int A = B; // 초기화: 1. 선언과 동시에 값을 "대입"하는 행위
                          2. 선언된 이후 최초로 값을 대입하는 행위(초기화 X)
    A=B;
    
    깊은 복사 : 일반적으로 알고있는 복사(따로따로)
    얕은복사와 달리 힙에 같은 값을 하나 더 만들어서 힙이 스택이 따로따로 
    대입하게 된다.
              
  - this
    class Test
    {
     public int m_Num;
     piblic vod Methood();
     {
      // 객체의 멤버변수를 자유롭게 접근할 수 있다.
      this : 해당 메서드 호출하는 객체
      정적메서드는 객체가 없기 때문에 this를 쓸 수 없다.(class의 하위 개념이기 때문)

    상속
     -기존 클래스로 새로운 클래스를 만드는 문법

    public 과 portected는 사용 가능,  private는 사용 불가능
   (내,외부)(외부접근x 파생만 가능). (내부만 접근)
   
    특성 
     -부모의 클래스 변수에 자식 객체의 주소 값을 담을 수 있다.
       Top A =  new Bottom();
      (스택)    (힙)
       
   base(기반클래스) 생성자
   - 호출 순서 부모 -> 자식 순서
   - 소멸 순서 자식 -> 부모 순서
   - 생성자 : base  -> 자식이 부모의 원하는 생성자를 호출 할 수 있다.

    is 연산자
    - 값을 확인하는 연산자 
    - 맞으면 true, 틀리면 false

   -as 연산자 
    - 형 변환 연산자

    - 형 변환 성공 시 - 역할 수행
    - 형 변환 실패 시 - null값( 주소값이 없다)
    /////////////////////////////////////////////////////////////
    
   다형성
   - 부모 클래스 변수(스택 부분)
   - 다른 자식 객체의 주소값을 대입해여, 다른 기능을 수행하는 방식

   - 부모클래스의 형태를 재정의 하는 메서드 정의법
    (자식 메서드 발동 시 부모 메서드 숨김)
   - 부모와 자식 메서드 판별을 위해 virtual 키워드 사용

    오버로딩, 오버라이딩 차이점
   - 프로토타입이 같은지 다른지의 차이

    상속
          부모와 자식

    부모클래스
    (다형성)
     하나의 객체 : 부모 클래스 변수
     Top A;
     여러 형태 : 자식 객체
     new BottomA(); 

     문제 1 : 부모밖에 모른다.
     해결법 : 오버라이딩(부모의 메서드를 동일하게 쓰고 재정의 하는것) 

     문제 2 : 부모클래스에서 호출하면 부모메서드가 호출
     해결법 : virtual
      -> (전제) 부모변수가 가상 메서드를 호출 할 경우 실제 메모리에서 호출하는
      메서드를 확인하여 호출 하도록 하는 키워드
         
    인터페이스와 추상클래스
    *다형성의 특성을 사용하기 위한 문법*
     
    * 부모클래스라는 껍데기(인터페이스와 추상클래스)
    
    인터페이스
    - 객체화 불가능(공통점)
    - 100% 가죽(아무것도 넣을 수 없다)

    추상클래스
    - 객체화 불가능(공통점)
    - 살점붙은 가죽( 자식클래스에 상속을 주기 위해)

    프로퍼티 (내부 외부와 관계 없이 접근제어)
    - 멤버에 대한 접근자(get,set) 관련 문법
    - 접근에 대한 세밀한 조정(정보 은닉)
    - set을 막아버리면 내부에서 쓸 수 없다.
    - 접근제어 문법(한정자와는 다른 개념)
    ex)
    class sample
 {
    int m_Num = 10;
    public int Data
    {
        get
        {
            return m_Num;
        }
        //Data = value;
        set { m_Num = value; }
    }
     public bool MyData
    {
        get
        {
            return m_Num > 10;
        }
            
    }
 }
   프로퍼티 생성자 (한정자가 public 일 때 가능함)  
    static void Main(string[]args)
     {
      sample temp = new sample();
      {
        Data = 10;
        MyData = true;
      };
     }

    2차원 배열
   차원 : 특이점을 구분하는데 필요한 정보의 개수
   1차원 : 선 상의 점
   2차원 : 면 상의 선
   3차원 : 공간상의 면
         -> int[][] A = new int[3][];
                 A[0] = new int[30];
                    
   4차원 : 같은 공간의 시간대가 다름 or 같은 지점인데 정보가 다름
   (구분점의 개수가 4가지)

    스택 : 후입선출  -> 리버스에 사용
    게임의 커멘드 일부 예로 들 수 있음
    Push, Pop,     Top,     Overflow,    Underflow 
    넣기, 빼기, 뺀 맨 위값,    넘침,     비어있음
 

배열

인덱서
복합데이터
기본 자료형(int는 기본 자료형)
int a = 1

사용자정의 자료형
클래스, 구조체
=
연산자 오버로딩(C++)
1. 연산자의 기능 추가 정의
2. 연산자 정의

클래스  A,B ;
클래스2 C;

A = C; // 연산자 오버로딩1 (다른 클래스의 변수를 쓸 수 있게 해준다)
A *= C; //연산자 오버로딩2 (새로운것을 추가 함)

A[3] = 10;
배열처럼 사용 할 수 있는 문법
ex)
class MyList
{
int[] m_Data;
 public MyList( int _Size = 5)
 public int this[ int _index ]
 {
 get {
 if( m_Data.Lenght < _Index)
 return m_Data[_Index];
 else
 return 
 }
 set { m_Data[_Index] = value}
}
내부 문제가 발생할 수 있지만 절대 튕기면 안된다.(안정성)

절차지향 프로그래밍 (어떻게 만들었냐)
객체지향 프로그래밍 (어떻게 만들었냐)
관점지향 프로그래밍 (어떻게 만들었냐)

일반화 프로그래밍(무엇으로 만들었냐)
 - 일반화 문법을 사용하여 임의의 타입에서 기능하는 프로그래밍 코드 작성법

    절대 법칙!!
    - 1 기능      1 메서드
    - 1 메서드명 다 메서드
 ------------------------------------------
    -> 사용하는 데이터는 다름
    실행되는 기능은 동일
 -------------------------------------------
    자동 메서드 오버로딩 문법(정확한 명칭)
    class Program
    {
    static void temp Normal(int _Num)
    {
        Console.WriteLine("Normal :" + _Num);
    }
    static void temp<T>( T _Num)
    {
        Console.WriteLine("Normal :" + _Num);
    }
    static void temp<T>()
    {
        Console.WriteLine("오버로딩");
    }
    static void Main(string[] args)
        {
        }
    }

    값을 넣어 주면 자동으로 변수를 생성
    Temp(10); -> 정수형
    Temp("d"); -> 문자형

    Temp<int> -> 정수형 (다른 방식)
    class program
{
    static void Temp<T>(T _Num)
    {
        Console.WriteLine("Temp :" + _Num);
    }

static void Main(string[] args)
{
        Temp("한원식");
        Temp("26세");
 }

}

   컬렉션
    -스택
    -큐
    -리스트 
     선형 원형
    
*/
/* class Program
    {
    static void temp Normal(int _Num)
    {
        Console.WriteLine("Normal :" + _Num);
    }
    static void temp<T>( T _Num)
    {
        Console.WriteLine("Normal :" + _Num);
    }
    static void temp<T>()
    {
        Console.WriteLine("오버로딩");
    }
    static void Main(string[] args)
        {
        }
    }*/
/*class program
{
static void Main(string[] args)
{
    //시작
    StreamWriter Sw = new StreamWriter("Temp.txt");

    Sw.WriteLine("아이스크림.. 선생님만 못 먹음..");
    Sw.WriteLine("개이득..ㅋㅋ");

    //끝
    Sw.Flush();
    Sw.Close();

    //읽기
    StreamReader Sr = new StreamReader("Temp.txt");

    Console.WriteLine(Sr.ReadLine());
    Console.WriteLine(Sr.ReadLine());

    Sr.Close();
}
}*/


/* 클래스 연산자 오버로딩 
   -> 클래스에서 연산자의 기능을 정의 또는 재 정의 하는 것

     클래스 : 데이터와 관련기능을 모은 사용자정의 자료형
     연산자 : 특정 기능을 수행하는 기호
     오버로딩 : 여러 의미가 부여되는 것(다기능)

            (복소수 : 실수 + 허수 ex) 3+2i)
public class Complex
{
    public int m_Real = 0;
    public int m_Img = 0;

    public Complex(int _Real = 0, int _Img = 0)
    {
        m_Real = _Real;
        m_Img = _Img;
    }
    //Left + Right 연산자 
    public static Complex operator +(Complex _Left, Complex _Right)
    {
        return new Complex(_Left.m_Real + _Right.m_Real, _Left.m_Img + _Right.m_Img);
    }
    public static Complex operator -(Complex _Left, Complex _Right)
    {
        return new Complex(_Left.m_Real - _Right.m_Real, _Left.m_Img - _Right.m_Img);
    }
    public static Complex operator *(Complex _Left, Complex _Right)
    {
        return new Complex(_Left.m_Real * _Right.m_Real - _Left.m_Img * _Right.m_Img, _Left.m_Real * _Right.m_Img + _Left.m_Img * _Right.m_Real);
    }
    public static Complex operator /(Complex _Left, Complex _Right)
    {
        return new Complex(_Left.m_Real / _Right.m_Real, _Left.m_Img / _Right.m_Img);
    }
    public override string ToString()
    {
        return String.Format("{0} + {1}i", m_Real, m_Img);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Complex A = new Complex(1, 2);
        Complex B = new Complex(3, 4);
        Complex C = new Complex();

        C = A + B;
        Console.WriteLine(A + B);
        Console.WriteLine(A - B);
        Console.WriteLine(A * B);
        Console.WriteLine(A / B);(나눗셈 다시)

    }
}

   예외처리
      try           catch         throw
코드 실행 구간  예외를 잡는곳  예외를 던지는 곳
(스택 되감기)   
    - try 실행만으로도 프로그램 부담이  커짐
    - 코드의 효율성은 떨어진다.(예외처리를 위한 코드가 내포되기 때문)
    - 코드의 안정성과 가독성이 높아진다.
    - try를 쓰는 부분은 문제가 발생할 수 있는 구간이다 라는 예상을 할 수 있다.
    - 코드상 오류 발생시에 에러처리구문이 발동하는 문법
    - 필요한 곳에는 사용할줄 알아야 한다.
    - 인스턴스 : 실제 할당된 물리적 메모리
    - 상위 catch가 있으면 아래에 써줘야 한다.
    
    ex)
   class Program
   {
     static void Main(string[] args)
     {
     // null 동적할당을 하는 변수인데 힙이 없다
       object o2 = null;

     try
     {
        throw new Exception();

        int i2 = (int)o2;
      }
      catch(Null ReferenceException e)//(매개변수 e, 아무거나 지정해도 상관없음)
      {
      Console.WriteLine("null 개체 참조예외");
      }
      catch(Exception e)
      {
        Console.WriteLine(e.Message);
       }
      }
    }

    델리게이트(중요한 용도에 많이 쓰인다.)
    - 메서드 실행목록 저장소
    - 메서드를 변수처럼 사용할 수 있게 해준다.(저장, 사용, 넘겨줌)
    - 실시간으로 내, 외부에서 활용 가능 하다.
    - 특정 메서드에 실행 목록을 저장해 줄 수 있는 자료형

 class Program
{
    //델리게이트 자료형 정의
    public delegate void CalDelegate(int _NumA, int _NumB);

    static void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    static void Sub(int a, int b)
    {
        Console.WriteLine(a - b);
    }
    static void Main(string[] args)
    {
        CalDelegate Calc = Add;
        Calc(10, 20);
        Console.WriteLine();


        Calc = Sub;
        Calc(10, 20);
        Console.WriteLine();

        Calc += Add;
        Calc(100, 100);
        Console.WriteLine();
               return;
    }
}

 이벤트(특정 상황에서 실행하는 델리게이트)
  - 델리게이트 안에 있는 특수한 델리게이트
  - 다 똑같지만 선언 할 때 문법적으로 event를 쓴다.
  - 외부 실행이 불가능하다.(델리게이트와의 차이점)
  -> 목록을 넣고, 빼는 역할만 할 수 있다.
  - 클래스 내부에서만 실행 할 수 있다.
  * 인터페이스 안에서 이벤트는 가능하고 델리게이트는 실행 불가능 하다.
  이벤트 프로버티
  Add, Remove 
  -> get, set은 둘 중 하나만 써도 상관없지만, Add,Remove는 둘 다 써야한다.   
 
   익명 메서드의 특징
    무명 메서드 지역 위에 있는 지역변수들을 참조 할 수 있다.
    익명 메서드는 T를 사용할 수 없다.
    무명식 단점 : 델리게이트 정의가 필수 요구
    반환값이 없는 델리게이트(void) 는 Action 사용
    반환값이 있는 델리게이트(float, int) 는 func 사용 
    -> 이미 만들어진 델리게이트

  람다식 -> 이름 자체가 없다.
   델리게이트 상위 문법
   식을 유추하는 기능이 있다.
   유니티에서는 람다식보다 익명 메서드를 사용한다.
  
    사용처
    1. 일회용 메서드일 경우
    2. 메서드로 놓기에 길이가 너무 짧을 경우

    항목      익명메서드             람다식
  버전(c#)    .Net 2.0              .Net 3.0
  매개변수     형 지정              형 생략(지정, 생략 가능)
  중괄호       필수                   선택
  문법     delegate(int a){}        (a) =>
  지역변수    사용가능              사용가능
  일반화      사용불가             항상지원(형 유추)
  
  - 디자인 패턴의 정의
  - 프로그램 개발에서 자주 나타나는 과제를 해결하기 위한 방법 중, 과거
  개발 과정에서 발견된 설계의 노하우를 축적하여 재사용 하기 좋은 형태로
  정리하는 것 

  - 특정 상황에서 구조적 문제를 해결하는 방식

  - 디자인 패턴의 사용 의의
   (디자인 패턴이 왜 필요한가)
 ----------------------------------
  - 디자인의 패턴 분류
  - 생성 : 객체가 만들어지고, 사라진다.
  - 구조 : 특정 관련에 대한 패턴을 만든다. 
    ex) 프록시 패턴 : 패턴 복사
        퍼사드 패턴 : 묶음(사용하고싶은 것)
  - 행동 : 특정 행동을 하는 구조
    ex) 옵저버 패턴 : 최상위 계층에서 직접적으로 관리 함

  - 디자인의 패턴 종류
  
  - 디자인 패턴 세부설명

  왜?? 

  다른 패턴과의 구분점
  (기본적으로 클래스 사용{다형성을 사용})
  문법상, 기능상, 의미상 다른점을 파악해야 한다.

    싱글턴
    - 객체가 프로젝트에 하나만 존재해야 할 경우
    -> 무조건 하나만 존재해야 한다.( ex) 회계 담당 )
    -> 관리 객체, 매니저, 공용 데이터, 관리 주체를 사용 할 때
    
    강점
    - 객체 1 : 코드적으로 객체 생성을 제어한다.(클래스 특성의 반한다.)
    - 전역데이터 : 참조에 대한 관리가 되지 않는다.
     ([다른언어] c# 통용 안된다)
    - 사용처 (변경)확대 : 객체가 늘어나면 분리해서 사용할 수 있다.(유연성)
    ★다개체로 분할이 가능하기 때문에 코드가 유연하게 관리할 수 있다.
      하나만 필요했던게 혹시나 여러개로 필요해질 때 사용

    c# 
    static 클래스 : 객체 선언이 안됨
    클래스명.멤버명

    static class클래스명
    {
     static public int m_Num;
    }

    싱글턴의 구현

    직접구현 : 직접적인 방식으로 구현
    상속구현 : 추상클래스를 사용하여 구현

    싱글턴의 종류
    -정적변수 사용 : static 사용(c#은 불가능)
    -동적변수 사용 : 동적할당(생성, 삭제가 가능하다)
    
public class Singleton // 사용의 편함
{
    //  유일한 객체
    private static Singleton m_Instance = null;
    public static Singleton Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = new Singleton();
            }

            return m_Instance;
        }
    }
    //  생성불가
    private Singleton() { }
    ////////////////////////////////////////////////////////////

    public int m_Data = 0;
}
public class SingletonB // 구현의 편함
{
    //  유일한 객체
    private static SingletonB m_Instance = new SingletonB();
    public static SingletonB Instance
    {
        get
        {
            return m_Instance;
        }
    }
    //  생성불가
    private SingletonB() { }
    ////////////////////////////////////////////////////////////

    public int m_Data = 0;
}
public class SingletonC //  다중생성을 방지하기 위해 lock을 걸어준다
{
    //  동기화체크
    private static object m_SyncRoot = new object();

    //  유일한 객체
    private static SingletonC m_Instance = null;
    public static SingletonC Instance
    {
        get
        {
            if (m_Instance == null)
            {
                lock (m_SyncRoot)// 병렬접근에서 직렬접근으로 바뀐다( lock이 걸리는 순간 순차적으로 실행된다.)
                                 // 필수적인 곳이 아니면 사용하지 않는다.(충돌, 속도의 느려짐 때문에)
                {
                    if (m_Instance == null)
                    {
                        m_Instance = new SingletonC();
                    }
                }

            }

            return m_Instance;
        }
    }
    //  생성불가
    private SingletonC() { }
    ////////////////////////////////////////////////////////////

    public int m_Data = 0;
}

public class Singleton<T> where T : class//, new()
{
    private static object m_SyncRoot = new object();
    private static T m_Instance = null;

    public static T Instance
    {
        get
        {
            if (m_Instance == null)
            {
                lock (m_SyncRoot)
                {
                    if (m_Instance == null)
                    {
                        //m_Instance = new T();
                        m_Instance = (T)Activator.CreateInstance(typeof(T), true);
                                          //new 대신 사용가능
                    }
                }
            }

            return m_Instance;
        }
    }
}

public class Sample : Singleton<Sample>
{
    public int m_Data = 20;
    private Sample(){ } // 위에 new를 없애야 사용 가능
}

namespace 디자인패턴_싱글턴_Singleton_
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonB.Instance.m_Data = 100;
            Sample.Instance.m_Data = 100;

            //Sample      Temp = new Sample();
            //SingletonB TempB = new SingletonB();

        }
    }
}

    유니티 싱글턴

    1. 기존과 같은 형태의 싱글턴
    
    2. 게임오브젝트로 만드는 싱글턴(인스펙터 상에서 보여줌)
     - 무조건 MonoBehavior를 상속받아야 한다.
     -> 상속받지 못 할 경우 게임에 들어 갈 수 없다
    -실시간 정보 공유에 용이하다

    // 씬 전환시 객체 유지 
    DontDestroyOnLoad(Obj);
    
    3.일반화
    public class GenericSingleton<T> : MonoBehaviour where  T : MonoBehaviour
    
    4. 방지코드
    findObjectoftype<T>으로 singleton이 생성 되어있는지 확인하는 방법
 ///////////////////////////////////////////////////////////////////////////////

   상태패턴 - 다형성예시(무기편)
   - 객체의 자체의 상태를 바꾸는 패턴!!
     다형성의 기초(구조적으로 다듬어진 것) 
     ex) 무기 바꾸어 공격하기
   장점
     유지보수가 용이하다!
   사용처
    - 유지보수에서 가장 많이 사용하는 패턴(추가, 삭제가 용이하다)
    - 씬 전환에 많이 사용한다.

  전략패턴 - 확장성에 기여함
    - 동일 계열의 알고리즘을 정의하고, 각 알고리즘을 캡슐화(자식객체) 하는 패턴
      알고리즘을 사용하는 클래스들은 해당 알고리즘을 다양하게 변경할 수 있고,
      해당 알고리즘은 알고리즘을 사용하는 클래스와는 독립적으로 구현 한것                                              
    * 알고리즘 : 문제 해결을 위한 방법
    - 객체의 세분화
    ex) 공격 중 타겟팅, 논 타겟팅 or 로봇의 파츠( 파츠마다 능력이 다르다)
    장점  
     - 실시간 알고리즘을 바꿀 수 있다.
     - 코드중복을 줄일 수 있다.
     - 신규 알고리즘 추가가 용이하다.
     - 클라이언트와 독립적이기 때문에 알고리즘 변경에 용이하다.

    상태 패턴과 전략 패턴의 차이(중요)
     - 상태 패턴은 객체 자신의 상태를 바꾸는 반면, 전략 패턴은 객체의 세분화 작업

    소스코드 통합 관리
    - 원격관리 - 실시간 데이터 서버             :저장소(Git Hub)
    - 코드 동기화 - 코드 겹침 방지
    - 버전별 코드 관리 - 해당 기간마다 관리

    -SCM
    소스 제어 관리

    -VCS
    버전 컨트롤 시스템
 -----------------------------
 SVN, GIT

    UML과 순서도의 차이

    UML 통합 모델 언어
    클래스의 구성과 관계를 도식화

    순서도
    -알고리즘의 흐름을 도식화 한 것
    알고리즘 : 문제를 해결 방법 (절차 : 알고리즘의 세분화)

    일정표(스케쥴링)
    TDD

    https://www.draw.io/ - 플로우차트 만들기
    http://onecellboy.tistory.com/343 - UML 설명

    보간 : 사이값을 예측하는 수학 알고리즘
    두 값 사이의 값을 특정 기준에 의해서 예측(산정하기 어려운 값들)

    선형보간
    -> 시작점 X0 와 X1 사이의 값을 예측
    = X0 *(1 - r) + X1 *r
    r : 값 변화 비율
    ex) 반투명(기존색, 결과색의 혼합)

    ★ 비트 프래그(필수 요소)
    - 장점 : 정보의 관리가 편하다
    int 하나의 정보로 여러가지 정보를 보낼 수 있다.

   
    에셋 번들
     public class Bundle : Editor
{
    [MenuItem("Assets/AssetBundleMaking")]
    static void BundleBuild()
    {   //폴더 없으면 실패
        string FullPath = Application.dataPath + "/Bundles";
        //폴더 체크 및 생성
        DirectoryInfo Di = new DirectoryInfo(FullPath);
        //폴더가 없다
        if(Di.Exists == false)
        {
            Di.Create();
        }
        //번들 생성
        BuildPipeline.BuildAssetBundles(FullPath);
    }
}

    invoke - 나 대신 실행 해주는 메서드(지연실행)
    coroutine - 대체 실행 해주는 메서드 ( 병렬은 아니지만 병렬구조 처럼 처리하는 것)
    장점 :  코드의 간결화
    subroutine : 진입점이 한 개, 입구는 하나 출구는 여러 개
                -> 처음, 나중 시작은 있어도 중간 시작은 없음

    IEnumerator 메서드명()
    {
        yield return null  -> 일반적으로 다음 업데이트 때 돌아옴
    }

    베지어 곡선
    - 선형보간의 연장선
    - 부드러운 곡선을 만들기 위해 쓰는 방법
    - 점이 늘어나면 연산이 많아진다
    
*/