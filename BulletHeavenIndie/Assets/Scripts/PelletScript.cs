using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletScript : MonoBehaviour
{
    private Vector3 mousePosition;
    private Camera mainCam;
    private Rigidbody2D rb;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePosition = mainCam.ScreenToWorldPoint(Input.mousePosition);
        
        Vector3 direction = mousePosition*Random.Range(-10,10) - transform.position;
            // Vector3 rotation = transform.position*i - mousePosition*i;
            // Debug.Log(rotation);
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
            // float rot = Mathf.Atan2(rotation.y*i, rotation.x*i) * Mathf.Rad2Deg;
            // transform.rotation = Quaternion.Euler(0, 0, rot+90*i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
