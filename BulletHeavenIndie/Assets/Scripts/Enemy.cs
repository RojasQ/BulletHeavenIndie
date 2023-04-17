using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float velocidad;
    public int vida;
    public int damage = 10;

    private Rigidbody2D EnemyRig;

    void Start()
    {
        EnemyRig = GetComponent<Rigidbody2D>();
    }

    public void Golpear(){

        Manager.vidapj -= damage;
        
    }

    private void OnTriggerEnter(Collider pj) {
        
        /* if(pj = "personaje"){
            Golpear();
        } */
        
    }
}
