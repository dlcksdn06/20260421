
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
