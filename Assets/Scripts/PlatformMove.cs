using UnityEngine;

//일정한 방향으로 움직인다
public class PlatformMove : MonoBehaviour
{
    //방향(벡터 Vector3)
    public Vector3 dir = Vector3.forward; //x0,y0,z1
    //속력(speed > float)
    public float speed = 5f;
    // 실행할때 혹은 씬에 처음 생성될때 실행되는 코드
    void Start()
    {
        
    }

    // 매 프레임이 생성될때(새로고침 될때) 한번 실행하는 코드 = 지속적인 변화
    void Update()
    {
        //P=p0 + vt
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }
}
