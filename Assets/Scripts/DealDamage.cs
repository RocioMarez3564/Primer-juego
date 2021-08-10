using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    // variable donde se almacena el valor de los puntos de daño
    public int damagePoints = 1;

    // funcion al entrar en contacto con el collider
    private void OnTriggerEnter(Collider other)
    {
        // si el objeto tiene el tag "Player"
        if(other.tag == "Player")
        {
            // obtener la variable damagePoints de la funcion Damage del script Health
            other.GetComponent<Health>().Damage(damagePoints);
        }
    }

    // funcion al seguir en contacto con el collider
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<Health>().Damage(damagePoints);
        }
    }
}
