using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPCController : MonoBehaviour
{
    private float timeToChangeDirection;
    static Animator anim;
    float speed;
    float rotationSpeed;
    public float rotationY;
    float translation;


    // Use this for initialization
    public void Start()
    {
        ChangeDirection();
        speed = 0.01f;
    }

    // Update is called once per frame
    public void Update()
    {
        timeToChangeDirection -= Time.deltaTime;

        if (timeToChangeDirection <= 0)
        {
            ChangeDirection();
        }

       
    }



    private void ChangeDirection()
    {
        float translation = /*Input.GetAxis("Vertical")*/transform.position.z * speed;
        rotationY = Random.Range(-360f, 360f);
        // float rotation = /*Input.GetAxis("Horizontal")*/transform.rotation.y * rotationSpeed;
        translation *= Time.deltaTime;
        rotationY *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotationY, 0);
        if (translation != 0)
        {
            anim.SetBool("IsWalking", true);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
    }
}