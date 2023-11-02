using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ValorUsuario : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sliderText = null;
    [SerializeField] private float localValue;
    [SerializeField] private float num = 1f;

    void Update()
    {
        localValue = MainManager.Instance.ValorUsuario1 * num;
        sliderText.text = localValue.ToString("0");
        Debug.Log(MainManager.Instance.ValorUsuario1);
    }
}
