using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour, IGameManager
{

public ManagerStatus status {get; private set;}

private NetworkService _network;

 // Add volume controls here (listing 11.4)
    public void Startup(NetworkService service) {
        Debug.Log("Audio manager starting...");
        _network = service;
 
        // Initialize music sources here (listing 11.11)
        status = ManagerStatus.Started;
    }
}
