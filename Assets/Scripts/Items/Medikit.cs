using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medikit : MonoBehaviour
{
    // Valor que indica la cantidad de vida que se curara el personaje
    public int hpRestore = 5;

    // funcion que se llama al entrar en contacto con la colision 
    public void OnTriggerEnter(Collider other)
    {
        // Si el tag del objeto es "Player"
        if(other.tag == "Player")
        {
            // Accede a su script "Health" y a la funcion "HealthRestore" le asigna el valor a su variable de hpRestore el de este script
            other.GetComponent<Health>().HealthRestore(hpRestore);
            // Se destruye el objeto
            Destroy(gameObject);
        }
    }
}
