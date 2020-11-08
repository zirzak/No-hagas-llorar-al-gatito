using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickAJugar : MonoBehaviour
{
    public void loQuePasaCuandoMeClickean()
    {
        SceneManager.LoadScene("Juego");
    }
}
