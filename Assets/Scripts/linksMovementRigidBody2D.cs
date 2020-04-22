using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linksMovementRigidBody2D : MonoBehaviour
{
    Vector2 movement;
    KeyCode lastKeyPressed;

    private Rigidbody2D _link;
    public float speed;
    public Vector2 ySpeed;
    public Vector2 xSpeed;


    // Start is called before the first frame update
    void Start()
    {
        _link = GetComponent<Rigidbody2D>();
        speed = 6.0f;
        ySpeed = new Vector2(0, 6);
        xSpeed = new Vector2(6, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Distancia = velocidad * tiempo
        // Time.deltaTime es el tiempo transcurrido desde el último frame
        // movement es la variable que almacena el vector de movimiento del GameObject
        // El vector está formado por 3 componentes (x,y,z).
        // Modificar cualquiera de las componentes modificará la posición del elemento

        if (Input.GetKeyDown(KeyCode.W))
            lastKeyPressed = KeyCode.W;

        if (Input.GetKeyDown(KeyCode.A))
            lastKeyPressed = KeyCode.A;

        if (Input.GetKeyDown(KeyCode.S))
            lastKeyPressed = KeyCode.S;

        if (Input.GetKeyDown(KeyCode.D))
            lastKeyPressed = KeyCode.D;

        if (Input.GetKey(KeyCode.W) && lastKeyPressed == KeyCode.W)
        {
            // De esta forma movemos el personaje alterando directamente las componentes
            // de su vector2 accediendo a ellas, pero también podemos hacerlo mediante el 
            // método MovePosition
            //             movement = _link.position;
            //             movement.y += speed * Time.deltaTime;
            //             _link.position = movement;

            _link.MovePosition(_link.position + ySpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.A) && lastKeyPressed == KeyCode.A)
        {
            //movement = _link.position;
            //movement.x -= speed * Time.deltaTime;
            //_link.position = movement;

            _link.MovePosition(_link.position + -xSpeed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.S) && lastKeyPressed == KeyCode.S)
        {
            //movement = _link.position;
            //movement.y -= speed * Time.deltaTime;
            //_link.position = movement;

            _link.MovePosition(_link.position + -ySpeed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.D) && lastKeyPressed == KeyCode.D)
        {
            //movement = _link.position;
            //movement.x += speed * Time.deltaTime;
            //_link.position = movement;

            _link.MovePosition(_link.position + xSpeed * Time.deltaTime);
        }



    }

}
