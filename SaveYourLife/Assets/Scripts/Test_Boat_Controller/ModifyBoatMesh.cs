using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyBoatMesh
{
    //The boat transform
    private Transform boatTrans;

    //Coordinates of all vertices
    Vector3[] boatVertices;

    //Positions of allVerticesArray to build triangles
    int[] boatTriangles;

    //Transformation from local to global
    public Vector3[] boatVerticesGlobal;

    //Find all the distances to water
    float[] allDistancesToWater;

    //The triangles belonging  to the part under water
    public List<TriangleData>

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
