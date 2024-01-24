using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoSimple : MonoBehaviour
{
    //Crear atributos para el Rigidbody, animator y velocidad
    private Rigidbody cuerpo;
    private Animator miAnimador;

    public float velocidad = 3f;

    void Start()
    {
        //Obtener los componentes de rb y del anim para guardarlos en los atributos
        cuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }

    void Update()
    {
        //leo el imput del eje vertical
        float inputVertical = Input.GetAxis("Vertical");
        float inputHorizontal = Input.GetAxis("Horizontal");

        //Si el valor es mayor a cero entonces aplicar una velocidad al rb de (0, 0, velocidad) y activo el parametro CAMINANDO del animator
        if (inputVertical != 0 || inputHorizontal != 0)
        {
            Vector3 caminata = new Vector3(inputHorizontal * velocidad, 0, inputVertical * velocidad);
            cuerpo.velocity = caminata;
            miAnimador.SetBool("CAMINANDO", true);
        }
        else
        {
            //Si el valor no es mayor a 0 entonces anulo la velocidad y desactivo caminando
            cuerpo.velocity = Vector3.zero;
            miAnimador.SetBool("CAMINANDO", false);
        }
    }
}
