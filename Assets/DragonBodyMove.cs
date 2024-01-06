using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonBodyMove : MonoBehaviour
{
    [SerializeField]
    private BodyManager bm;
    [SerializeField]
    private DragonSettings ds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(bm.previousBody.transform);
        transform.position += transform.forward * (Vector3.Distance(transform.position, bm.previousBody.transform.position) - ds.intervalBody);
    }
}
