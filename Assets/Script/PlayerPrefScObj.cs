using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "PlayerPref", order = 1)]
[System.Serializable]
public class PlayerPrefScObj : ScriptableObject {

    // GENERAL

    public EnumScript.GameLanguage language;

    public EnumScript.GameDifficulty difficulty;

    public bool rageQuit;

    // CONTROLS


    //VIDEO

    public EnumScript.GameResolution resolution;

    public EnumScript.GaphicsQuality graphicQuality;

    public EnumScript.ShadowQuality shadowQuality;

    public EnumScript.WindowMode windowMode;

    public bool antiAliasing;

    //AUDIO

    public EnumScript.Speaker speaker;

    public float musicVolume;

    public float fxVolume;

    public float voicesVolume;









}
