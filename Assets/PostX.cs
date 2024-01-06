using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostX : MonoBehaviour
{
    [SerializeField]
    private ScoreObject scoreObject;
    public void OnClick()
    {
        int score = scoreObject.score;
        string url = "https://twitter.com/intent/tweet?text=今回の点数は" + score.ToString() + "点でした！%0aドラゴンゲーム：https://github.com/keichange/DragonGame/settings/pages";
        Application.OpenURL(url);
    }
}
