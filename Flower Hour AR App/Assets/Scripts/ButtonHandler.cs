using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonHandler : MonoBehaviour
{
    GameObject controllerGO;
    //MyHelloAR scriptMyHelloAR;
    GameObject cubeGO;
    GameObject sphereGO;
    GameObject andyGO;


    public void ChangeObjectTypeToCube()
    {
        controllerGO = GameObject.Find("Controller");
        //scriptMyHelloAR = controllerGO.GetComponent<MyHelloAR>();
        cubeGO = GameObject.Find("cube");
        //scriptMyHelloAR.AndyPlanePrefab = cubeGO;
    }
    public void ChangeObjectTypeToSphere()
    {
        controllerGO = GameObject.Find("Controller");
        //scriptMyHelloAR = controllerGO.GetComponent<MyHelloAR>();
        sphereGO = GameObject.Find("sphere");
        //scriptMyHelloAR.AndyPlanePrefab = sphereGO;
    }
    public void ChangeObjectTypeToAndy()
    {
        controllerGO = GameObject.Find("Controller");
        //scriptMyHelloAR = controllerGO.GetComponent<MyHelloAR>();
        andyGO = GameObject.Find("AndyGreen");
        //scriptMyHelloAR.AndyPlanePrefab = andyGO;
    }
}
