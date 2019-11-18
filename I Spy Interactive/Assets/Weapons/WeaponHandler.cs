﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    public WeaponConfig weaponObj;
    public void Start()
    {
        weaponObj.weaponFireAction = Fire;
        var renderer = GetComponent<Renderer>();
        renderer.material.color = weaponObj.weaponColor;
    }

    public void Fire()
    {
        var ammo = Instantiate(weaponObj.ammoObj);
        var renderer = ammo.GetComponent<Renderer>();
        renderer.material.color = weaponObj.weaponColor;
    }

    public void OnTriggerEnter(Collider other)
    {
        weaponObj.RaiseCollectAction();
    }
}
