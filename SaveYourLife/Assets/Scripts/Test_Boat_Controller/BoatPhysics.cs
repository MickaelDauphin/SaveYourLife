using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatPhysics : MonoBehaviour
{
    //Drags
    public GameObject underWaterObj;

    //Script that's doing all with the boat mesh
    private ModifyBoatMesh modifyBoatmesh;

    //Mesh
    private Mesh underWaterMesh;

    //Boat rigidbody
    private Rigidbody boatRB;

    //density of water
    private float rhoWater = 1027f;
    
    void Start()
    {
        //Initialisation of the script that modify the mesh
        modifyBoatmesh = new ModifyBoatMesh(gameObject);

        //Meshes below and above the water
        underWaterMesh = underWaterObj.GetComponent<MeshFilter>().mesh;

        //Get the boat's rigidbody
        boatRB = gameObject.GetComponent<Rigidbody>();

    }

    void Update()
    {
        //Generate the under water mesh
    }
}
