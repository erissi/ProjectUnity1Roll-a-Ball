using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AnimationCube : MonoBehaviour {

	private Material[] materiais;
	public int imgCol;
	public int imgLin;
	public int framesPorSegundo;


    private void Awake()
    {
        Debug.Log("test");
    }

    // Use this for initialization
    void Start () {
		
		materiais = GetComponent<MeshRenderer>().materials;
		materiais[0].SetTextureScale("_MainTex", new Vector2((1.0F / (float)(imgCol)),( 1.0F / (float)(imgLin))));

    }

    // Update is called once per frame
    void Update () {

		int n = imgCol * imgLin;
		float indice = Time.time * framesPorSegundo;
		indice = indice % n;
			materiais [0].SetTextureOffset ("_MainTex", new Vector2 ((float)((int)(indice % (float)imgCol)) / (float)(imgCol), 1));

	}

}
