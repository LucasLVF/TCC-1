﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAbasica : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projetil;
    public float timer = 4.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0.0f)
        {
            GameObject currentball = Instantiate(projetil, transform.position + transform.forward*2, projetil.transform.rotation);
            currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            transform.Rotate(0, 45, 0);
            GameObject currentball1 = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
            currentball1.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            transform.Rotate(0, 45, 0);
            GameObject currentball2 = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
            currentball2.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            transform.Rotate(0, 45, 0);
            GameObject currentball3 = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
            currentball3.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            transform.Rotate(0, 45, 0);
            GameObject currentball4 = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
            currentball4.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            transform.Rotate(0, 45, 0);
            GameObject currentball5 = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
            currentball5.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            transform.Rotate(0, 45, 0);
            GameObject currentball6 = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
            currentball6.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            transform.Rotate(0, 45, 0);
            GameObject currentball7 = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
            currentball7.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);




            timer = 4.0f;


        }
        
    }
}
