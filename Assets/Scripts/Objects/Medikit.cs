using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medikit : MonoBehaviour
{
    public int hpRestore = 5;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<Health>().HealthRestore(hpRestore);
            Destroy(gameObject);
        }
    }
}
