using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public class Server
{
    private const string URL = "http://localhost:5187/video?id=";
    
    public async Task DownloadVideo(string day)
    {
        using var request = new UnityWebRequest($"{URL}{day}");
        
        request.downloadHandler = new DownloadHandlerFile(CashManager.BuildPath(day));

        await request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
            Debug.LogError(request.error);
    }
}