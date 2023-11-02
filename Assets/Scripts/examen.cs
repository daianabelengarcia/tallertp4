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
    private float originalXPosition; // Almacena la posición original en el eje X del ControladorExamen
    private float paraAbajo = -0.5f;
    public void Start()
    {
        originalXPosition = ControladorExamen.position.x; // Almacena la posición original en el eje X
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
                Destroy(lastInstance); // Destruye la última instancia
                ControladorExamen.position -= new Vector3(1f, 0f, 0f); // Retrocede la posición
                lastInstances.RemoveAt(lastIndex); // Elimina la referencia de la lista
            }
        }
        if (unomas)
        {
            if (localValue%10==0)
            {
                ControladorExamen.position = new Vector3(originalXPosition, paraAbajo, ControladorExamen.position.z); // Restablece la posición en X
                paraAbajo -= paraAbajo;
            }
            for (int i = 0; i < cuantosmas; i++)
            {
                // Instancia el objeto Examen en la posición actual
                GameObject newInstance = Instantiate(Examen, ControladorExamen.position, Quaternion.identity);
                ControladorExamen.position += new Vector3(1f, 0f, 0f); // Avanza la posición
                lastInstances.Add(newInstance); // Agrega la nueva instancia a la lista

            }
            unomas = false;
        }
        valorAnterior = localValue;
    }
}
