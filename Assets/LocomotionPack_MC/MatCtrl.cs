using UnityEngine;


public class MatCtrl : MonoBehaviour
{
    Renderer rend;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
