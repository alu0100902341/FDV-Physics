using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linksMovement : MonoBehaviour
{
    Vector3 movement;
    public float speed;

    private Stack<KeyCode> stack = new Stack<KeyCode>();
    KeyCode lastKeyPressed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 6.0f;

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
            movement = this.transform.position;
            movement.y += speed * Time.deltaTime;
            this.transform.position = movement;
        }

        if (Input.GetKey(KeyCode.A) && lastKeyPressed ==  KeyCode.A)
        {
            movement = this.transform.position;
            movement.x -= speed * Time.deltaTime;
            this.transform.position = movement;
        }


        if (Input.GetKey(KeyCode.S) && lastKeyPressed ==  KeyCode.S)
        {
            movement = this.transform.position;
            movement.y -= speed * Time.deltaTime;
            this.transform.position = movement;
        }


        if (Input.GetKey(KeyCode.D) && lastKeyPressed ==  KeyCode.D)
        {
            movement = this.transform.position;
            movement.x += speed * Time.deltaTime;
            this.transform.position = movement;
        }

        

    }

}
