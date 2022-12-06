using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TimeManager : MonoBehaviour
{
    [SerializeField] private int seconds = 20;
    public float timeStart;
    bool timerActive = true;

    
    public Sprite[] eventTimmy;
    private SpriteRenderer sp;



    //Musik
    
   

    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timerActive == true)
        {
        timeStart += Time.deltaTime;
        print (timeStart);
        }

        //Phase 1 
        if(timeStart <= seconds)
        {
            GetComponent<SpriteRenderer>().sprite = eventTimmy[0];
            
        }
        //Phase 2
        else if(timeStart > seconds && timeStart <= 2*seconds)
        {
            GetComponent<SpriteRenderer>().sprite = eventTimmy[1];
            
        }
        //Phase 1 
        else if(timeStart > 2*seconds && timeStart <= 3*seconds)
        {
            GetComponent<SpriteRenderer>().sprite = eventTimmy[2];
            
        }
       
        //Restart
        else if (timeStart > 3*seconds)
        {
            timeStart = 0;
            
            print("Error");
        }

    }
}
