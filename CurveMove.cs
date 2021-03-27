using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveMove : MonoBehaviour
{
  
    public GameObject target;   //要到达的目标  
    public float speed = 10;    //速度  
    public int rotationAngle = 60;
    private float distanceToTarget;   //两者之间的距离  
    private bool move = true;

    void Start()
    {
        //计算两者之间的距离  
        distanceToTarget = Vector3.Distance(this.transform.position, target.transform.position);
        StartCoroutine(Move());
    }

    IEnumerator Move() //couroutine 寫法
    { 
        while (move)  //移动到目标点停止移动
        {
            Vector3 targetPos = target.transform.position;

            //让始终它朝着目标  
            this.transform.LookAt(targetPos);

            //计算弧线中的夹角  
            float angle = Mathf.Min(1, Vector3.Distance(this.transform.position, targetPos) / distanceToTarget) * rotationAngle;
            this.transform.rotation = this.transform.rotation * Quaternion.Euler(Mathf.Clamp(-angle, -42, 42), 0, 0);
            float currentDist = Vector3.Distance(this.transform.position, target.transform.position);
            if (currentDist < 0.5f)
                move = false;
            this.transform.Translate(Vector3.forward * Mathf.Min(speed * Time.deltaTime, currentDist));
            yield return null;
        }
    }
}



