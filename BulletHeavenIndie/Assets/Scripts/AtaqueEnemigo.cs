using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEnemigo : MonoBehaviour
{

    public EnemyFollow enemigo;
    
    void OnTriggerEnter2D(Collider2D coll){

        if(coll.CompareTag("personaje")){
            Debug.Log("Hace danio");
            enemigo.atacando = false;
        }

    }
}
