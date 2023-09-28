using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonScript : MonoBehaviour
{
    // Nombre de la escena a la que quieres cambiar
    public string sceneName;

    // Método para manejar el evento de clic en el botón
    public void OnMenuButtonClick()
    {
        // Cargar la escena especificada
        SceneManager.LoadScene(sceneName);
    }
}
