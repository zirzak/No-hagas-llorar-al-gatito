using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTarjetas : MonoBehaviour
{
    [SerializeField]
    private Object objeto;

    [SerializeField]
    private Animator animator;


    public void moverTarjetas()
    {
        animator.SetTrigger("Transicion");
    }


}
