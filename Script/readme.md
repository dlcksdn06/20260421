

fileFormatVersion: 2
guid: 66c5b043f91423743986485e82588b7e
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

fileFormatVersion: 2
guid: 4f9c06ec52b2fc544ae3c5b13ed76060
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed_X = 5.0f;

    void Update()
        //UpDate() �� �����Ӹ��� ����
    {
        transform.Translate(Vector3.right * speed_X * Time.deltaTime);
    }
}
