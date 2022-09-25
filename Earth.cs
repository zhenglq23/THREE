using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    // 声明自转速率
    public float speed1 ;
    // 声明公转速率
    public float speed2 ;
    // 公转中心
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        speed1 = 60;
        speed2 = 20;
        target = GameObject.Find("Sun");
    }

    // Update is called once per frame
    void Update()
    {
        // 使用Transform.Rotate的方式实现自转
        this.transform.Rotate (Vector3.up, speed1*Time.deltaTime, Space.Self);
        // 公转
        this.transform.RotateAround (target.transform.position, Vector3.up, speed2*Time.deltaTime);
    }
}
