using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DragonSettings", menuName = "ScriptableObjects/CreateDragonSettings")]
public class DragonSettings : ScriptableObject
{
    public float moveSpeed;
    public float intervalBody;
    public float turnSpeed;
}
