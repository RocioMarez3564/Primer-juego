using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedikitSpawner : MonoBehaviour
{
    public float timer;
    public GameObject medikitPrefab;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 5)
        {
            timer = 0;
            float x = Random.Range(-100, 100);
            float z = Random.Range(-100, 100);
            Vector3 position = new Vector3(x, 3, z);
            Quaternion rotation = new Quaternion();
            Instantiate(medikitPrefab, position, rotation);
        }
    }
}
