using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    public GameObject player;
    public float distance;
    Vector3 playerPosition;
    Vector3 chestPosition;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Link");

        playerPosition = player.transform.position;
        chestPosition = this.transform.position;

        distance = Vector3.Distance(playerPosition, chestPosition);

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (distance < 1.5f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("open", true);
            }
        }
        else
        {
            playerPosition = player.transform.position;
            distance = Vector3.Distance(playerPosition, chestPosition);
        }
        
    }
}
