using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        {
            //float h = Input.GetAxisRaw("Horizontal");
            //float v = Input.GetAxisRaw("Vertical");


            //this.transform.position = new Vector2(this.transform.position.x + (h * speed), this.transform.position.z + (v * speed));

            if (Input.GetKey("w"))
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + (speed * Time.deltaTime));

            if(Input.GetKey("s"))
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - (speed * Time.deltaTime));

            if(Input.GetKey("d"))
                this.transform.position = new Vector3(this.transform.position.x + (speed*Time.deltaTime), this.transform.position.y, this.transform.position.z);

            if(Input.GetKey("a"))
                this.transform.position = new Vector3(this.transform.position.x - (speed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
        }
    }
}
