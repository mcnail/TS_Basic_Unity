using UnityEngine;
using UnityEngine.SceneManagement;
//리스타트 (btn) : 버튼과 연결될 public 함수 RestartBtn()
//종료 (btn) : 버튼과 연결될 public 함수 QuitAppBtn()
//점수 (text)
public class ResultWindow : MonoBehaviour
{
    public void RestartBtn()
    {
        SceneManager.LoadScene(1);  //현재씬을 다시 로드한다
    }

    public void QuitAppBtn()
    {
        Application.Quit(); //종료
    }

    int FuncNumbers(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int testNum = FuncNumbers(5,22);
        print(testNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
