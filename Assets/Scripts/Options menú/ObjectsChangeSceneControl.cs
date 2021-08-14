using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsChangeSceneControl : MonoBehaviour
{
    public void Awake()
    {
        // Se crea una variable que busca los objetos dentro del objeto con este script
        var noDestroyScenes = FindObjectsOfType<ObjectsChangeSceneControl>();
        // Condicionante por si hay mas de una copia de los objetos
        if (noDestroyScenes.Length > 1)
        {
            // Si es verdadero destruye el objeto con este script
            Destroy(gameObject);
            return;
        }
        // Evita que el objeto y sus objetos hijos se destruyan al cargar otra escena
        DontDestroyOnLoad(gameObject);
    }
}
