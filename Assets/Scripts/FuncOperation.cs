using UnityEngine;

public class FuncOperation : MonoBehaviour
{
    //변수 타입(int) 변수명(number1) = 초기값(0);
    public int number1 = 3; //public 공개
    private int number2 = 2;    //private 비공개
    int result = 0; 

    //반환형(void) 함수이름(Add) () { }
    int Add()  //덧셈 함수
    {
        result = number1 + number2;
        return result;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(Add());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
