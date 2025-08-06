using UnityEngine;
using UnityEngine.SceneManagement;

public class UIstartbtn : MonoBehaviour
{
    //버튼을 누르면 Prototype으로 씬을 변경해라
    public void BtnSceneChange()
    {
        SceneManager.LoadScene(1);
    }
}
