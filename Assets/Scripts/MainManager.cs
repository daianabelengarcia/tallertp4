using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class MainManager : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now
    public static MainManager Instance;
    public float ValorUsuario1;

    public float valorfinal1;
    public float valorfinal2;
    public float valorfinal3;
    public float totalusuarios;

    private void Awake()
    {
       // start of new code
    if (Instance != null)
    {
        Destroy(gameObject);
        return;
    }
    // end of new code

    Instance = this;
    DontDestroyOnLoad(gameObject);
    }
}
