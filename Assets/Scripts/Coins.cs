using UnityEngine;

public class Coins : MonoBehaviour
{
    public int coinScore = 10;

    public ScoreManager scoreMng;
    //플레이어가 부딛혔을때, 스코어매니저한테 점수를 증가한다
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            scoreMng.stageScore = scoreMng.stageScore + coinScore;
            Destroy(gameObject);
        }
    }
}
