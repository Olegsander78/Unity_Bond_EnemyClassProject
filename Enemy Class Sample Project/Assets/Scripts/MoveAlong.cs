using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlong : MonoBehaviour
{
   void LateUpdate()
    {
        CountItHigher cih = this.gameObject.GetComponent<CountItHigher>();
        if (cih != null)
        {
            float tX = cih.currentNum / 10f;
            //float tY = cih.currentNum / 150f;
            //float tZ = cih.currentNum / 100f;
            Vector3 tempLoc = pos;
            tempLoc.x = tX;
            //tempLoc.y = tY;
            //tempLoc.z = tZ;
            pos = tempLoc;
        }
    }
    public Vector3 pos
    {
        get { return (this.transform.position); }
        set { this.transform.position = value; }
    }
}
