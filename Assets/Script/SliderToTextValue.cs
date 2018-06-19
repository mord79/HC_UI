using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderToTextValue : MonoBehaviour {

    public Scrollbar scrollbar;
    public Text text;

    public void UpdateText()
    {
        float val = Mathf.RoundToInt(scrollbar.value * 100);
        text.text = val.ToString();
    }
}
