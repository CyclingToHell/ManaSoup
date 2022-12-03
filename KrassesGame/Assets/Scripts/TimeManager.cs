using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TimeManager : MonoBehaviour
{
    [SerializeField] private int seconds = 20;
    public float timeStart;
    bool timerActive = true;
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
            sp.color = Color.blue;
            //Musik Wechsel
            //this.GetComponent<>().audioclip = Phase1;
        }
        //Phase 2
        else if(timeStart > seconds && timeStart <= 2*seconds)
        {
            sp.color = Color.red;
            
        }
        //Phase 1 
        else if(timeStart > 2*seconds && timeStart <= 3*seconds)
        {
            sp.color = Color.blue;
            
        }
        //Phase 2
        else if(timeStart > 3*seconds && timeStart <= 4*seconds)
        {
            sp.color = Color.red;
            
        }
        //Phase 3
        else if(timeStart > 4*seconds && timeStart <= 5*seconds)
        {
            sp.color = Color.green;
            
        }
        //Phase 2
        else if(timeStart > 5*seconds && timeStart <= 6*seconds)
        {
            sp.color = Color.red;
            
        }
        //Phase 1
        else if(timeStart > 6*seconds && timeStart <= 7*seconds)
        {
            sp.color = Color.blue;
            
        }
        //Restart
        else if (timeStart > 7*seconds)
        {
            timeStart = 0;
            sp.color = Color.blue;
            print("Error");
        }

    }
}
