using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreObject", menuName = "ScriptableObjects/CreateScoreObject")]
public class ScoreObject : ScriptableObject
{
    public int score;

    public void ChangeScore(int n)
    {
        score += n;
    }

    public void Reset()
    {
        score = 0;
    }
}
