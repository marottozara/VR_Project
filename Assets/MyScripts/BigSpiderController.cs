using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class BigSpiderController : MonoBehaviour
{

    static Animator anim;
    float speed;
    float rotationSpeed;
    float rotationY;
    int randomNumber;
    float translation;
    bool coroutineIsRunning;

    // Use this for initialization
    void Start()
    {
        speed = 0.01f;
        rotationSpeed = 75.0f;
        anim = GetComponent<Animator>();
        randomNumber = 0;
        translation = transform.position.z * speed;
        coroutineIsRunning = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (speed > 0.00f)
        {
            translation = transform.position.z * speed;
            rotationY = Random.Range(-20f, 20f);
        }
        else
        {
            translation = 0;
            rotationY = 0f;
        }


        // float rotation = /*Input.GetAxis("Horizontal")*/transform.rotation.y * rotationSpeed;
        translation *= Time.deltaTime;
        rotationY *= Time.deltaTime;



        transform.Translate(0, 0, -translation);
        transform.Rotate(0, rotationY, 0);
        if (translation != 0)
        {
            anim.SetBool("IsWalking", true);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }

        randomNumber = Random.Range(0, 100);

        if ((randomNumber > 98) && (coroutineIsRunning == false))
        {
            // StartCoroutine("StopSpiderMovement");
        }


    }


    IEnumerator StopSpiderMovement()
    {
        coroutineIsRunning = true;
        speed = 0.00f;
        translation = 0;
        rotationY = 0;
        yield return new WaitForSeconds(5);
        speed = 0.01f;
        coroutineIsRunning = false;
    }


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "thecaBorder" || collider.gameObject.tag == "thecaGlass")
        {
            float degrees;
            degrees = Random.Range(90f, 180f);
            // degrees *= 0.1f; //Time.deltaTime;
            transform.Rotate(0, degrees, 0);
            Debug.Log(collider.gameObject.name);
        }
    }

}
