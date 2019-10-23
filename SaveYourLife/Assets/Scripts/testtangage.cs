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
    private bool b;


    public Transform from;
    public Transform to;

    private float timeCount = 0.0f;

    private float inclinaison;
    // Start is called before the first frame update
    void Start()
    {
        //Scube1.transform.Rotate(5, 0, 0);

        if (xAngle > 0)
            coef = -1;
        else
            coef = 1;

        b = true;
    }


  

    // Update is called once per frame
    void Update()
    {


 
        if (b)
        {

            transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, timeCount * speed);
            timeCount = timeCount + Time.deltaTime;
            if (timeCount >= 0.99)
            {
                b = false;
                timeCount = 0.0f;
            }

        }
        else
        {

            transform.rotation = Quaternion.Slerp(to.rotation, from.rotation, timeCount * speed);
            timeCount = timeCount + Time.deltaTime;
            if (timeCount >= 0.99)
            {
                b = true;
                timeCount = 0.0f;
            }

        }





        /*
        print(ConvertAngle(transform.localEulerAngles.x));
        if (ConvertAngle(transform.localEulerAngles.x) <= xAngle)
        {
            //transform.Rotate(new Vector3(100 * coef, 0, 0) * Time.deltaTime);
            transform.Rotate(new Vector3(speed * coef, 0, 0) * Time.deltaTime);
        }
        else if (xAngle > 0)
        {
            xAngle = -xAngle;

        }


        if (ConvertAngle(transform.localEulerAngles.x) > xAngle)
        {
            //transform.Rotate(new Vector3(100 * coef, 0, 0) * Time.deltaTime);
            transform.Rotate(new Vector3(speed * -coef, 0, 0) * Time.deltaTime);
        }
        else if (xAngle < 0)
        {
            xAngle = -xAngle;
        }





        print("Tourne vers " + coef);
            print("rapproche de l'angle " + xAngle); 
        */

        //    temps += Time.deltaTime;
        //    if(temps>=temps1 && IsRotateRight)
        //    {
        //        //for (int i = 0; i <= xAngle; i++)
        //        //{
        //        //   cube1.transform.Rotate(i*Time.deltaTime, 0, 0);
        //        //}



        //        //transform.Rotate(new Vector3(xAngle, 0, 0) * Time.deltaTime);
        //        //transform.Rotate(new Vector3(0, 100 * 45, 0) * Time.deltaTime);




        //        temps = 0;
        //        IsRotateRight = !IsRotateRight;
        //    }
        //    else if(temps>=temps1 && !IsRotateRight)
        //    {


        //        //for (int i = 0; i <= xAngle; i++)
        //        //{
        //        //    cube1.transform.Rotate(-i, 0, 0);
        //        //}



        //        cube1.transform.Rotate(-xAngle, 0, 0);
        //        //cube1.transform.Rotate(-xAngle*Time.deltaTime, 0, 0);
        //        temps = 0;
        //        IsRotateRight = !IsRotateRight;
        //    }
        //}
    }
    float ConvertAngle(float angle)
    {
        if (angle > 180)
            angle = angle - 360;
        return angle;
    }
}
