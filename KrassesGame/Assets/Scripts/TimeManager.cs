using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TimeManager : MonoBehaviour
{
    
    
    
    public float timeStart;
    bool timerActive = true;
    private SpriteRenderer sp;
   

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

        if(timeStart <= 20)
        {
            sp.color = Color.blue;
            
        }
        else if(timeStart > 20 && timeStart <= 40)
        {
            sp.color = Color.red;
            
        }
        else if(timeStart > 40 && timeStart <=60)
        {
            sp.color = Color.green;
            
        }
        else if (timeStart > 60)
        {
            timeStart = 0;
            sp.color = Color.black;
            print("Error");
        }

    }
}
