using System.Net.Http; 
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public class Server
{
    private const string URL = "http://localhost:5187/video?id=";
    
    private readonly HttpClient client = new();

    public async Task DownloadVideo(string day)
    {
        var url = $"{URL}{day}";
        var path = $"{Application.dataPath}/Videos/{day}.mp4";

        using var request = new UnityWebRequest(url);
        request.downloadHandler = new DownloadHandlerFile(path);

        await request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError(request.error);
        }
        else
        {
            Debug.Log("Video saved to: " + path);
        }
    }
}
