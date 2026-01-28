using UnityEngine;
using UnityEngine.Video;
using System.Collections;

public class GameDirector : MonoBehaviour
{
    [Header("Cài đặt các diễn viên")]
    public VideoPlayer tvVideo;      // Cái đầu đĩa
    public AudioSource bgmAudio;     // Cái loa
    public MeshRenderer tvScreen;    // Cái màn hình Tivi (để làm mờ)
    public float fadeDuration = 3f;  // Thời gian sáng dần (3 giây)

    void Start()
    {
        StartCoroutine(PlayIntroSequence());
    }

    IEnumerator PlayIntroSequence()
    {
        // 1. Chuẩn bị: Làm màn hình tối đen trước
        tvScreen.material.color = Color.black;

        // 2. Bắt đầu chạy Video và Nhạc cùng lúc
        tvVideo.Play();
        bgmAudio.Play();

        // 3. Hiệu ứng Fade In (Từ đen -> Sáng dần)
        float timer = 0;
        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            // Chuyển màu từ Đen (Black) sang Trắng (White - tức là màu gốc)
            tvScreen.material.color = Color.Lerp(Color.black, Color.white, timer / fadeDuration);
            yield return null; // Chờ sang frame tiếp theo
        }
        tvScreen.material.color = Color.white; // Chốt màu trắng (sáng nhất)

        // 4. Đăng ký sự kiện: Video hết thì tắt nhạc
        tvVideo.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        Debug.Log("Hết phim -> Tắt nhạc!");
        bgmAudio.Stop();

        // Nếu muốn làm gì thêm khi kết thúc (ví dụ hiện nút Replay) thì viết ở đây
    }
}