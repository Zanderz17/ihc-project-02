using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptsAboutUs : MonoBehaviour
{
    // Definir un GameObject público que puede ser asignado desde el editor de Unity
    public GameObject objectToManipulate;

    // Método para ocultar el GameObject asignado
    public void HideGameObject()
    {
        if (objectToManipulate != null)
        {
            objectToManipulate.SetActive(false);
        }
        else
        {
            Debug.LogError("HideGameObject: No hay GameObject asignado.");
        }
    }

    // Método para mostrar el GameObject asignado
    public void ShowGameObject()
    {
        if (objectToManipulate != null)
        {
            objectToManipulate.SetActive(true);
        }
        else
        {
            Debug.LogError("ShowGameObject: No hay GameObject asignado.");
        }
    }
}
