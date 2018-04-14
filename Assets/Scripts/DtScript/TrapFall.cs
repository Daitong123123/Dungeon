using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFall : MonoBehaviour {
    //实现木板绕一条轴线旋转
    private Transform transform;//定义此物体的transform
    public GameObject ball; //引用player对象，为了获取球的位置
    Vector3 point;
    private bool ff = false;
    int count = 1;
    // Use this for initialization
    void Start () {
        transform = this.GetComponent<Transform>();
        point = new Vector3();
        point.Set(1, 0, 0.5f);

    }

    // Update is called once per frame
    void Update () {
        if(ff==false)
        {
            if( ball.GetComponent<Transform>().position.z>= 0.5&&ball.GetComponent<Transform>().position.x >= 0.5 && ball.GetComponent<Transform>().position.x <= 1.5&& ball.GetComponent<Transform>().position.z <= 3)
            {
                ff = true;
            }
        }
        if(ff&&count<=9)
        {
        transform.RotateAround(point, new Vector3(1, 0, 0), 5);
            count++;
        }
        
    }
    
}
