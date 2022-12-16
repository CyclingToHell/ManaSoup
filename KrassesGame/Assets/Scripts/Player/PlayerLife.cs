using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{


    //Leben
    public int health;
    public int healthMax;

    [SerializeField] private GameObject healthbar;
    public Sprite[] life;

    [SerializeField] private AudioSource deathScream;

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

    void Update() 
    {
        if( health == healthMax)
        {   
            healthbar.GetComponent<SpriteRenderer>().sprite = life[0]; 
        }
        else if (health == healthMax - 1 )
        {   
            healthbar.GetComponent<SpriteRenderer>().sprite = life[1];
        }
        else if (health == healthMax - 2 )
        {   
            healthbar.GetComponent<SpriteRenderer>().sprite = life[2];
        }
        else
        {
            RestartMenu();
        }

    }
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Gegner")
        {
            health = health - 1;
            deathScream.Play();

        }
        
        if(collision.gameObject.tag == "Ende")
        {
            Victory();

        }
        if(collision.gameObject.tag == "Spike")
        {
            RestartLevel();
        }
        

    }
    

   

    private void Die() 
    {
        rb.bodyType = RigidbodyType2D.Static;
        //anim.SetTrigger("death");

        
    }
     public void RestartMenu()
    {
        SceneManager.LoadScene("DeathScreen");
    }

   private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Victory()
    {
        SceneManager.LoadScene("VictoryScreen");
    }

    
   
}
