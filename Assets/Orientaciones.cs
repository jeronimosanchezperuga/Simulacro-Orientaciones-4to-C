using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientaciones : MonoBehaviour
{
    public string nombreAlumno;
    public int anio;
    public string codigoOrientacion;

    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "")
        {
            Debug.Log("EL nombre no puede estar vacío");
            return;
        }
        if (anio < 1 || anio > 5)
        {
            Debug.Log("Año ingresado no válido");
            return;
        }
        if (codigoOrientacion != "T" && codigoOrientacion != "M" && 
            codigoOrientacion != "G" && codigoOrientacion != "H" && codigoOrientacion != "D")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
            return;
        }
        if (anio < 3)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
            return;
        }

        Debug.Log("Muchas gracias " + nombreAlumno + "!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
