using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using agora_gaming_rtc;

public class LeaveHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        // Agora.io Implimentation
        IRtcEngine mRtcEngine = IRtcEngine.GetEngine(AgoraInterface.appId); // Get a reference to the Engine
        if (mRtcEngine != null)
        {
            Debug.Log("Leaving Channel");
            mRtcEngine.LeaveChannel();// leave the channel
        }

    }
}
