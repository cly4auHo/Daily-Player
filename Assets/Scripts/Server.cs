using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public class Server
{
    public async Task DownloadVideo(string day)
    {
        using var request = new UnityWebRequest($"http://localhost:5187/video?id={day}");
        
        request.downloadHandler = new DownloadHandlerFile(CashManager.BuildPath(day));

        await request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
            Debug.LogError(request.error);
    }
}