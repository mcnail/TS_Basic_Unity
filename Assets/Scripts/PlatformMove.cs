using UnityEngine;

//������ �������� �����δ�
public class PlatformMove : MonoBehaviour
{
    //����(���� Vector3)
    public Vector3 dir = Vector3.forward; //x0,y0,z1
    //�ӷ�(speed > float)
    public float speed = 5f;
    // �����Ҷ� Ȥ�� ���� ó�� �����ɶ� ����Ǵ� �ڵ�
    void Start()
    {
        
    }

    // �� �������� �����ɶ�(���ΰ�ħ �ɶ�) �ѹ� �����ϴ� �ڵ� = �������� ��ȭ
    void Update()
    {
        //P=p0 + vt
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }
}
