using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtangage : MonoBehaviour
    {

    public GameObject cube1;
    public int temps1;

    private int xAngle = 20;
    private bool IsRotateRight;
    private float temps;
    // Start is called before the first frame update
    void Start()
    {
        cube1.transform.Rotate(10, 0, 0);
    }

    


    // Update is called once per frame
    void Update()
    {
        temps += Time.deltaTime;
        if(temps>=temps1 && IsRotateRight)
        {
            for (int i = 0; i <= xAngle; i++)
            {
               cube1.transform.Rotate(i*Time.deltaTime, 0, 0);
            }
            
            //cube1.transform.Rotate(xAngle*Time.deltaTime, 0, 0);
            temps = 0;
            IsRotateRight = !IsRotateRight;
        }
        else if(temps>=temps1 && !IsRotateRight)
        {
           
            
            //for (int i = 0; i <= xAngle; i++)
            //{
            //    cube1.transform.Rotate(-i, 0, 0);
            //}
            
            cube1.transform.Rotate(-xAngle*Time.deltaTime, 0, 0);
            temps = 0;
            IsRotateRight = !IsRotateRight;
        }
    }
}
