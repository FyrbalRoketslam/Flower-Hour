using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))] //lmits the specific type of object that can be used.

public class ARTapToPlaceObject : MonoBehaviour
{
    public GameObject gameObjectToInstantiate;
    //public GameObject deflower;

    private GameObject spawnedObject;
    private ARRaycastManager _arRaycastManager;
    private Vector2 touchPosition;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

 private void Awake()
    {
        _arRaycastManager = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if(Input.touchCount > 0)
        {
            touchPosition = new Vector2(Screen.width, Screen.height);
                //Input.GetTouch(0).position;
            return true;
        }

        touchPosition = default;
        return false;
    }

    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 touchPosition))
            return;

        if (_arRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon)) //raycast manager defined up top, this one uses the raycast method wich gives us the touch positon, takes hits, trackable types(looks up Trackable Type on Unity for more info).
        {
            var hitPose = hits[0].pose;

            if(spawnedObject == null)
            {
                spawnedObject = Instantiate(gameObjectToInstantiate, hitPose.position, hitPose.rotation);
                GetComponent<AudioSource>().Play(); //****From Vuforia Project
            }
            else
            {
                spawnedObject.transform.position = hitPose.position;
                GetComponent<AudioSource>().Stop();//******From Vuforia Project
            }
        }
               
    }

    public void tap2remove()
    {
        Destroy(spawnedObject);
        Debug.Log("tap2remove activated");
    }
}
