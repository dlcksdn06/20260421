using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float checkDistance = 0.1f;
    public LayerMask wallLayer;

    void Update()
    {
        float h = 0f;
        float v = 0f;

        if (Input.GetKey(KeyCode.W)) v = 1;
        if (Input.GetKey(KeyCode.S)) v = -1;
        if (Input.GetKey(KeyCode.A)) h = -1;
        if (Input.GetKey(KeyCode.D)) h = 1;

        Vector2 dir = new Vector2(h, v).normalized;

        Move(dir);

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(x, y);
        transform.position += (Vector3)(move * speed * Time.deltaTime);
    }

    void Move(Vector2 direction)
    {
        if (direction == Vector2.zero) return;

        // 이동 전 충돌 체크
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, checkDistance, wallLayer);

        if (hit.collider == null)
        {
            Vector3 move = new Vector3(direction.x, direction.y, 0) * speed * Time.deltaTime;
            transform.position += move;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            SceneManager.LoadScene("End");
        }
        if (collision.gameObject.CompareTag("Room"))
        {
            SceneManager.LoadScene("Boss");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("End");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("HOME"))
        {
            // 위치 저장
            PlayerPrefs.SetFloat("PlayerX", transform.position.x);
            PlayerPrefs.SetFloat("PlayerY", transform.position.y);

            SceneManager.LoadScene("BOOS"); // 비밀의 방
        }
    }
}