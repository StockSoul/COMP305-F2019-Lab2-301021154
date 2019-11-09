using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Andrew Trinidad
 * 3010201154
 * Program Modifications: Changed file to ScriptableObject
*/

[CreateAssetMenu(fileName = "ScoreBoard", menuName = "Game/ScoreBoard")]
[System.Serializable]
public class ScoreBoard : ScriptableObject
{
    public int highScore;
    public int lives;
    public int score;
}
