using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public string nombreDeLaEscenaACargar;

    public void CambiarDeEscena()
    {
        SceneManager.LoadScene(nombreDeLaEscenaACargar);
    }
}

