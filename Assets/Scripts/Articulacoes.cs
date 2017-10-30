using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Articulacoes : MonoBehaviour {

    public Rigidbody rb;

    public GameObject plane;

	public GameObject Horse;

    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject cube5;
    public GameObject cube6;
    public GameObject cube7;
    public GameObject cube8;
    public GameObject cube9;
    public GameObject cube10;
    public GameObject cube11;
    public GameObject cube12;
    public GameObject cube13;

    public GameObject cylinder1;
    public GameObject cylinder2;
    public GameObject cylinder3;
    public GameObject cylinder4;
    public GameObject cylinder5;

    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    public GameObject sphere4;
    public GameObject bola;

    public GameObject capsule;

    private Joint juntaFixa;
    private Joint juntaDobradica;
    private Joint juntaMola;
    private Joint juntaCarater;

    // Use this for initialization
    void Start () {
        //Encontra os objetos e coloca eles nas variaveis
        plane = GameObject.Find("Plane");
		Horse = GameObject.Find("Horse");

        cube1 = GameObject.Find("Cube1");
        cube2 = GameObject.Find("Cube2");
        cube3 = GameObject.Find("Cube3");
        cube4 = GameObject.Find("Cube4");
        cube5 = GameObject.Find("Cube5");
        cube6 = GameObject.Find("Cube6");
        cube7 = GameObject.Find("Cube7");
        cube8 = GameObject.Find("Cube8");
        cube9 = GameObject.Find("Cube9");
        cube10 = GameObject.Find("Cube10");
        cube11 = GameObject.Find("Cube11");
        cube12 = GameObject.Find("Cube12");
        cube13 = GameObject.Find("Cube13");

        cylinder1 = GameObject.Find("Cylinder1");
        cylinder2 = GameObject.Find("Cylinder2");
        cylinder3 = GameObject.Find("Cylinder3");
        cylinder4 = GameObject.Find("Cylinder4");
        cylinder5 = GameObject.Find("Cylinder5");

        sphere1 = GameObject.Find("Sphere1");
        sphere2 = GameObject.Find("Sphere2");
        sphere3 = GameObject.Find("Sphere3");
        sphere4 = GameObject.Find("Sphere4");
        bola = GameObject.Find("Bola");

        capsule = GameObject.Find("Capsule");



        //junta o cubo 1 (central) ao cubo 2 (de baixo)


        /////////
        juntaFixa = cube1.AddComponent<FixedJoint>();
        juntaFixa.connectedBody = sphere4.GetComponent<Rigidbody>();
        /////////
        //add dobradiça no cubo 3 (de cima)
        juntaDobradica = cylinder1.AddComponent<HingeJoint>();
        //junta o cubo 2 (de cima) ao cubo 1 (central)
        juntaFixa = cube1.AddComponent<FixedJoint>();
        juntaFixa.connectedBody = cylinder1.GetComponent<Rigidbody>();
          
        

        

        juntaFixa = cylinder3.AddComponent<FixedJoint>();
        juntaFixa.connectedBody = cube2.GetComponent<Rigidbody>();

        juntaCarater = cube6.AddComponent<CharacterJoint>();
        juntaCarater.connectedBody = cylinder3.GetComponent<Rigidbody>();

        //juntaDobradica = cylinder3.AddComponent<HingeJoint>();
        //juntaMola = sphere2.AddComponent<SpringJoint>();
        //SpringJoint

        //////////////////////////////////////////////////////////
        //Perna Direita


        /////
        juntaFixa = cube3.AddComponent<FixedJoint>();
        juntaFixa.connectedBody = sphere3.GetComponent<Rigidbody>();
        /////
        juntaDobradica = cylinder2.AddComponent<HingeJoint>();
        juntaFixa = cube3.AddComponent<FixedJoint>();
        juntaFixa.connectedBody = cylinder2.GetComponent<Rigidbody>();



        juntaFixa = cylinder4.AddComponent<FixedJoint>();
        juntaFixa.connectedBody = cube4.GetComponent<Rigidbody>();

        juntaCarater = cube5.AddComponent<CharacterJoint>();
        juntaCarater.connectedBody = cylinder4.GetComponent<Rigidbody>();




        //////////////////////////////////////////////////////////
        juntaMola = cylinder5.AddComponent<SpringJoint>();
        juntaMola.connectedBody = capsule.GetComponent<Rigidbody>();

        //////////////////////////////////////////////////////////

        juntaCarater = cylinder2.AddComponent<CharacterJoint>();
        juntaCarater.connectedBody = cube9.GetComponent<Rigidbody>();

        juntaCarater = cylinder1.AddComponent<CharacterJoint>();
        juntaCarater.connectedBody = cube9.GetComponent<Rigidbody>();

        //juntaDobradica = cylinder2.AddComponent<HingeJoint>();
        //juntaDobradica.connectedBody = cube9.GetComponent<Rigidbody>();

        //juntaDobradica = cylinder1.AddComponent<HingeJoint>();
        //juntaDobradica.connectedBody = cube9.GetComponent<Rigidbody>();

        //////////////////////////////////////////////////////////

        juntaFixa = cylinder5.AddComponent<FixedJoint>();
        juntaFixa.connectedBody = cube9.GetComponent<Rigidbody>();

        juntaCarater = sphere2.AddComponent<CharacterJoint>();
        juntaCarater.connectedBody = cube8.GetComponent<Rigidbody>();

        juntaFixa = sphere2.AddComponent<FixedJoint>();
        juntaFixa.connectedBody = cube9.GetComponent<Rigidbody>();




        juntaCarater = sphere1.AddComponent<CharacterJoint>();
        juntaCarater.connectedBody = cube7.GetComponent<Rigidbody>();

        juntaFixa = sphere1.AddComponent<FixedJoint>();
        juntaFixa.connectedBody = cube9.GetComponent<Rigidbody>();



        juntaCarater = sphere3.AddComponent<CharacterJoint>();
        juntaCarater.connectedBody = cube4.GetComponent<Rigidbody>();

        juntaCarater = sphere4.AddComponent<CharacterJoint>();
        juntaCarater.connectedBody = cube2.GetComponent<Rigidbody>();


        juntaFixa = cube8.AddComponent<FixedJoint>();
        juntaFixa.connectedBody = cube10.GetComponent<Rigidbody>();
        juntaFixa = cube10.AddComponent<FixedJoint>();
        juntaFixa.connectedBody = cube13.GetComponent<Rigidbody>();

        juntaFixa = cube7.AddComponent<FixedJoint>();
        juntaFixa.connectedBody = cube11.GetComponent<Rigidbody>();
        juntaFixa = cube11.AddComponent<FixedJoint>();
        juntaFixa.connectedBody = cube12.GetComponent<Rigidbody>();

        Console.WriteLine("Hello World!");

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.frameCount >= 5 && Time.frameCount <= 60)
        {
            rb = cube5.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * -20);
        }
        if (Time.frameCount >= 61 && Time.frameCount <= 120)
        {
            rb = cube5.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 30);
        }

        if (Time.frameCount >= 180)
        {
           //rb = bola.GetComponent<Rigidbody>();
            // public Rigidbody rb;
            //rb.AddForce(transform.forward * 20);

            /*
            bola.transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
            bola.transform.Translate(new Vector3(100, 0, 0) * Time.deltaTime);
            bola.transform.Translate(new Vector3(500, 0, 0) * Time.deltaTime);
            //capsule.transform.Translate(new Vector3(0, 10, 0) * Time.deltaTime);
            //cube9.transform.Rotate(new Vector3(100, 0, 0) * Time.deltaTime);
            //cube9.transform.Rotate(new Vector3(-100, 0, 0) * Time.deltaTime);
            cube5.transform.Translate(new Vector3(0, 0, 15) * Time.deltaTime);*/
        }
        if (Time.frameCount >= 300 && Time.frameCount <= 600)
        {
            rb = cube8.GetComponent<Rigidbody>();
            rb.AddForce(transform.up * 100);
            rb.AddForce(transform.forward * 100);
            rb = cube7.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 100);
            rb.AddForce(transform.up * 100);
            //cube9.transform.Translate(new Vector3(20000, 900, 1500) * Time.deltaTime);
        }
    }
}