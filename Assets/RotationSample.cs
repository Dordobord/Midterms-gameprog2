using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eBodyColor
{
    Red, Green, Blue
}
public class RotationSample : MonoBehaviour
{
    /*
    float x,y,z;
    public float rotationSpeed;
    public float timeCount = .0f;
   
    float x, y, z;
    public eBodyColor bodyColor;
    public Color Red, Green, Blue, currentColor;
    public Vector3 currentEulerAngles;
    public Quaternion currentRotation;
    public Vector3 currentEulerAngles;
    public Quaternion currentRotation;*/
    public float radius;
    public Transform targetA;
    public Transform targetB;


    /*private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 30;
        GUI.Label(new Rect(10,0,0,0), "Rotating on X:"+ x + "Y:" + y + "Z:" + z, style); //Position of the text

        //Outputs the quaternion,eulerAngles
        GUI.Label(new Rect(10,57,0,0), "CurrentEulerAngles: "+ currentEulerAngles, style);

        //Outputs the transform.eulerAngles value
        GUI.Label(new Rect(10,120,0,0), "World Euler Angles: "+ transform.eulerAngles, style);
    }*/

    void Start()
    {
        /*
        Red = Color.red;
        Blue = Color.blue;
        Green = Color.green;*/

    }
    void Update()
    {

        float dist =  Vector3.Distance(targetA.position, transform.position);
        if (dist <= radius)
        {
            LookRotation();
          
           
        }

        /*float dist2 = Vector3.Distance(targetB.position, transform.position);
        if (dist2 <= radius)
        {
            LookRotation2();
       
        }*/
    }

    /*void OnMouseDown()
    {
        switch (bodyColor)
        {
            case eBodyColor.Red:
                currentColor = Red;
                break;
            case eBodyColor.Green:
                currentColor = Green;
                break;
            case eBodyColor.Blue:
                currentColor = Blue;
                break;
            default:
                break;
        }
    }
    /*void RotateInput()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            x = 1 - x;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            y = 1 - y;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            z = 1 - y;
        }

        currentEulerAngles += new Vector3(x,y,z) * Time.deltaTime * rotationSpeed;
        currentRotation.eulerAngles = currentEulerAngles;
        transform.rotation = currentRotation;
    }

    void QuaternionRotateTowards()
    {
        float step = rotationSpeed * Time.time;       //Player            Target A
        transform.rotation = Quaternion.RotateTowards(transform.rotation,targetA.rotation, step); 
    }

    void SlerpExample()
    {
        transform.rotation = Quaternion.Slerp(targetA.rotation,targetB.rotation, timeCount); 
        timeCount = timeCount + Time.deltaTime;
    }*/
    void LookRotation() //function wherein it automatically locks to the target
    {
        Vector3 relativePos = targetA.position - transform.position;// Subtracts position from target A to the player
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }

    void LookRotation2()
    {
        Vector3 relativePos = targetB.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

}
