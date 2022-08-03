using UnityEngine;

public class ColorChange : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //checks if r key is pressed
        if (Input.GetKeyDown(KeyCode.R))
        {

            //it gets the color of material and sets it to red
            GetComponent<Renderer>().material.color = Color.red;
       
        }

        //checks if b key is pressed
        if (Input.GetKeyDown(KeyCode.B))
        {

            //it gets the color of material and sets it to blue
            GetComponent<Renderer>().material.color = Color.blue;

        }

        //checks if g key is pressed
        if (Input.GetKeyDown(KeyCode.G))
        {

            //it gets the color of material and sets it to green
            GetComponent<Renderer>().material.color = Color.green;

        }


    }
}
