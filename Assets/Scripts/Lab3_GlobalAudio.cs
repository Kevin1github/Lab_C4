using UnityEngine;

public class Lab3_GlobalAudio : MonoBehaviour
{
    // Biến kiểm tra trạng thái Mute (Tắt tiếng)
    private bool isMuted = false;

    void Update()
    {
        // 1. Chức năng Mute/Unmute (Phím M)
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted; // Đảo ngược trạng thái (Đang tắt -> Bật, Đang bật -> Tắt)

            if (isMuted)
            {
                AudioListener.volume = 0; // Tắt hẳn tiếng toàn game
                Debug.Log("Global Audio: MUTED");
            }
            else
            {
                AudioListener.volume = 1; // Bật lại full tiếng
                Debug.Log("Global Audio: UNMUTED");
            }
        }

        // 2. Chức năng Pause/Resume (Phím P)
        if (Input.GetKeyDown(KeyCode.P))
        {
            // AudioListener.pause là biến có sẵn, chỉ cần đảo ngược true/false
            AudioListener.pause = !AudioListener.pause;

            if (AudioListener.pause)
                Debug.Log("Global Audio: PAUSED");
            else
                Debug.Log("Global Audio: RESUMED");
        }
    }
}