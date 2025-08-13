using UnityEngine;

public class DisableGameObjTimer : MonoBehaviour
{
    public float spawnTime = 15f; //5초
    public float curTime = 0;
    public string[] scripts;
    private void Start()
    {
        Invoke("TestDisable", 5f);
    }

    void TestDisable()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //타이머를 만들자!
        //curTime = curTime + Time.deltaTime; //누적
        //if (curTime >= spawnTime)
        //{
        //    gameObject.SetActive(false);
        //}
    }
}
