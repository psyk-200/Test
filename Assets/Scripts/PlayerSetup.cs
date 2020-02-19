using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class PlayerSetup : NetworkBehaviour
{

    GameObject sceneCamera;

    private void Start()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        sceneCamera = GameObject.Find("Camera");
        sceneCamera.SetActive(false);
    }
    private void OnDisable()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        sceneCamera.SetActive(true);
    }
}
