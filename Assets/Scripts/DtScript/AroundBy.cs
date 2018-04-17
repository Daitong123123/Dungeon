using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundBy : MonoBehaviour {
    public GameObject go;
    public int speed;
    public float x1;
    public float y1;
    public float z1;
    public float x2;
    public float y2;
    public float z2;
    private Vector3 point=new Vector3();

	// Use this for initialization
	void Start () {
        point.Set(x1, y1, z1);
	}
	
	// Update is called once per frame
	void Update () {
        go.transform.RotateAround(point, new Vector3(x1 - x2, y1 - y2, z1 - z2),speed);
	}
}
