using UnityEngine;
using Unity.Netcode;

public class ClientTest : NetworkBehaviour
{
  private void Start()
  {
    Debug.Log("ClientTest: Adding OnClientConnectedCallback");
    NetworkManager.Singleton.OnClientConnectedCallback += OnConnected;
  }


  private void OnConnected(ulong clientId)
  {
    Debug.Log("Connected to server!");
    InvokeRepeating(nameof(SendPing), 2f, 5f); // Send ping every 5 seconds
  }

  private void SendPing()
  {
    if (NetworkManager.Singleton.IsConnectedClient)
    {
      ulong clientId = NetworkManager.Singleton.LocalClientId;
      GetComponent<ServerTest>().PingServerRpc(clientId);
      Debug.Log("Ping sent to server.");
    }
  }

  [ClientRpc]
  public void PongClientRpc(ulong clientId)
  {
    Debug.Log($"Pong received by Client {clientId}");
  }
}
