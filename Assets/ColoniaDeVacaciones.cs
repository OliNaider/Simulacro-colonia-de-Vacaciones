using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoniaDeVacaciones : MonoBehaviour
{
    public int cantInfantiles;
    public int cantJuveniles;

    int cantProfesoresI;
    int cantProfesoresJ;
    int cantCoordinadores;
    int listaEspera;
    int profesTotales;

    // Start is called before the first frame update
    void Start()
    {

        profesTotales = cantProfesoresJ + cantProfesoresI;

        if (cantInfantiles < 0  || cantInfantiles > 100) {
            Debug.Log("Valores invalidos para los infantiles");
            return;
        } else if (cantJuveniles < 0 || cantJuveniles > 100)
        {
            Debug.Log("Valores invalidos para los juveniles");
            return;
        }

        cantCoordinadores = profesTotales/5;
        cantProfesoresI = cantInfantiles / 10;
        cantProfesoresJ = cantJuveniles / 20;

        listaEspera = (cantInfantiles % 10) + (cantJuveniles % 20);

        Debug.Log("Se necesitan " + cantProfesoresJ + " profesores para los inscriptos juveniles");
        Debug.Log("Se necesitan " + cantProfesoresI + " profesores para los inscriptos infantiles");
        Debug.Log("Hay " + listaEspera + " personas en la lista de espera");
        Debug.Log("Se necesitan " + cantCoordinadores + " coordinadores");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
