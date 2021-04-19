using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherManager : MonoBehaviour, IGameManager
{
   public ManagerStatus status {get; private set;}

    //Add cloud value here (listing 10.8)

    private NetworkService _network;

    public void Startup(NetworkService service)
    {
        Debug.Log("Weather manager starting...");

        _network = service;

        status = ManagerStatus.Started;
    }
}
