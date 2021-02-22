using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCtrls : MonoBehaviour
{
    Rigidbody rb;
    GameObject cam;
    bool isfirstperson = false;
    bool motionsickness = false;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        cam = GameObject.Find("Main Camera");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            isfirstperson = true;
        }
        if (Input.GetKey(KeyCode.M))
        {
            motionsickness = true;
        }
        if (isfirstperson)
        {
            cam.transform.position = gameObject.transform.position;
            if (!motionsickness)
            {
                cam.transform.rotation = gameObject.transform.rotation;
            }
        }
        if (gameObject.transform.position.y <= -1)
        {
            SceneManager.LoadScene("GameOver");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector3(0, 0, -90));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = rb.velocity * 0;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector3(-40, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector3(40, 0, 0));
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Dog Crap" || collision.gameObject.name == "Dog Crap (1)" || collision.gameObject.name == "Dog Crap (2)" || collision.gameObject.name == "Dog Crap (3)" || collision.gameObject.name == "Dog Crap (4)" || collision.gameObject.name == "Dog Crap (5)" || collision.gameObject.name == "Dog Crap (6)" || collision.gameObject.name == "Dog Crap (7)" || collision.gameObject.name == "Dog Crap (8)" || collision.gameObject.name == "Dog Crap (9)" || collision.gameObject.name == "Dog Crap (10)")
        {
            SceneManager.LoadScene("GameOver");
        }
        if (collision.gameObject.name == "End")
        {
            SceneManager.LoadScene("GameWin");
        }
    }
}
