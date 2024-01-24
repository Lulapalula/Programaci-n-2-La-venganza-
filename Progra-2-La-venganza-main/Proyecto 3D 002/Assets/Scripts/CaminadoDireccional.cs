using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoDireccional : MonoBehaviour
{
    //Crear atributos para el RB el Animator y la velocidad
    private Rigidbody cuerpo;
    private Animator miAnimador;

    public float velocidad = 5f;
    public float rotacion = 5f;

    // Start is called before the first frame update
    void Start()
    {
        cuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Leer el valor de inut de los ejes horizontal y vertical y guardarlos en vars
        float movVer = Input.GetAxis("Vertical");
        float movHor = Input.GetAxis("Horizontal");

        //Crear un nuevo vector llamado direccion y le asigno ael valor horizontal a x y el valor vertical z
        Vector3 direccion = new Vector3(movHor, 0, movVer);

        //a la hora de cambiar la direccion aplicar la funcion lerp
        transform.forward = Vector3.Lerp(transform.forward, direccion, Time.deltaTime * rotacion);


        //si la magitud del vector de direccion es mayor que 0 activo en el animator el parametro booleano de caminado si no lo desactivo
        if (direccion.magnitude > 0)
        {
            //Asignar el vector de direccion a la propoiedad forward del transform
            transform.forward = direccion;
            miAnimador.SetBool("CAMINANDO", true);
        }
        else
        {
            miAnimador.SetBool("CAMINANDO", false);
        }

        //Asignar al rb la velocidad a partir de multiplicar el vector forward por la magnitud del vector de direccion por el parametro velocidad
        cuerpo.velocity = transform.forward * (direccion.magnitude * velocidad);
    }
}
