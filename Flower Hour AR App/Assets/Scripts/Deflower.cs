using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deflower : MonoBehaviour
{

    private GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        //go = GameObject.Find("Flower_prefab"); // finds game object with name "name"
        go = GameObject.FindWithTag("flower"); // finds game object with tag
    }

    public void removeFlower()
    {
        //Destroy(go); //Destroy game object "go"
        bye();
        //go.SetActive(false);
    }

    public void bye()
    {
        this.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
