using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameController gc;

    [SerializeField]
    private Rigidbody rb_Player;
    [SerializeField]
    private float cameraHeight = 10;
    [SerializeField]
    private float anguloCamera;
    private Camera camComponent;
    private float distCamera;

    // Start is called before the first frame update
    void Start()
    {
        camComponent = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        rb_Player = gc.getCurrentPlayer().GetComponent<Rigidbody>();
        //float angB = 90 - anguloCamera;
        //var distCamera = cameraHeight / Mathf.Sin(angB);

        //var dista = rb_Player.transform.position + new Vector3(0, 0 , distCamera);

        //gameObject.transform.rotation.SetFromToRotation(gameObject.transform.position, dista);

        var dist = new Vector3(0,cameraHeight,0);

        camComponent.transform.position = rb_Player.transform.position + dist;
    }
}
