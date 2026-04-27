using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{
    public float speed = 2f;
    public float moveTime = 2f;

    private float timer;
    private int direction = 1;

    void Update()
    {
        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);

        timer += Time.deltaTime;

        if (timer >= moveTime)
        {
            direction *= -1;
            timer = 0f;
        }
    }

    // 충돌 시 플레이어 삭제
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }

    // Trigger 사용할 경우
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}