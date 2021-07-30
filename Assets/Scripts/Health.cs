using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 10;
    public bool invencible = false;
    public float invulTime = 1f;

    public void Damage(int damagePoints)
    {
        if(!invencible && health > 0)
        {
            health -= damagePoints;
            StartCoroutine(Invulnerability());
        }
    }

    IEnumerator Invulnerability()
    {
        invencible = true;
        yield return new WaitForSeconds(invulTime);
        invencible = false;
    }
}
