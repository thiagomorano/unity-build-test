using Unity.Netcode;
using UnityEngine;

public class NetworkStarter : MonoBehaviour
{

  public bool isServer = false;
  public bool isClient = true;

  public NetworkManager networkManager;

  private void Start()
  {
#if UNITY_EDITOR
    if (isServer)
    {
      StartServer();
    }
    else if (isClient)
    {
      StartClient();
    }
#elif UNITY_WEBGL
    StartClient();
#elif UNITY_SERVER || UNITY_STANDALONE_LINUX
    StartServer();
#endif
  }

  private void StartClient()
  {
    networkManager.StartClient();
    Debug.Log("Client trying to connect...");
  }

  private void StartServer()
  {
    networkManager.StartServer();
    LocalLogger.Log("Server started on WebTransport"); 
  }
}
