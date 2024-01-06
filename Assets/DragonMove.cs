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
        if (Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }
    }

    private void MoveForward()
    {
        transform.position += transform.forward * ds.moveSpeed;
    }

    public void MoveRight()
    {
        transform.Rotate(new Vector3(0, ds.turnSpeed, 0));
    }

    public void MoveLeft()
    {
        transform.Rotate(new Vector3(0, -1 * ds.turnSpeed, 0));
    }
}
