using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private ScoreObject scoreObject;
    [SerializeField]
    DragonMove dm;

    [SerializeField]
    private GameObject gameOverUI;
    [SerializeField]
    private GameObject gameStartUI;
    // Start is called before the first frame update
    void Start()
    {
        GameReset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        gameStartUI.SetActive(false);
        dm.enabled = true;
    }
    public void GameReset()
    {
        gameOverUI.SetActive(false);
        scoreObject.Reset();
        dm.enabled = false;
    }

    public void GameOver()
    {
        dm.enabled = false;
        gameOverUI.SetActive(true);
    }
}
