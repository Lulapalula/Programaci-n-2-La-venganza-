using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionPorMouse : MonoBehaviour
{
    public float velRot = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movHorz = Input.GetAxis("Mouse X");
        transform.Rotate(transform.up * movHorz * velRot, Space.Self);
    }
}
