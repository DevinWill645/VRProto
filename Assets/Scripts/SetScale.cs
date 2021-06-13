using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class SetScale : MonoBehaviour
{
   //float degrees = getSmoothedValue(transform.localEulerAngles.y);

    //Debug.Log(degrees);
    
    public float scale;

   public void Start()
    {
        scale = 1.0f;
    }
    
  /*  void GetDegree()
    {
        public GameObject knob = GameObject.Find("Knob");

        //public float knobScript = knob.GetComponent<<HingeHelper>>();

        //float degree = HingeHelper.val;

        //Debug.Log(degree);
    }*/
    
   public void ScaleUp()
    {  
        //GOAL is to have this function accept the degree value from the knob
        //if the degree number increases by 10(the specified degree amount) apply +=0.5f to the local scale of the cube
        //if the degree number decreases by 10, subtract 0.5f from the local scale of the cube
        // Currently only scales up by 0.5f each time a change is detected, whether and increase or decrease in degrees..

        //Currently having weird compiler errors and cannot accept the value from HingeHelper.


        Debug.Log("Hinge Twist");
        scale += 0.5f;
        transform.localScale = new Vector3(/*Random.Range(0.2f, 5.0f)*/scale, scale, /*Random.Range(0.2f, 0.5f)*/scale);
    }
}
