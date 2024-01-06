using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyManager : MonoBehaviour
{
    [SerializeField]
    private GameObject bodyPrefab;
    public GameObject nextBody;
    public GameObject previousBody = null;
    [SerializeField]
    private DragonSettings ds;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            addBody();
        }
    }

    public void addBody()
    {
        if (!nextBody)
        {
            nextBody = Instantiate(bodyPrefab);
            nextBody.transform.position = transform.position + transform.forward * -1 * ds.intervalBody;
            nextBody.GetComponent<BodyManager>().previousBody = gameObject;
        }
    }
}
