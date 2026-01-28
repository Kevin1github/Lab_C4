using UnityEngine;

public class Lab1_Control : MonoBehaviour
{
    // Biến để chứa tham chiếu đến AudioSource
    public AudioSource myAudioSource;

    void Update()
    {
        // Yêu cầu: Nhấn Space để Play
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Kiểm tra xem audio có đang chạy không, nếu không thì mới Play (để tránh bị chồng âm thanh)
            if (!myAudioSource.isPlaying)
            {
                myAudioSource.Play();
                Debug.Log("Audio Started");
            }
        }

        // Yêu cầu: Nhấn S để Stop
        if (Input.GetKeyDown(KeyCode.S))
        {
            myAudioSource.Stop();
            Debug.Log("Audio Stopped");
        }
    }
}