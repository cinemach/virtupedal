using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTS;
using VTS.Networking.Impl;
using VTS.Models.Impl;
using VTS.Models;

public class VTSInherit : VTSPlugin
{
    private void Start()
    {
        Initialize(
            new WebSocketImpl(),
            new JsonUtilityImpl(),
            new TokenStorageImpl(),
            () => { Debug.Log("Server Connected"); },
            () => { Debug.LogWarning("Server Disconnected"); },
            () => { Debug.LogError("oh fuck"); }

            );
    }

    public void PressHotkey(string s)
    {
        this.TriggerHotkey(s,(A) => { }, (B) => { Debug.LogError(B.ToString()); });
    }
}
