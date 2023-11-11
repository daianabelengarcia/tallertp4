using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examen : MonoBehaviour
{
    public float localValue;
    public GameObject Examen;
    public Transform ControladorExamen;

    public bool unomas;
    public bool borrarexamen;
    public float valorAnterior;
    private List<GameObject> lastInstances = new List<GameObject>();
    private float cuantosmas;
    private float cuantosmenos;
    private float originalXPosition;
    private float originalYPosition;
    private float paraAbajo = 0.7f; // Distancia hacia abajo entre filas
    private float paraDerecha = 1f; // Distancia hacia la derecha entre objetos
    private int objetosPorFila = 10; // Número de objetos por fila
    private bool bajo = false;

    public void Start()
    {
        originalXPosition = ControladorExamen.position.x;
        originalYPosition = ControladorExamen.position.y;
    }

    public void SliderChange(float value)
    {
        localValue = value;
        if (localValue > valorAnterior)
        {
            cuantosmas = localValue - valorAnterior;
            unomas = true;
            borrarexamen = false;
        }
        if (localValue < valorAnterior)
        {
            cuantosmenos = valorAnterior - localValue;
            borrarexamen = true;
        }
        if (borrarexamen && lastInstances.Count > 0)
        {
            for (int i = 0; i < cuantosmenos && lastInstances.Count > 0; i++)
            {
                int lastIndex = lastInstances.Count - 1;
                GameObject lastInstance = lastInstances[lastIndex];
                Destroy(lastInstance);
                lastInstances.RemoveAt(lastIndex);
            }
        }
        if (unomas)
        {
            for (int i = 0; i < cuantosmas; i++)
            {
                // Calcula la posición en función del número actual de instancias
                Vector3 nuevaPosicion = new Vector3(originalXPosition + (lastInstances.Count % objetosPorFila) * paraDerecha,
                                                  originalYPosition - (lastInstances.Count / objetosPorFila) * paraAbajo,
                                                  0f);

                GameObject nuevaInstancia = Instantiate(Examen, nuevaPosicion, Quaternion.identity);
                lastInstances.Add(nuevaInstancia);
            }
            unomas = false;
        }
        valorAnterior = localValue;
    }
}
