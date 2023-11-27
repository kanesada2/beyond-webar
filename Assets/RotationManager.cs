using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using HutongGames.PlayMaker;

public class RotationManager : MonoBehaviour
{
    string[] rotations;
    // JavaScript関数の宣言
    [DllImport("__Internal")]
    private static extern void WatchDeviceorientation();

    void Start()
    {
        // JavaScriptの呼び出し
        WatchDeviceorientation();
    }

    void FixedUpdate()
    {
        if(rotations != null)
        {
            this.transform.rotation = Quaternion.Euler(/*-1 * float.Parse(rotations[1]) + 90*/30.0f, -float.Parse(rotations[0]), 0.0f);
        }
    }

    public void SetRotation(String rotation)
    {
        rotations = rotation.Split(',');
    }
}
