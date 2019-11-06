using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public bool CanOpen;
    float Rotation;
    int y = 0;
    public int maxOpen;
    private bool isDo = false;
    public GameObject L1, L2, L3, L4;
    void Start()
    {
        CanOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (L1.GetComponent<Levier>().ValeurL1 + L2.GetComponent<Levier>().ValeurL2 + L3.GetComponent<Levier>().ValeurL3 + L4.GetComponent<Levier>().ValeurL4 == 2321)
            CanOpen = true;
        if (CanOpen && transform.localEulerAngles.y < maxOpen && maxOpen > 0 && maxOpen < 180)
        {
            transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
        }
        if (CanOpen && maxOpen > 180)
        {
            if (transform.localEulerAngles.y <= 45 && transform.localEulerAngles.y > 0 || transform.localEulerAngles.y > maxOpen)
            {
                transform.Rotate(new Vector3(0, -100, 0) * Time.deltaTime);
            }
        }
    }
}
