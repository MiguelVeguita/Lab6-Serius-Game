using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class testconect : MonoBehaviourPunCallbacks
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("intentando conectar");
        PhotonNetwork.NickName = MasterManager.GameSeting.NickName;
        PhotonNetwork.GameVersion = MasterManager.GameSeting.GameVersion;
        PhotonNetwork.ConnectUsingSettings();
        




    }
    public override void OnConnectedToMaster()
    {
        print("ya conecte");
        print(PhotonNetwork.LocalPlayer.NickName);


    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        print("me sali "+ cause.ToString());



    }
}
