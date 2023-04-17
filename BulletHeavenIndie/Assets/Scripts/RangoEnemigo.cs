using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoEnemigo : MonoBehaviour
{

    public EnemyFollow enemigo;

    public float timer;
    public float attackTime = 0.3f;

    void Update()
    {
        

        if(enemigo.atacando){

            timer += Time.deltaTime;

            if(timer > attackTime){
                timer = 0;
                enemigo.atacando = false;
            }
            GetComponent<BoxCollider2D>().enabled = false;
        }else{
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        if(other.CompareTag("personaje")){
            enemigo.atacando = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }

    }

}
