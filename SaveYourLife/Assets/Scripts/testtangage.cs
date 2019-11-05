using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtangage : MonoBehaviour
    {

    public GameObject cube1;
    public int temps1;
    public int xAngle = 20;
    public float speed =2.0f;
    private float coef;
    private bool IsRotateRight;
    private float temps;


    private float inclinaison;
    // Start is called before the first frame update
    void Start()
    {
        cube1.transform.Rotate(5, 0, 0);
       
        if (xAngle > 0)
            coef = 1;
        else
            coef = -1;

    }

    


    // Update is called once per frame
    void Update()
    {
        temps += Time.deltaTime;
        if(temps>=temps1 && IsRotateRight)
        {
            //for (int i = 0; i <= xAngle; i++)
            //{
            //   cube1.transform.Rotate(i*Time.deltaTime, 0, 0);
            //}

            if (Mathf.Abs(ConvertAngle(transform.localEulerAngles.y)) < Mathf.Abs(xAngle) && Mathf.Abs(xAngle) < 180)
            {
                //transform.Rotate(new Vector3(100 * coef, 0, 0) * Time.deltaTime);
                transform.Rotate(new Vector3(xAngle, 0, 0) * Time.deltaTime);
            }

            transform.Rotate(new Vector3(xAngle, 0, 0) * Time.deltaTime);
            temps = 0;
            IsRotateRight = !IsRotateRight;
        }
        else if(temps>=temps1 && !IsRotateRight)
        {


            //for (int i = 0; i <= xAngle; i++)
            //{
            //    cube1.transform.Rotate(-i, 0, 0);
            //}
            


            cube1.transform.Rotate(-xAngle, 0, 0);
            //cube1.transform.Rotate(-xAngle*Time.deltaTime, 0, 0);
            temps = 0;
            IsRotateRight = !IsRotateRight;
        }
    }

    float ConvertAngle(float angle)
    {
        if (angle > 180)
            angle = 360 - angle;
        return angle;
    }
}
