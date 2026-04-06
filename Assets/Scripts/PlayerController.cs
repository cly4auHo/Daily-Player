using UnityEngine;
using UnityEngine.Video;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;
    
    public void PlayVideo(string path)
    {
        videoPlayer.url = path;
        videoPlayer.Play();
    }

    public void SetVolume(in float volume) => videoPlayer.SetDirectAudioVolume(0, volume);
}