using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderController : MonoBehaviour {

    static Animator anim;
    float speed = 0.01f;
    float rotationSpeed = 75.0f;
    public float rotationY;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        float translation = /*Input.GetAxis("Vertical")*/transform.position.z * speed;
        rotationY = Random.Range(-360f, 360f);
       // float rotation = /*Input.GetAxis("Horizontal")*/transform.rotation.y * rotationSpeed;
        translation *= Time.deltaTime;
        rotationY *=  Time.deltaTime ;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotationY, 0);
        if(translation != 0)
        {
            anim.SetBool("IsWalking", true);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
    }
}
