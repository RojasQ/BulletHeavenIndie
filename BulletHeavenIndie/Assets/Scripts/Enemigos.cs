using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos
{

    public float velocidad;
    public int vida;
    public int damage;

    public Enemigos( int vid, float vel, int dmg){

        velocidad = vel;
        vida = vid;
        damage = dmg;

    }

    public void Golpear(){

        Manager.vidapj -= damage;
        
    }

    /* private void OnTriggerEnter(Collider pj) {
        
        if(pj = "personaje"){
            Golpear();
        }
        
    } */

}
