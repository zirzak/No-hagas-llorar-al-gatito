using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class GameMaster : MonoBehaviour
{
    public Pregunta[] preguntas;
    private static List<Pregunta> sinContestar;
    private Pregunta preguntaActual;

    [SerializeField]
    private Text LaPregunta;

    [SerializeField]
    private Text OpcionA;

    [SerializeField]
    private Text OpcionB;

    [SerializeField]
    private Text OpcionC;

    [SerializeField]
    private float tiempoEntrePreguntas = 1f;

    void Start()
    {
        if (sinContestar == null || sinContestar.Count == 0)
        {
            sinContestar = preguntas.ToList<Pregunta>();
        }
        crearPregunta(); 
    }

    void Update()
    {
        if (sinContestar == null || sinContestar.Count == 0)
        {
            SceneManager.LoadScene("NoHicisteLlorarAlGatito");
        }
    }

    void crearPregunta()
    {
        int indiceDePreguntaAleatoria = Random.Range(0, sinContestar.Count);
        preguntaActual = sinContestar[indiceDePreguntaAleatoria];
        LaPregunta.text = preguntaActual.pregunta;
        OpcionA.text = preguntaActual.opcionA;
        OpcionB.text = preguntaActual.opcionB;
        OpcionC.text = preguntaActual.opcionC;
    }


    IEnumerator transicionALaSiguientePregunta()
    {
        sinContestar.Remove(preguntaActual);
        yield return new WaitForSeconds(tiempoEntrePreguntas);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void laRespuestaDelUsuario(int respuestaDelUsuario)
    {
        if(preguntaActual.respuesta == respuestaDelUsuario)
        {
            if(respuestaDelUsuario == 1)
            {
                StartCoroutine(transicionALaSiguientePregunta());
            }
            if(respuestaDelUsuario == 2)
            {
                StartCoroutine(transicionALaSiguientePregunta());
            }

            if(respuestaDelUsuario == 3)
            {
                StartCoroutine(transicionALaSiguientePregunta());
            }
            
        }
        else if (preguntaActual.respuesta != respuestaDelUsuario)
        {
            if (respuestaDelUsuario == 1)
            {
                SceneManager.LoadScene("HicisteLlorarAlGatito");
            }

            if (respuestaDelUsuario == 2)
            {
                SceneManager.LoadScene("HicisteLlorarAlGatito");
            }

            if (respuestaDelUsuario == 3)
            {
                SceneManager.LoadScene("HicisteLlorarAlGatito");
            }
        }
    }
}
