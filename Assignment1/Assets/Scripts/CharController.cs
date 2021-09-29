using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    public float speed;
    public float jforce;

    private bool jump;

    public Transform foot;

    public bool isgrounded;

    public LayerMask groundLayer;

    /*
    public Transform cam;
    */

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private float x;
    private float z;


    // Update is called once per frame
    void Update()
    {
       
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        isgrounded = Physics.CheckSphere(foot.position, 1, groundLayer);

        if (!jump && Input.GetKeyDown(KeyCode.Space) && isgrounded)
            jump = true;

    }





    private void FixedUpdate()
    {
        /*
        Vector3 fMove = cam.forward * z * Time.deltaTime;
        Vector3 rMove = cam.forward * x * Time.deltaTime;
        Vector3 movement = fMove + rMove; 
        

        rb.MovePosition(transform.position + movement * speed);
        
        
        rb.MovePosition(transform.position + new Vector3(x * speed * Time.deltaTime, 0, z * speed * Time.deltaTime));
        */
        Vector3 playerMovement = new Vector3(x, 0f, z) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
        

        if (jump)
        {
            rb.AddForce(Vector3.up * jforce, ForceMode.Impulse);
            jump = false;
        }
        Debug.Log(rb.velocity);
    }
}



