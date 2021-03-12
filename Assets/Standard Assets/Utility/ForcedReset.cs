using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

//[RequireComponent(typeof(UInt16.text)(ushort))]
public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            //... reload the scene
            Application.LoadLevelAsync(Application.loadedLevelName);
        }
    }
}
