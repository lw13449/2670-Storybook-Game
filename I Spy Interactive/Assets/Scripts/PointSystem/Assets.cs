using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Assets : ScriptableObject
{
    public UnityAction<int> assetAction;
    
    public int value = 0;

    public void UpdateImage()
    {
        assetAction?.Invoke(value);
    }
}
