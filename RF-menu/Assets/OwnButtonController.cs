using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnButtonController : MonoBehaviour
{
    public GameObject objectToManipulate;

    public void StartButton()
    {
        Debug.Log("Iniciando museo...");
    }

    public void MultiplayerButton()
    {
        Debug.Log("Iniciando multijugador...");
    }

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

    public void AboutUsButton()
    {
        Debug.Log("Iniciando Acerca de Nosotros...");
        ShowGameObject();
    }

    public void QuitButton()
    {
        Debug.Log("Iniciando Salir...");
    }
}
