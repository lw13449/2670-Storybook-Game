using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    public WeaponConfig weaponObj;
    public void Start()
    {
        Instantiate(weaponObj.weaponArt, transform);
        weaponObj.weaponFireAction = Fire;
        var renderer = GetComponent<Renderer>();
        renderer.material.color = weaponObj.weaponColor;
    }

    public void Fire()
    {
        var ammo = Instantiate(weaponObj.ammoObj);
        ammo.GetComponent<AmmoHandler>().weaponObj = weaponObj;
    }

    public void OnTriggerEnter(Collider other)
    {
        weaponObj.RaiseCollectAction();
    }
}
