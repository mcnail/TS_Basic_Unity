using UnityEngine;
//에너미 혹은 아이템을 일정 시간이 되면 스폰(생성)하는 기능
public class SpawnTimer : MonoBehaviour
{
    public float spawnTime = 5; //5초
    public float curTime = 0;
    public GameObject spawnObj; //생성해야할 오브젝트
    // Update is called once per frame
    void Update()
    {
        //타이머를 만들자!
        curTime = curTime + Time.deltaTime; //누적
        if(curTime > spawnTime)
        {
            GameObject go = Instantiate(spawnObj);//아이템, 에너미, 생성해라 
            curTime = 0; //curTime 초기화
        }
    }
}
