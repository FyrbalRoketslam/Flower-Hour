using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;

public class Billboard : MonoBehaviour
{
    public Camera AR_Camera;
    //public GameObject deflower;

    void Awake()
    {
        AR_Camera = FindObjectOfType<Camera>();
    }
    void LateUpdate()
    {
        transform.LookAt(transform.position + AR_Camera.transform.rotation * Vector3.forward,
            AR_Camera.transform.rotation * Vector3.up);

        // The next three lines make this work only on the horizontal axis
        Vector3 eulerAngles = transform.eulerAngles;
        eulerAngles.x = 0;
        transform.eulerAngles = eulerAngles;

    }

    public void Deflower()
    {
        bye();
        //gameObject.SetActive(false);
    }

    public void bye()
    {
        gameObject.SetActive(false);
    }
}
