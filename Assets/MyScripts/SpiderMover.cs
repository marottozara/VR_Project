using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMover : MonoBehaviour {

    static Animator anim;
    float speed;
    float rotationY;
    float translation;

    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {

        anim.SetBool("IsWalking", true);

        for(int i=0; i< 10000; i++)
        {
            speed = 0.0001f;
            translation = transform.position.z * speed;
            rotationY = Random.Range(-30f, 30f);

            translation *= Time.deltaTime;
            rotationY *= Time.deltaTime;



            transform.Translate(0, 0, translation);
            transform.Rotate(0, rotationY, 0);
        }

        anim.SetBool("IsWalking", false);

        for (int i = 0; i < 10000; i++)
        {
            speed = 0.00f;
            translation = transform.position.z * speed;
            rotationY = 0f;

            translation *= Time.deltaTime;
            rotationY *= Time.deltaTime;



            transform.Translate(0, 0, translation);
            transform.Rotate(0, rotationY, 0);
        }
    }
}
