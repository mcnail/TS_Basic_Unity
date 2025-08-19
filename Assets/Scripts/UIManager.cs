using UnityEngine;
using TMPro;
//UI 게임 오브젝트 정보를 쥐고 있는다.
public class UIManager : MonoBehaviour
{
    public TMP_Text uiScore;
    public TMP_Text timeText; //플레이중의 점수표시
    public GameObject resultObj;
    public TMP_Text resultNums; //결과창의 점수표시

    private static UIManager _instance;
    public static UIManager Instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
        Instance = _instance;
    }

    private void Start()
    {
        resultObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
