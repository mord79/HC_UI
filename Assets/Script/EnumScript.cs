using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumScript : MonoBehaviour {

	public enum GameResolution {
        Resolution1024x768,
        Resolution1280x720,
        Resolution1280x800,
        Resolution1280x1024,
        Resolution1360x768,
        Resolution1366x768,
        Resolution1440x900,
        Resolution1536x864,
        Resolution1600x900,
        Resolution1680x1050,
        Resolution1920x1080,
        Resolution1920x1200,
        Resolution2560x1080,
        Resolution2560x1440,
        Resolution3440x1440,
        Resolution3840x2160,
    };

    public enum GameLanguage {
        French,
        English,
        Russian

    };

    public enum GameDifficulty {
        Easy,
        Normal,
        Hard
    };

    public enum GaphicsQuality {
        Low,
        Medium,
        High
    };

    public enum ShadowQuality {
        Low,
        Medium,
        High
    };

    public enum WindowMode {
        Windowed,
        Fullscreen,
        FullscreenBorderless
        };

    public enum Speaker {
        RealteakDigitalOutput,
        SpeakerB,
        SpeakerC
    }



}
