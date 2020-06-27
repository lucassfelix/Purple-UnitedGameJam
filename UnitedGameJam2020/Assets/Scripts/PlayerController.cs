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
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update() {
        playerRB = gameController.getCurrentPlayer().GetComponent<Rigidbody>();

        move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    // Update is called once per frame



    void FixedUpdate()
    {
        // if(playerRB.velocity.magnitude > maxVelocity)
        // {
        //     var execedVelocity = playerRB.velocity.magnitude - maxVelocity;
        //     var opposite = -playerRB .velocity;
        //     playerRB.AddForce(opposite.normalized *execedVelocity);
        // }

        if (move != Vector3.zero)
        {
            playerRB.velocity = move*playerSpeed;

        }
    }
}
