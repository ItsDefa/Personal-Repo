using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;

    public float smoothspeed = 0.1f;

    private void LateUpdate()
    {
        transform.position = target.position;

    }

}
