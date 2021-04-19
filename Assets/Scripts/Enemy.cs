using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamage
{
    private int health = 50;

    public void TakeDamage() { //From IDamage
        health--;
        Debug.Log("Enemy health: " + health);
    }
}
