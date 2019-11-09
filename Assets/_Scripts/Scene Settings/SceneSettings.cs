using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Andrew Trinidad
 * 3010201154
 * Program Modifications: Created File to manage scenes
*/

[CreateAssetMenu(fileName = "SceneSettings", menuName = "Scene/Settings")]
[System.Serializable]
public class SceneSettings : ScriptableObject
{
    [Header("Scene Configuration")]
    public SoundClip activeSoundClip;

    [Header("ScoreBoard Labels")]
    public bool scoreLabelEnbled;
    public bool livesLabelEnabled;
    public bool highScoreLabelEnabled;

    [Header("Scene Labels")]
    public bool startLabelActive;
    public bool endLabelActive;

    [Header("Scene Buttons")]
    public bool startButtonActive;
    public bool restartButtonActive;
}
