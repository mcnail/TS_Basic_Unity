using UnityEngine;
//카메라를 마우스로 제어하자(회전)
public class CamRot : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float mouseSpd = 200f;   //마우스 감도
    float mx = 0f; //마우스x값을 저장
    float my = 0f; //마우스y값을 저장
    // Update is called once per frame
    void Update()
    {
        //마우스의 움직임에 대한 값을 받아오자!
        float mouse_x = Input.GetAxis("Mouse X");
        float mouse_y = Input.GetAxis("Mouse Y");
        //P=p0 + vt
        mx = mx + mouse_x * mouseSpd * Time.deltaTime;
        my = my + mouse_y * mouseSpd * Time.deltaTime;
        //값을 제한한다 Mathf.Clamp(제한할 변수, min, max)
        my = Mathf.Clamp(my, -90, 90);
        transform.eulerAngles = new Vector3(-my, mx, 0);
    }
}
