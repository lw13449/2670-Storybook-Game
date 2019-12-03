using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class debug : ScriptableObject
{
    public void OnDebug(string message)
    {
        Debug.Log(message);
    }

    public void onDebug(int number)
    {
        Debug.Log(number);
    }
    
}