﻿using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class TitleSafeAreaDisplay : MonoBehaviour
{
    private Texture2D _blank;

    public float alpha = .15f;

    void OnDestroy()
    {
        if (_blank)
        {
            DestroyImmediate(_blank);
            _blank = null;
        }
    }

    void OnGUI()
    {
        if (!_blank)
        {
            _blank = new Texture2D(1, 1);
            _blank.SetPixel(0, 0, Color.white);
            _blank.hideFlags = HideFlags.HideAndDontSave;
        }

        float w = GetComponent<Camera>().pixelWidth;
        float h = GetComponent<Camera>().pixelHeight;

        // .05 = 5% for each side = 10% total safe area
        float wMargin = w * .05f;
        float hMargin = h * .05f;

        // red in the outer 10% is drawn because all the action of your game should be inside
        GUI.color = new Color(1, 0, 0, alpha);
        GUI.DrawTexture(new Rect(0, 0, w, hMargin), _blank, ScaleMode.StretchToFill, true);
        GUI.DrawTexture(new Rect(0, h - hMargin, w, hMargin), _blank, ScaleMode.StretchToFill, true);
        GUI.DrawTexture(new Rect(0, hMargin, wMargin, h - hMargin * 2), _blank, ScaleMode.StretchToFill, true);
        GUI.DrawTexture(new Rect(w - wMargin, hMargin, wMargin, h - hMargin * 2), _blank, ScaleMode.StretchToFill, true);

        // yellow in the outer 10-20% range is drawn because all critical UI and text should be inside
        GUI.color = new Color(1, 1, 0, alpha);
        GUI.DrawTexture(new Rect(wMargin, hMargin, w - wMargin * 2, hMargin), _blank, ScaleMode.StretchToFill, true);
        GUI.DrawTexture(new Rect(wMargin, h - hMargin * 2, w - wMargin * 2, hMargin), _blank, ScaleMode.StretchToFill, true);
        GUI.DrawTexture(new Rect(wMargin, hMargin * 2, wMargin, h - hMargin * 4), _blank, ScaleMode.StretchToFill, true);
        GUI.DrawTexture(new Rect(w - wMargin * 2, hMargin * 2, wMargin, h - hMargin * 4), _blank, ScaleMode.StretchToFill, true);
    }
}