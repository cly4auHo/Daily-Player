using UnityEngine;

public class GameManager : MonoBehaviour
{
    private readonly Server server = new Server();
    
    async void Start()
    {
        await server.DownloadVideo(DayController.CurrentDay);
    }

    
}
