using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int health = 3;

    public void Hurt()
    {
        health--;
        if (health == 0)
        {
            Debug.Log("Se murio :( ");
        }
    }
}