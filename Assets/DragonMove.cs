using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonMove : MonoBehaviour
{
    public BodyManager bm;
    [SerializeField]
    private DragonSettings ds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        if (Input.GetKey(KeyCode.D))
        {
            TurnRight();
        }
        if (Input.GetKey(KeyCode.A))
        {
            TurnLeft();
        }
    }

    private void MoveForward()
    {
        transform.position += transform.forward * ds.moveSpeed * Time.deltaTime;
    }

    public void TurnRight()
    {
        transform.Rotate(new Vector3(0, ds.turnSpeed * Time.deltaTime, 0));
    }

    public void TurnLeft()
    {
        transform.Rotate(new Vector3(0, -1 * ds.turnSpeed * Time.deltaTime, 0));
    }
}
