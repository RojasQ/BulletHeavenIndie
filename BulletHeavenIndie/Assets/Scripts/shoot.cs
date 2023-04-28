using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    private Camera mainCam;
    private Vector3 mousePosition;
    public GameObject bullet;
    public GameObject pellet;
    public Transform bulletTransform;
    public float timer;
    public float fireRate;
    public bool canFire = true;
    public bool shotgun;

    // BulletScript[] guns;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {   
        mousePosition = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePosition - transform.position;
        
        float AxisZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, AxisZ);

        if(!canFire){

            timer += Time.deltaTime;

            if(timer > fireRate){
                canFire = true;
                timer = 0;
            }

        }

        if(canFire){

            if(shotgun){
                for(int i=0; i<3; i++){
                    GameObject p = Instantiate(pellet, bulletTransform.position, Quaternion.identity);
                //     rotation = rotation*i;
                    
                //     // Rigidbody2D prb = p.GetComponent<Rigidbody2D>();
                //     // Vector2 dir = transform.rotation * Vector2.up*i;
                //     // Vector2 pdir = Vector2.Perpendicular(dir) * Random.Range(-3,3*i);
                //     // Debug.Log(bulletTransform.position);
                //     // prb.velocity = (dir + pdir) * 5*i;
                }
            }

            canFire = false;
            Instantiate(bullet, bulletTransform.position, Quaternion.identity);

        }
    }

}
