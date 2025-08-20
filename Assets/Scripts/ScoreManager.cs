using UnityEngine;
//using TMPro;
//점수관리
public class ScoreManager : MonoBehaviour
{
    public int stageScore = 0;

    //public TMP_Text tmTex;

    //싱글턴 패턴
    private static ScoreManager _instance; //앱 안에서 유일한 자리를 만들어라
    public static ScoreManager Instance;

    public void Init()
    {
        stageScore = 0;
    }

    void Start()
    {
        if(_instance == null) //유일한 자리가 비어있다면
        {
            _instance = this; //유일한 한자리에 나를 앉혀줘!
            DontDestroyOnLoad(gameObject);
        }
        else //비어있지 않다면
        {
            DestroyImmediate(this);
        }
        Instance = _instance;

        stageScore = 0;    
    }

    public void UpdateText(int score)
    {
        stageScore = stageScore + score;
        //tmTex.text = stageScore.ToString();
        UIManager.Instance.uiScore.text = stageScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //tmTex.text = stageScore.ToString();
    }
}
