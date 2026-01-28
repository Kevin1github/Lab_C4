using UnityEngine;
using UnityEngine.SceneManagement; // Cần thư viện này để chuyển cảnh
using UnityEngine.Video;

public class IntroController : MonoBehaviour
{
    public VideoPlayer introVideo;

    void Start()
    {
        // 1. Đăng ký sự kiện: Hết video thì gọi hàm LoadGame
        introVideo.loopPointReached += OnVideoEnd;
    }

    // Hàm tự động chạy khi hết video
    void OnVideoEnd(VideoPlayer vp)
    {
        LoadGameScene();
    }

    // Hàm cho nút bấm Skip
    public void OnSkipButtonClick()
    {
        LoadGameScene();
    }

    // Logic chuyển cảnh chung
    void LoadGameScene()
    {
        Debug.Log("Chuyển sang GameScene...");
        // Lưu ý: Phải điền đúng tên Scene đích
        SceneManager.LoadScene("GameScene");
    }
}