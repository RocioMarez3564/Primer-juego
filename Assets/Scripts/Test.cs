using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Test : MonoBehaviour
{
    // Variable de tipo transform (posision) 
    public Transform target;
    // Variable de tipo NavMeshAgent (IA de movimiento)
    private NavMeshAgent enemy;

    // Start is called before the first frame update
    void Start()
    {
        // Se le establece el componente NavMeshAgent del objeto con este script a la variable enemy
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // Se establece y actualiza el destino de enemy a la posicion del target
        enemy.destination = target.position;
    }
}
