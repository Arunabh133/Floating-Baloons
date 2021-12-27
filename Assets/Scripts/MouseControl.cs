using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MouseControl : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 direction;
    private float moveSpeed = 100f;
    public static int score;
    public TMP_Text scoreText;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        
	scoreText.text = "Score:- "+score;
	 transform.position = new Vector3(Mathf.Clamp(transform.position.x , -7.8f, 7.8f), Mathf.Clamp(transform.position.y,-4.7f,4.7f), transform.position.z);
        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
        }
        else {
            rb.velocity = Vector2.zero;
        }

        
        
    }
}
