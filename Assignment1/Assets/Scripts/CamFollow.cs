using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target, player;

    public float speed = 1.0f;

    private float panAngle;
    private float tiltAngle;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void LateUpdate()
    {
        tiltAngle += Input.GetAxis("Mouse X") * speed;
        panAngle -= Input.GetAxis("Mouse Y") * speed;
        
        panAngle = Mathf.Clamp(panAngle, -35, 60);
       

        transform.LookAt(target);
        target.rotation = Quaternion.Euler(panAngle, tiltAngle, 0.0f);
        player.rotation = Quaternion.Euler(0f, tiltAngle, 0f);

    }

    
}



