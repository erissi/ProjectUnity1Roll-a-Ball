using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;
    //public Material mat;
    public int dano;
    public Material dano1;

    private Rigidbody rb;
    private int count;
    private float danoCont;

    private void Start()
    {

        rb = GetComponent<Rigidbody>();
        count = 0;
        SeTCountText();
        winText.text = "";

        Camera cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        Material rend = cam.GetComponent<Processamento>().mat;
        rend.shader = Shader.Find("2017/Processamento");
        rend.SetFloat("_Dano", 0);

    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;






            SeTCountText();
        }
    }
    void SeTCountText()
    {
        
        countText.text = "Count: " + count.ToString();


        if (count > 0) {
            danoCont += 0.083F;        
        }

        if (count >= 12)
        {
           
            winText.text = "You Win!";
        }
        
        Camera cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        Material rend = cam.GetComponent<Processamento>().mat;
        rend.shader = Shader.Find("2017/Processamento");
        rend.SetFloat("_Dano", danoCont);
    }
}