using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    public Material Material1, Material2;
    //in the editor this is what you would set as the object you wan't to change
    public GameObject Object, Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider other){

        if(other.gameObject.name == Player.name)
        Object.GetComponent<MeshRenderer>().material = Material1;
    }

    private void OnTriggerExit(Collider other)
    {
        Object.GetComponent<MeshRenderer>().material = Material2;  
    }
}
