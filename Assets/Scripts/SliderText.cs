using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderText : MonoBehaviour
{

    TextMeshProUGUI textComponent;

    void Start()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
    }

    public void SetSliderValue(float sliderValue)
    {
        int rounded_f = (int)(sliderValue*100 + 0.5f);
        textComponent.text = (rounded_f).ToString();
    }
}