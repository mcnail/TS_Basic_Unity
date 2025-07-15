using UnityEngine;


// �÷��� �ٲٰ� �ʹ�.
public class ColorChange : MonoBehaviour
{
    Renderer rend; //������ ������Ʈ
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //����(gameobject) ������ �ִ� ������(mesh renderer)�� ������ �����!
        rend = GetComponent<Renderer>();
        //�������� �������ִ� ��Ƽ������ �÷��� �������� �ٲ���.
        rend.material.color = Color.red;
        transform.position = new Vector3(100, 20, -50);    
        rend.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.color = Color.purple;
    }
}
