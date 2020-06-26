using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb_Player;
    [SerializeField]
    private float cameraHeight;
    [SerializeField]
    private float cameraTilt;
    private Camera camComponent;

    

    // Start is called before the first frame update
    void Start()
    {
        camComponent = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        camComponent.transform.position = new Vector3(rb_Player.transform.position.x, cameraHeight, rb_Player.transform.position.z);
    }
}
