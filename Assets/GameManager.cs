using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private ScoreObject scoreObject;
    [SerializeField]
    private DragonSettings ds;

    [SerializeField]
    DragonMove dm;

    [SerializeField]
    private GameObject gameOverUI;
    [SerializeField]
    private GameObject gameStartUI;
    [SerializeField]
    private GameObject gamePlayUI;
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
        gamePlayUI.SetActive(true);
        dm.enabled = true;
    }
    public void GameReset()
    {
        ds.Reset();
        gameOverUI.SetActive(false);
        gamePlayUI.SetActive(false);
        scoreObject.Reset();
        dm.enabled = false;
    }

    public void GameOver()
    {
        dm.enabled = false;
        gamePlayUI.SetActive(false);
        gameOverUI.SetActive(true);
    }
}
