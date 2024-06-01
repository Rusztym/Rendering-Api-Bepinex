using BepInEx;
using UnityEngine;

[BepInPlugin("com.example.renderinginfo", "Rendering Info Plugin", "1.0.0")]
public class RenderingInfoPlugin : BaseUnityPlugin
{
    void Awake()
    {
        Logger.LogInfo("RenderingInfoPlugin is loaded and Awake is called");
        LogRenderingAPI(); // Force call to LogRenderingAPI from Awake
    }

    void Start()
    {
        Logger.LogInfo("Start method is called");
        // LogRenderingAPI(); // Optional: Comment this if called in Awake
    }

    void LogRenderingAPI()
    {
        Logger.LogInfo("LogRenderingAPI method is called");
        string graphicsDeviceType = SystemInfo.graphicsDeviceType.ToString();
        string graphicsDeviceName = SystemInfo.graphicsDeviceName;
        string graphicsDeviceVersion = SystemInfo.graphicsDeviceVersion;

        Logger.LogInfo($"Graphics Device Type: {graphicsDeviceType}");
        Logger.LogInfo($"Graphics Device Name: {graphicsDeviceName}");
        Logger.LogInfo($"Graphics Device Version: {graphicsDeviceVersion}");
    }
}