using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DragonCollider : MonoBehaviour
{
    [SerializeField]
    private ScoreObject score;
    [SerializeField]
    private ItemGenerator generator;
    [SerializeField]
    private BodyManager headbm;
    [SerializeField]
    private GameManager gamemanager;
    [SerializeField]
    private DragonSettings ds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            ds.SpeedUp();
            headbm.addBody();
            score.ChangeScore(1);
            Destroy(other.gameObject);
            generator.GenerateItem();
        }
        if (other.gameObject.CompareTag("Wall") || other.gameObject.CompareTag("DragonBody"))
        {
            gamemanager.GameOver();
        }
    }
}
