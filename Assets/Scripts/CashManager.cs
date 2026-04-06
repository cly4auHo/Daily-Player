using System.IO;
using UnityEngine;

public static class CashManager
{
    public static string BuildPath(string day) => $"{Application.dataPath}/Videos/{day}.mp4";
    
    public static bool IsFileExist(string day) => File.Exists(BuildPath(day));
}