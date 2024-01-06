using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        GenerateItem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateItem()
    {
        float x = Random.Range(-20.0f, 20.0f);
        float y = item.transform.localScale.y / 2;
        float z = Random.Range(-20.0f, 20.0f);
        Instantiate(item, new Vector3(x,  y, z), Quaternion.identity);
    }
}
