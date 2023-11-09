using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorExamen : MonoBehaviour
{
    private Transform ControladorExamen;
    private examen exam;

    public float time;
    // Start is called before the first frame update
    void Start()
    {
        ControladorExamen = GameObject.Find("ControladorExamen").transform;
        exam = ControladorExamen.GetComponent<examen>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
