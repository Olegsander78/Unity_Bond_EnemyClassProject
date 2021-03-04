﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    public float fireRate = 0.3f;

    // Update is called once per frame
    void Update()
    {
        Move();    
    }
    public virtual void Move()
    {
        Vector3 temPos = pos;
        temPos.y -= speed * Time.deltaTime;
        pos = temPos;
    }
    void OnCollisionEnter(Collision coll)
    {
        GameObject other = coll.gameObject;
        switch (other.tag)
        {
            case "Hero":
                //Пока не реализовано, но здесь наносяться повреждения герою
                break;
            case "HeroLaser":
                //Уничтожить этого врага
                Destroy(this.gameObject);
                break;
        }
    }
    public Vector3 pos
    {
        get
        {
            return (this.transform.position);
        }
        set
        {
            this.transform.position = value;
        }
    }
}
