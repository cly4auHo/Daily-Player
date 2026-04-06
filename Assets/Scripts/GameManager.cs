using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerController videoPlayerPrefab;
    
    private PlayerController videoPlayer;
    private Server server;
    
    private void Start()
    {
        videoPlayer = Instantiate(videoPlayerPrefab);
        server ??= new Server();
        DayController.Init();
        PlayVideo();
    }

    private async void PlayVideo()
    {
        if (!CashManager.IsFileExist(DayController.CurrentDay))
            await server.DownloadVideo(DayController.CurrentDay);
        
        videoPlayer.PlayVideo(CashManager.BuildPath(DayController.CurrentDay));
    }
}