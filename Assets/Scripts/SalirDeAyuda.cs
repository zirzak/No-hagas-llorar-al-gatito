using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirDeAyuda : MonoBehaviour
{
    [SerializeField]
    private Object objeto;

    public void Volver()
    {
        SceneManager.LoadScene("Menú");
    }
}
