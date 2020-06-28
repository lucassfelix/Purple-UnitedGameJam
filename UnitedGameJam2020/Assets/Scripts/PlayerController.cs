using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameController gameController;
    private Rigidbody playerRB;
    [SerializeField]
    private float playerSpeed = 1;

    public float maxVelocity = 10.0f;

    private Vector3 move;

    void Update() {
        playerRB = gameController.getCurrentPlayer().GetComponent<Rigidbody>();

        move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }


    void FixedUpdate()
    {

        if (move != Vector3.zero)
        {
            playerRB.velocity = move*playerSpeed;

        }
    }
}
