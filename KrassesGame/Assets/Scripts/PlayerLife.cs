using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    private BoxCollider2D box;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Gegner")
        {
            Die();
        }
        
        if(collision.gameObject.tag == "Ende")
        {
            print("Ende");

        }
        

    }
    

   

    private void Die() 
    {
        rb.bodyType = RigidbodyType2D.Static;
        //anim.SetTrigger("death");
    }


    //IEnumerator Ziel()
    //{
        //rb.bodyType = RigidbodyType2D.Static;
        //anim.SetTrigger("Ziel");
       // yield return new WaitForSeconds(3f);
       // SceneManager.LoadScene(SceneManager.LoadScene("xxx"));

    //}

   private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
