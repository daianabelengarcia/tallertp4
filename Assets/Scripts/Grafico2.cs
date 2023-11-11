using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grafico2 : MonoBehaviour
{
    public GameObject hoverImage;
    public GameObject texto;
    private bool isActive = false;

    void Start()
    {
        // Asegúrate de que ambas imágenes estén configuradas correctamente en el Inspector
        if (hoverImage == null || texto == null)
        {
            Debug.LogError("Asigna las imágenes en el Inspector");
            return;
        }

        // Comienza mostrando la imagen normal y ocultando la imagen de hover
        hoverImage.SetActive(false);
        texto.SetActive(false);
    }

    public void OnMouseOver()
    {
        // Al pasar el ratón sobre la imagen y no está activada, oculta la imagen normal y muestra la imagen de hover
        if (!isActive)
        {
            hoverImage.SetActive(true);
        }
    }

    public void OnMouseExit()
    {
        // Al salir del área de la imagen y no está activada, vuelve a mostrar la imagen normal y oculta la imagen de hover
        if (!isActive)
        {
            hoverImage.SetActive(false);
        }
    }

    public void OnMouseDown()
    {
        // Al hacer clic, activa/desactiva la imagen de hover
        isActive = !isActive;

        hoverImage.SetActive(isActive);
        texto.SetActive(isActive);
    }
}
