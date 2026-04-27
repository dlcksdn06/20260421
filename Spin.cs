using UnityEngine;

public class RotatingCollectible : MonoBehaviour
{
    [Header("회전 설정")]
    public float rotateSpeed = 100f; // Z축 회전 속도

    [Header("점수")]
    public int scoreValue = 1;

    void Update()
    {
        // Z축 회전
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }

}