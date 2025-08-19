using UnityEngine;
using TMPro;
//UI 게임 오브젝트 정보를 쥐고 있는다.
public class UIManager : MonoBehaviour
{
    public TMP_Text uiScore;

    private static UIManager _instance;
    public static UIManager Instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
