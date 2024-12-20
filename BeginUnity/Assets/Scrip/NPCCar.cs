using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCar : MonoBehaviour
{
    [SerializeField]
    public LineRenderer lineRenderer;
    public float speed;

    private int currentPointIndex;
    private Vector3[] point;


    // Start is called before the first frame update
    void Start()
    {
        if (lineRenderer != null) 
        {
            //int pointCount = LineRenderer.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
