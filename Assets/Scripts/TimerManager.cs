using UnityEngine;
//시간을 잰다.
public class TimerManager : MonoBehaviour
{
    float curTime = 0;
    
    public float maxTime = 30; //목표시간
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        curTime = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (curTime > 0)
        {
            curTime -= Time.deltaTime; //시간 증가
            //시간표시를 위한 변환
            float min = Mathf.FloorToInt(curTime / 60);
            float sec = Mathf.FloorToInt(curTime % 60);
            string timeText = min.ToString() + ":" + sec.ToString();
            print(timeText);
        }
    }
}
