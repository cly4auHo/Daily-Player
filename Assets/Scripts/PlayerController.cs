using UnityEngine;
using UnityEngine.Video;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;

    public void PlayVideo(string path)
    {
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = path;
        videoPlayer.Play();
    }
}