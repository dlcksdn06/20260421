using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    void Update()
    {
        // 1번 키 → SampleScene
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("SampleScene");
        }

        // 2번 키 → End
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("End");
        }

        // 3번 키 → Title
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("Title");
        }
    }
}