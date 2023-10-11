using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
    public int score;
    public float rotateScale;
    public float jumpspeed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Mouse0))
      {
            rb.velocity = Vector2.up * jumpspeed;
      }

        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y * rotateScale);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        die();
    }
    void die()
    {
        var currentscene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentscene);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        score++;
    }
}
