using UnityEngine;

public class PrintHelloWorld : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�ʱ�ȭ : �ʱ� �� ����
        // �ּ� : ���ڴ� "" �ֵ���ǥ�� ���Ѵ�. 
        // print�� �۾��� ������ִ� ����̴�.

        int number1 = 1; //����
        int number2 = 2; //����

        print(number1 + number2);



        // apple is red.
        Color apple = Color.red;

    }

    // Update is called once per frame
    void Update()
    {
        // �����߿� ���� ��ȭ�� ���
        //print("1+1");
    }
}
