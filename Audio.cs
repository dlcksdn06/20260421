using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        // 왼쪽 마우스 클릭 → 오디오 재생
        if (Input.GetMouseButtonDown(0))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }

        // 오른쪽 마우스 클릭 → 오디오 정지
        if (Input.GetMouseButtonDown(1))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}