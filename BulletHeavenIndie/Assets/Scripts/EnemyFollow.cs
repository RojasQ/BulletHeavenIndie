using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public int direction;
    public float speed_walk;
    public float speed_run;
    public GameObject target;
    public bool atacando;

    public float rangovision;
    public float rangoataque;
    public GameObject rango;
    public GameObject hit;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Personaje");
    }

    public void Comportamientos(){

        /* if((Mathf.Abs(transform.position.x - target.transform.position.x) > rangoataque) || (Mathf.Abs(transform.position.y - target.transform.position.y) > rangoataque)) {
            atacando = false;
        } */


        if(Mathf.Abs(transform.position.x - target.transform.position.x) > rangoataque && !atacando){

            if(transform.position.y < target.transform.position.y){

                transform.Translate(Vector3.up * speed_run * Time.deltaTime);

            }else{

                transform.Translate(Vector3.down * speed_run * Time.deltaTime);

            }

            if(transform.position.x < target.transform.position.x){

                transform.Translate(Vector3.right * speed_run * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0, 0, 0);

            }else{

                transform.Translate(Vector3.right * speed_run * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0, 180, 0);

            }
        }else{

            if(!atacando){

                if(transform.position.x < target.transform.position.x){

                    transform.rotation = Quaternion.Euler(0,0,0);

                }else{

                    transform.rotation = Quaternion.Euler(0,180,0);

                }

                if(transform.position.y < target.transform.position.y){

                transform.Translate(Vector3.up * speed_run * Time.deltaTime);

                }else{

                    transform.Translate(Vector3.down * speed_run * Time.deltaTime);

                }
            }
        }
    }

    /* public void Final_ani(){
        atacando = false;
        rango.GetComponent<BoxCollider2D>().enabled = true;
    } */

    public void ColliderWeaponTrue(){
        hit.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void ColliderWeaponFalse(){
        hit.GetComponent<BoxCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Comportamientos();
    }
}
