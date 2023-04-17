using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    [SerializeField] private float speed = 3.0f;
    Enemigos Myenemies;

    private Rigidbody2D rb;
    
    public static int vidapj = 10;
    private Vector2 moveInput;

    private void Start(){

        rb = GetComponent<Rigidbody2D>();

        Myenemies = new Enemigos(4, 1, 2);

    }

    void Update(){

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2( moveX, moveY).normalized;
    }

    private void FixedUpdate(){

        rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);

    }
}
