using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DragonSettings", menuName = "ScriptableObjects/CreateDragonSettings")]
public class DragonSettings : ScriptableObject
{
    public float InitialMoveSpeed;
    public float moveSpeed;
    public float moveSpeedUpRate;
    public float InitialTurnSpeed;
    public float turnSpeed;
    public float turnSpeedUpRate;
    public float intervalBody;

    public void SpeedUp()
    {
        moveSpeed *= moveSpeedUpRate;
        turnSpeed *= turnSpeedUpRate;
    }

    public void Reset()
    {
        moveSpeed = InitialMoveSpeed;
        turnSpeed = InitialTurnSpeed;
    }
}
