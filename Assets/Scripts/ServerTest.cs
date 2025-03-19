using Unity.Netcode;
using UnityEngine;

public class ServerTest : NetworkBehaviour
{
  private void Start()
  {
    NetworkManager.Singleton.OnClientConnectedCallback += OnClientConnected;
    NetworkManager.Singleton.OnClientDisconnectCallback += OnClientDisconnected;
  }

  private void OnClientConnected(ulong clientId)
  {
    LocalLogger.Log($"Client {clientId} connected.");
  }

  private void OnClientDisconnected(ulong clientId) {
    LocalLogger.Log($"Client {clientId} disconnected.");
  }

  [ServerRpc(RequireOwnership = false)]
  public void PingServerRpc(ulong clientId, ServerRpcParams rpcParams = default)
  {
    LocalLogger.Log($"Received ping from Client {clientId}");
    LocalLogger.Log($"Sending pong to Client {clientId}");
    GetComponent<ClientTest>().PongClientRpc(clientId);
  }
}
