using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DragonSettings", menuName = "ScriptableObjects/CreateDragonSettings")]
public class DragonSettings : ScriptableObject
{
    public float moveSpeed;
    public float moveSpeedUpRate;
    public float turnSpeed;
    public float turnSpeedUpRate;
    public float intervalBody;

    public void SpeedUp()
    {
        moveSpeed *= moveSpeedUpRate;
        turnSpeed *= turnSpeedUpRate;
    }
}
