using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedikitSpawner : MonoBehaviour
{
    // Variable para un timer, el tiempo maximo de ese timer y donde se guardara el objeto prefab
    private float timer;
    public float time = 10f;
    public GameObject medikitPrefab;

    // Update is called once per frame
    void Update()
    {
        // A timer se le suma 1 cada segundo
        timer += Time.deltaTime;
        // Si timer es mayor o igual a time
        if(timer >= time)
        {
            // timer vuelve a 0
            timer = 0;
            // 2 valores aleatorios para la posicion "x" y "z" con un rango de entre -100 a 100
            float x = Random.Range(-100, 100);
            float z = Random.Range(-100, 100);
            // Se le asigna la posicion del objeto prefab a la posicion del valor de x, 3 en "y" y el valor de z
            Vector3 position = new Vector3(x, 3, z);
            // Establece una rotacion estandar
            Quaternion rotation = new Quaternion();
            // Crea el objeto guardado en medikitPrefab con la posicion y rotacion asignadas arriba en el codigo
            Instantiate(medikitPrefab, position, rotation);
        }
    }
}
