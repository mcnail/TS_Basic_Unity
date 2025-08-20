using UnityEngine;
using UnityEngine.SceneManagement;

public class UIstartbtn : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
    //버튼을 누르면 Prototype으로 씬을 변경해라
    public void BtnSceneChange()
    {
        SceneManager.LoadScene(1);
    }
}
