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
        string url = "https://twitter.com/intent/tweet?text=����̓_����" + score.ToString() + "�_�ł����I%0a�h���S���Q�[���Fhttps://github.com/keichange/DragonGame/settings/pages";
        Application.OpenURL(url);
    }
}
