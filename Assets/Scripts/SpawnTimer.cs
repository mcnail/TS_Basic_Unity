using UnityEngine;
//���ʹ� Ȥ�� �������� ���� �ð��� �Ǹ� ����(����)�ϴ� ���
public class SpawnTimer : MonoBehaviour
{
    public float spawnTime = 5; //5��
    public float curTime = 0;
    public GameObject spawnObj; //�����ؾ��� ������Ʈ
    // Update is called once per frame
    void Update()
    {
        //Ÿ�̸Ӹ� ������!
        curTime = curTime + Time.deltaTime; //����
        if(curTime > spawnTime)
        {
            GameObject go = Instantiate(spawnObj);//������, ���ʹ�, �����ض� 
            curTime = 0; //curTime �ʱ�ȭ
        }
    }
}
