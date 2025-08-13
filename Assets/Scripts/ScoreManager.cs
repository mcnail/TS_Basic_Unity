using UnityEngine;
using TMPro;
//점수관리
public class ScoreManager : MonoBehaviour
{
    public int stageScore = 0;

    public TMP_Text tmTex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stageScore = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        tmTex.text = stageScore.ToString();
    }
}
