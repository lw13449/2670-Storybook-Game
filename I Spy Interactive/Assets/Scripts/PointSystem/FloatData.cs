﻿  
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;
    public float maxValue = 1f;

    public void UpdateValue(float number)
    {
        value += number;
    }

    public void ChangeValue(float amount)
    {
        value = amount;
    }

    public void UpdateValueLimitZero(float amount)
    {
        if (value < 0)
        {
            value = 0;
        }
        else
        {
            UpdateValue(amount);
        }
    }

    public void UpdateValueLimitZeroAndMaxValue(float amount)
    {
        if (value < maxValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = maxValue;
        }

        UpdateValueLimitZero(amount);
    }
    
}
