using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOnTouch : MonoBehaviour
{
    public Material sky1;
    public Material sky2;
    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = sky1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        RenderSettings.skybox = sky2;
        Destroy(light);
    }
}
