using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linksAnimation : MonoBehaviour
{

    Animator animator;
    private Stack<KeyCode> stack = new Stack<KeyCode>();
    KeyCode lastKeyPressed;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
            lastKeyPressed = KeyCode.W;

        if (Input.GetKeyDown(KeyCode.A))
            lastKeyPressed = KeyCode.A;

        if (Input.GetKeyDown(KeyCode.S))
            lastKeyPressed = KeyCode.S;

        if (Input.GetKeyDown(KeyCode.D))
            lastKeyPressed = KeyCode.D;


        if (Input.GetKey(KeyCode.W) && lastKeyPressed == KeyCode.W)
            animator.SetBool("walking_up", true);

        else
            animator.SetBool("walking_up", false);


        if (Input.GetKey(KeyCode.A) && lastKeyPressed == KeyCode.A)
            animator.SetBool("walking_left", true);

        else
            animator.SetBool("walking_left", false);


        if (Input.GetKey(KeyCode.S) && lastKeyPressed == KeyCode.S)
            animator.SetBool("walking_down", true);

        else
            animator.SetBool("walking_down", false);


        if (Input.GetKey(KeyCode.D) && lastKeyPressed == KeyCode.D)
            animator.SetBool("walking_right", true);

        else
            animator.SetBool("walking_right", false);


    }


}
