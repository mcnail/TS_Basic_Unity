using UnityEngine;

//일정한 방향으로 움직인다
public class PlatformMove : MonoBehaviour
{
    //방향(벡터 Vector3)
    public Vector3 dir = Vector3.forward; //x0,y0,z1
    //속력(speed > float)
    public float speed = 5f;

    CharacterController controller;
    // 실행할때 혹은 씬에 처음 생성될때 실행되는 코드
    void Start()
    {
        //오브젝트 탐색 : 게임오브젝트 가 가진 컴포넌트를 찾아라
        //controller = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>();
    }

    // 매 프레임이 생성될때(새로고침 될때) 한번 실행하는 코드 = 지속적인 변화
    void Update()
    {
        //이동속도를 계산 > 플레이어.cc.Move()
        print("prevPos : " + transform.position);   //문자열을 합쳐서 출력
        prevPos = transform.position;
        //P=p0 + vt
        transform.position = transform.position + dir * speed * Time.deltaTime;

        print("curPos : " + transform.position);
        curPos = transform.position;
    }

    public Vector3 prevPos = Vector3.zero;
    public Vector3 curPos = Vector3.zero;
    public Vector3 deltaPos = Vector3.zero;
    private void LateUpdate()
    {
        //플레이어의 캐릭터 컨트롤러에 델타만큼 움직여라
        deltaPos = curPos - prevPos;
        controller.Move(deltaPos);  
    }
    //센서영역에 들어왔다!
    private void OnTriggerEnter(Collider other)
    {
        //센서영역에 들어온 게임오브젝트 = other
        if(other.CompareTag("Player"))
        {
            //플레이어가 맞다면, 캐릭터 컨트롤러 정보를 담아줘
            controller = other.GetComponent<CharacterController>();
        }
    }
    //센서영역에서 빠져나갔다!
    private void OnTriggerExit(Collider other)
    {
        //센서영역에 빠져나간 게임오브젝트 = other
        if (other.CompareTag("Player"))
        {
            //플레이어가 맞다면, 캐릭터 컨트롤러 정보를 지워줘
            controller = null;
        }
    }
}
