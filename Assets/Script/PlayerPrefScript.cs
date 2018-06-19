using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefScript : MonoBehaviour {

    public PlayerPrefScObj playerPrefDefault;

    public PlayerPrefScObj playerPrefCurrent;

    // GENERAL
        // SET LANGUAGE
    public void SetLanguageEnglish() { playerPrefCurrent.language = EnumScript.GameLanguage.English; }
    public void SetLanguageFrench() { playerPrefCurrent.language = EnumScript.GameLanguage.French; }
    public void SetLanguageRussian() { playerPrefCurrent.language = EnumScript.GameLanguage.Russian; }
        // SET DIFFICULTY
    public void SetDifficultyEasy() { playerPrefCurrent.difficulty = EnumScript.GameDifficulty.Easy; }
    public void SetDifficultyNormal() { playerPrefCurrent.difficulty = EnumScript.GameDifficulty.Normal; }
    public void SetDifficultyHard() { playerPrefCurrent.difficulty = EnumScript.GameDifficulty.Hard; }
        // SET AUTO RAGE QUIT
    public void SetAutoRAgeQuit(bool rq) { playerPrefCurrent.rageQuit = rq; }



    public void SetToDefault() {

        playerPrefCurrent.language = playerPrefDefault.language;
        playerPrefCurrent.difficulty = playerPrefDefault.difficulty;
        playerPrefCurrent.rageQuit = playerPrefDefault.rageQuit;
        playerPrefCurrent.antiAliasing = playerPrefDefault.antiAliasing;
        playerPrefCurrent.resolution = playerPrefDefault.resolution;
        playerPrefCurrent.graphicQuality = playerPrefDefault.graphicQuality;
        playerPrefCurrent.shadowQuality = playerPrefDefault.shadowQuality;
        playerPrefCurrent.windowMode = playerPrefDefault.windowMode;
        playerPrefCurrent.speaker = playerPrefDefault.speaker;
        playerPrefCurrent.voicesVolume = playerPrefDefault.voicesVolume;
        playerPrefCurrent.musicVolume = playerPrefDefault.musicVolume;
        playerPrefCurrent.fxVolume = playerPrefDefault.fxVolume;
    }
}
