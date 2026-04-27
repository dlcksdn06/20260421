using UnityEngine;

public class Hnama : MonoBehaviour
{
    [Header("타겟")]
    public Transform player;

    [Header("이동 설정")]
    public float speed = 3f; // 👉 여기서 속도 조절

    void Update()
    {
        if (player == null) return;

        FollowPlayer();
    }

    void FollowPlayer()
    {
        Vector2 dir = (player.position - transform.position).normalized;

        transform.position += (Vector3)(dir * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("플레이어 사망!");
            Destroy(collision.gameObject);
        }
    }
}