using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MyStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + "Starting Host." );
        StartHost();
    }

    override public void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + "Host started.");
    }

    public override void OnStartClient(NetworkClient client)
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client start requested.");
        InvokeRepeating("PrintDots", 0f, 1.0f);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client is connected to IP: " + conn.address);
        base.OnClientConnect(conn);
        CancelInvoke();
    }

    void PrintDots()
    {
        Debug.Log(".");
    }
}
