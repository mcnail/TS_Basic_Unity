using UnityEngine;

public class PrintHelloWorld : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //초기화 : 초기 값 셋팅
        // 주석 : 문자는 "" 쌍따옴표로 감싼다. 
        // print는 글씨를 출력해주는 기능이다.

        int number1 = 1; //변수
        int number2 = 2; //변수

        print(number1 + number2);



        // apple is red.
        Color apple = Color.red;

    }

    // Update is called once per frame
    void Update()
    {
        // 진행중에 값의 변화를 계산
        //print("1+1");
    }
}
