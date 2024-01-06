using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScore : MonoBehaviour
{
    [SerializeField]
    private ScoreObject scoreObject;
    private TextMeshProUGUI tmp;
    // Start is called before the first frame update
    void Start()
    {
        tmp = gameObject.GetComponent<TextMeshProUGUI>();
        scoreObject.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = "Score:" + (int)scoreObject.score;
    }
}
