using UnityEngine;
using UnityEngine.Video; // Nhớ thư viện này

public class Lab5_VideoControl : MonoBehaviour
{
    public VideoPlayer myVideoPlayer;

    void Start()
    {
        // Đăng ký sự kiện: Khi video chạy đến điểm cuối (End), hãy gọi hàm OnVideoEnd
        myVideoPlayer.loopPointReached += OnVideoEnd;
    }

    void Update()
    {
        // Vẫn giữ nút V để Play như cũ
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (!myVideoPlayer.isPlaying)
            {
                myVideoPlayer.Play();
                Debug.Log("Video Playing...");
            }
        }
    }

    // Hàm này sẽ TỰ ĐỘNG chạy khi video hết
    void OnVideoEnd(VideoPlayer vp)
    {
        Debug.Log("VIDEO ĐÃ KẾT THÚC! (Hết phim)");

        // Ví dụ: Tắt màn hình TV đi sau khi hết phim
        // gameObject.SetActive(false); 

        // Hoặc: Load màn chơi mới (sẽ làm ở Mini Project)
    }
}