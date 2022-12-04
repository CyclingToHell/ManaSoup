using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Timer
    [SerializeField] private int seconds = 20;
    public float timeStart;
    bool timerActive = true;
    private SpriteRenderer sp;
    

    public float speed;
    public GameObject target;
    public float distance;
    public Vector2 origin;
    private bool movingRight = true;
    public Transform groundDetection;


    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        origin = new Vector2(transform.position.x,transform.position.y);
        
    }
    void Update() 
    {
        if(timerActive == true)
        {
            print(origin);
        timeStart += Time.deltaTime;
        }

        //Phase 1 
        
        if(timeStart <= seconds)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(groundInfo.collider == false)
        {
            if(movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
            print("phase1");
        }
        }
        //Phase 2
        else if(timeStart > seconds && timeStart <= 2*seconds)
        {   
            
            this.transform.position = Vector2.MoveTowards(this.transform.position, target.transform.position, speed * Time.deltaTime);
            print("phase2");
        }
        //Phase 3
        else if(timeStart > 2*seconds && timeStart <= 3*seconds)
        {   
            print("phase3");
            this.transform.position = Vector2.MoveTowards(this.transform.position, target.transform.position, 2 * speed * Time.deltaTime);
        }
        //Restart
        else if (timeStart > 3*seconds)
        {
            timeStart = 0;
            
            print("Error");
            transform.position = origin;
        }
    }
}







    
   

   


