using UnityEngine;
using UnityEngine.Video; 
using UnityEngine.SceneManagement; 

public class SkipIntro : MonoBehaviour
{
    public VideoPlayer mioVideoPlayer;
    
    public string nomeScenaGioco = "Gioco"; 

    void Start()
    {
        if (mioVideoPlayer == null)
        {
            mioVideoPlayer = GetComponent<VideoPlayer>();
        }

        if (mioVideoPlayer != null)
        {
            mioVideoPlayer.loopPointReached += AlTermineDelVideo;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SalvaESaltaVideo();
        }
    }

    void OnDestroy()
    {
        if (mioVideoPlayer != null)
        {
            mioVideoPlayer.loopPointReached -= AlTermineDelVideo;
        }
    }

    void AlTermineDelVideo(VideoPlayer vp)
    {
        VaiAlGioco();
    }

    void SalvaESaltaVideo()
    {
        if (mioVideoPlayer != null)
        {
            mioVideoPlayer.Stop(); 
        }
        VaiAlGioco();
    }

    void VaiAlGioco()
    {
        SceneManager.LoadScene(nomeScenaGioco);
    }
}
