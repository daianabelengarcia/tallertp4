using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorSlider : MonoBehaviour
{
[SerializeField] private TextMeshProUGUI sliderText = null;
[SerializeField] private float maxSlider = 1f;
[SerializeField] public float localValue;

public void SliderChange(float value)
{
    localValue = value * maxSlider;
    sliderText.text = localValue.ToString("0");

     MainManager.Instance.ValorUsuario1 = localValue;
}
}
