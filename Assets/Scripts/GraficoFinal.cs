using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GraficoFinal : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sliderText1 = null;
    [SerializeField] private TextMeshProUGUI sliderText2 = null;
    [SerializeField] private TextMeshProUGUI sliderText3 = null;



    public Image imagenPositivo;
    public Image imagenNeutro;
    public Image imagenNegativo;
    public float totalUsuarios;

    public float valorNegativo;
    public float valorNegativo2;
    public float valorNeutro;
    public float valorNeutro2;
    public float valorPositivo;
    public float valorPositivo2;


    void Start()
    {
        SetValues();
    }

    public void SetValues()
    {
        totalUsuarios = MainManager.Instance.totalusuarios;

        valorNegativo = MainManager.Instance.valorfinal1 / totalUsuarios;
        valorPositivo = MainManager.Instance.valorfinal3 / totalUsuarios;
        valorNeutro = MainManager.Instance.valorfinal2 / totalUsuarios + valorNegativo + valorPositivo;

        valorNegativo2 = MainManager.Instance.valorfinal1 / totalUsuarios * 100;
        valorPositivo2 = MainManager.Instance.valorfinal3 / totalUsuarios * 100;
        valorNeutro2 = MainManager.Instance.valorfinal2 / totalUsuarios * 100;

        if (valorNeutro2 != 0)
        {
            sliderText2.text = valorNeutro2.ToString("0") + "%";
        }
        if (valorNegativo2 != 0)
        {
            sliderText1.text = valorNegativo2.ToString("0") + "%";
        }
        if (valorPositivo2 != 0)
        {
            sliderText3.text = valorPositivo2.ToString("0") + "%";
        }

        imagenNegativo.fillAmount = valorNegativo;
        imagenNeutro.fillAmount = valorNeutro;
        imagenPositivo.fillAmount = valorPositivo;
    }
}
