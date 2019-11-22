using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class WeaponConfig : ScriptableObject
{
    public UnityAction collectWeaponAction;
    public UnityAction weaponFireAction;
    public GameAction damageAction;
    public Color weaponColor = Color.red;
    public GameObject weaponArt;
    public GameObject ammoObj;
    
    public FloatData playerHealth;
    public float firePower = 0.1f;
    public void RaiseFireAction()
    {
        weaponFireAction?.Invoke();
    }

    public void RaiseCollectAction()
    {
        collectWeaponAction?.Invoke();
    }

    public void DoDamage()
    {
        playerHealth.UpdateValue(firePower);
        damageAction.Raise();
    }
}
