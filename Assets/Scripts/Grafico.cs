using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Grafico : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public Image normalImage;
    public Image hoverImage;
    public Image texto;

    private bool isActive = false;

    void Start()
    {
        // Asegúrate de que ambas imágenes estén configuradas correctamente en el Inspector
        if (normalImage == null || hoverImage == null || texto == null)
        {
            Debug.LogError("Asigna las imágenes en el Inspector");
            return;
        }

        // Comienza mostrando la imagen normal y ocultando la imagen de hover
        normalImage.gameObject.SetActive(true);
        hoverImage.gameObject.SetActive(false);
        texto.gameObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Al pasar el ratón sobre la imagen y no está activada, oculta la imagen normal y muestra la imagen de hover
        if (!isActive)
        {
            hoverImage.gameObject.SetActive(true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Al salir del área de la imagen y no está activada, vuelve a mostrar la imagen normal y oculta la imagen de hover
        if (!isActive)
        {
            hoverImage.gameObject.SetActive(false);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Al hacer clic, activa/desactiva la imagen de hover
        isActive = !isActive;

        hoverImage.gameObject.SetActive(isActive);
        texto.gameObject.SetActive(isActive);
    }
}
