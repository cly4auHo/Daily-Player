using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerController videoPlayer;
    
    private readonly Server server = new Server();
    
    private void Start()
    {
        DayController.Init();
        PlayVideo();
    }

    private async void PlayVideo()
    {
        if (!CashManager.IsFileExist(DayController.CurrentDay))
            await server.DownloadVideo(DayController.CurrentDay);
        
        videoPlayer.PlayVideo(DayController.CurrentDay);
    }
}