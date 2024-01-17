using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoSimple : MonoBehaviour
{
    private Rigidbody miCuerpo;
    private Animator miAnimador;

    public float velocidadCaminar = 8;
    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movHoriz = Input.GetAxis("Horizontal");
        float movVert = Input.GetAxis("Vertical");

        if (movVert > 0)
        {
            miCuerpo.velocity = new Vector3(0, 0, velocidadCaminar);
            miAnimador.SetBool("CAMINANDO", true);
        }
        else if (movVert < 0)
        {
            miCuerpo.velocity = new Vector3(0, 0, -velocidadCaminar);
            miAnimador.SetBool("CAMINANDO", false);
        }

        else if (movHoriz > 0)
        {
            miCuerpo.velocity = new Vector3(velocidadCaminar, 0, 0);
            miAnimador.SetBool("CAMINANDO", true);
        }

        else if (movHoriz < 0)
        {
            miCuerpo.velocity = new Vector3(-velocidadCaminar, 0, 0);
            miAnimador.SetBool("CAMINANDO", true);
        }
        else
        {
            miCuerpo.velocity = new Vector3(0, 0, 0);
            miAnimador.SetBool("CAMINANDO", false);
        }

    }
}
