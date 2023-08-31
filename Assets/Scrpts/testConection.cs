using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class testConection : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.GameVersion = "0.0.1";
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("OnConnectedToMaster() was called by PUN.");
        PhotonNetwork.JoinRandomRoom();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

 

    

