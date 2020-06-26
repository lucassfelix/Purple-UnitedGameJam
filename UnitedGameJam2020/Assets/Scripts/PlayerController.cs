using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameController gameController;
    private Rigidbody playerRB;
    [SerializeField]
    private float playerSpeed = 1;

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

        if (move != Vector3.zero)
        {
            playerRB.transform.position += move * Time.deltaTime * playerSpeed;
        }
    }
}
