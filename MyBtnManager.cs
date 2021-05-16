using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Ambier;
using UnityEngine.UI;


namespace Ambier
{
    public class MyBtnManager : MonoBehaviour
    {
        public static BtnManager inst;
        // Start is called before the first frame update
        [Header("Content")]
        public Text txt_Content;
        [Header("Init")]
        public GameObject objInit;
        public InputField iptUserID;
        public InputField iptNickName;
        public Button btnConnectUsingSettings;
        [Header("MasterServer")]
        public Button btn_PvC;
        public Button btn_PvP;
        [Header("Lobby")]
        public GameObject objLobby;
        public InputField iptRoomName;
        public Button btnCreateRoom;
        public Button btnJoinSpecifyRoom;
        public Button btnJoinRandomRoom;
        public Button btnRoomListUpdate;
        public Button btnLeaveLobby;
        [Header("Room")]
        public Button btnNextScene;
        public Button Btn_LeaveRoom;
    }
}