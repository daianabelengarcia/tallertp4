using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valorfinal : MonoBehaviour
{
    [SerializeField] public float localValue;
    [SerializeField] public bool eligio = false;

    public void SliderChange(float value)
    {
        localValue = value;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.F))
        {
            eligio = true;
        }
        if (eligio)
        {
            if (localValue > 1.0f && localValue < 1.5f)
            {
                Debug.Log("La IA no beneficia a los docentes");
                MainManager.Instance.valorfinal1 += 1;
            }
            if (localValue > 1.5f && localValue < 2.5f)
            {
                Debug.Log("No estoy seguro");
                MainManager.Instance.valorfinal2 += 1;
            }
            if (localValue > 2.5f && localValue < 3f)
            {
                Debug.Log("La IA beneficia a los docentes");
                MainManager.Instance.valorfinal3 += 1;
            }

            MainManager.Instance.totalusuarios += 1;
            eligio = false;
        }
    }
}
