using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickAQueGatito : MonoBehaviour
{
    public void loQuePasaCuandoMeClickean()
    {
        SceneManager.LoadScene("QueGatito");
    }
}
