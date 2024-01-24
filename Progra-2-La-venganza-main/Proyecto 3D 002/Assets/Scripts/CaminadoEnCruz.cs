using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoEnCruz : MonoBehaviour
{
    //Declaramos un atributo para la velocidad
    private Rigidbody cuerpo;
    private Animator miAnimador;

    
    public float velocidad = 3;
    void Start()
    {
        cuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }

    void Update()
    {
        //Leer el valor de inut de los ejes horizontal y vertical y guardarlos en vars
        float movVer = Input.GetAxis("Vertical");
        float movHor = Input.GetAxis("Horizontal");

        //Mandar al anim el valor de cada eje con su paramentro correspondiente
        miAnimador.SetFloat("DESPL_LATERAL", movHor);
        miAnimador.SetFloat("DESPL_FRONTAL", movVer);

        //Asignar una velocidad al rb sumando al vector frontal multiplcado por el valor del eje vertical y la velocidad mas el vector derecho (R) multiplicado de igual forma

        cuerpo.velocity = transform.forward * (movVer * velocidad) + transform.right * (movHor * velocidad);
 
    }
}
