using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Switch : MonoBehaviour
{

    //GameObjects
    [SerializeField] private GameObject hintergrund;
    [SerializeField] private GameObject schaf;
    [SerializeField] private GameObject platform;
    [SerializeField] private GameObject oneWayPlatform;
    [SerializeField] private GameObject fallingPlatform;
    [SerializeField] private GameObject spikes;
    [SerializeField] private GameObject boden;
    [SerializeField] private GameObject decke;
    [SerializeField] private GameObject fillBlock;
    [SerializeField] private GameObject wallLeft;
    [SerializeField] private GameObject wallRight;

    


    //Timer
    [SerializeField] private int seconds = 20;
    public float timeStart;
    bool timerActive = true;
    private SpriteRenderer sp;

    //Phase1
    [SerializeField] private Sprite Phase1Hintergrund;
    [SerializeField] private Sprite Phase1Schaf;
    [SerializeField] private Sprite Phase1Platform;
    [SerializeField] private Sprite Phase1OneWayPlatform;
    [SerializeField] private Sprite Phase1FallingPlatform;
    [SerializeField] private Sprite Phase1Spikes;
    [SerializeField] private Sprite Phase1Boden;
    [SerializeField] private Sprite Phase1Decke;
    [SerializeField] private Sprite Phase1FillBlock;
    [SerializeField] private Sprite Phase1WallLeft;
    [SerializeField] private Sprite Phase1WallRight;

    //Phase2
    [SerializeField] private Sprite Phase2Hintergrund;
    [SerializeField] private Sprite Phase2Schaf;
    [SerializeField] private Sprite Phase2Platform;
    [SerializeField] private Sprite Phase2OneWayPlatform;
    [SerializeField] private Sprite Phase2FallingPlatform;
    [SerializeField] private Sprite Phase2Spikes;
    [SerializeField] private Sprite Phase2Boden;
    [SerializeField] private Sprite Phase2Decke;
    [SerializeField] private Sprite Phase2FillBlock;
    [SerializeField] private Sprite Phase2WallLeft;
    [SerializeField] private Sprite Phase2WallRight;

    //Phase3
    [SerializeField] private Sprite Phase3Hintergrund;
    [SerializeField] private Sprite Phase3Schaf;
    [SerializeField] private Sprite Phase3Platform;
    [SerializeField] private Sprite Phase3OneWayPlatform;
    [SerializeField] private Sprite Phase3FallingPlatform;
    [SerializeField] private Sprite Phase3Spikes;
    [SerializeField] private Sprite Phase3Boden;
    [SerializeField] private Sprite Phase3Decke;
    [SerializeField] private Sprite Phase3FillBlock;
    [SerializeField] private Sprite Phase3WallLeft;
    [SerializeField] private Sprite Phase3WallRight;
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
        
        }

        //Phase 1 
        if(timeStart <= seconds)
        {
            hintergrund.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Hintergrund;
            schaf.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Schaf;
            platform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Platform;
            oneWayPlatform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1OneWayPlatform;
            fallingPlatform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1FallingPlatform;
            spikes.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Spikes;
            boden.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Boden;
            decke.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Decke;
            fillBlock.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1FillBlock;
            wallLeft.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1WallLeft;
            wallRight.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1WallRight;

            
        }
        //Phase 2
        else if(timeStart > seconds && timeStart <= 2*seconds)
        {
            hintergrund.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Hintergrund;
            schaf.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Schaf;
            platform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Platform;
            oneWayPlatform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2OneWayPlatform;
            fallingPlatform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2FallingPlatform;
            spikes.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Spikes;
            boden.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Boden;
            decke.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Decke;
            fillBlock.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2FillBlock;
            wallLeft.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2WallLeft;
            wallRight.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2WallRight;
            
        }
        //Phase 1 
        else if(timeStart > 2*seconds && timeStart <= 3*seconds)
        {
            hintergrund.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Hintergrund;
            schaf.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Schaf;
            platform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Platform;
            oneWayPlatform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1OneWayPlatform;
            fallingPlatform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1FallingPlatform;
            spikes.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Spikes;
            boden.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Boden;
            decke.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Decke;
            fillBlock.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1FillBlock;
            wallLeft.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1WallLeft;
            wallRight.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1WallRight;
            
        }
        //Phase 2
        else if(timeStart > 3*seconds && timeStart <= 4*seconds)
        {
            hintergrund.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Hintergrund;
            schaf.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Schaf;
            platform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Platform;
            oneWayPlatform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2OneWayPlatform;
            fallingPlatform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2FallingPlatform;
            spikes.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Spikes;
            boden.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Boden;
            decke.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Decke;
            fillBlock.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2FillBlock;
            wallLeft.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2WallLeft;
            wallRight.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2WallRight;
            
        }
        //Phase 3
        else if(timeStart > 4*seconds && timeStart <= 5*seconds)
        {
            hintergrund.gameObject.GetComponent<SpriteRenderer>().sprite = Phase3Hintergrund;
            schaf.gameObject.GetComponent<SpriteRenderer>().sprite = Phase3Schaf;
            platform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase3Platform;
            oneWayPlatform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase3OneWayPlatform;
            fallingPlatform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase3FallingPlatform;
            spikes.gameObject.GetComponent<SpriteRenderer>().sprite = Phase3Spikes;
            boden.gameObject.GetComponent<SpriteRenderer>().sprite = Phase3Boden;
            decke.gameObject.GetComponent<SpriteRenderer>().sprite = Phase3Decke;
            fillBlock.gameObject.GetComponent<SpriteRenderer>().sprite = Phase3FillBlock;
            wallLeft.gameObject.GetComponent<SpriteRenderer>().sprite = Phase3WallLeft;
            wallRight.gameObject.GetComponent<SpriteRenderer>().sprite = Phase3WallRight;
            
        }
        //Phase 2
        else if(timeStart > 5*seconds && timeStart <= 6*seconds)
        {
            hintergrund.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Hintergrund;
            schaf.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Schaf;
            platform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Platform;
            oneWayPlatform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2OneWayPlatform;
            fallingPlatform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2FallingPlatform;
            spikes.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Spikes;
            boden.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Boden;
            decke.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Decke;
            fillBlock.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2FillBlock;
            wallLeft.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2WallLeft;
            wallRight.gameObject.GetComponent<SpriteRenderer>().sprite = Phase2WallRight;
            
        }
        //Phase 1
        else if(timeStart > 6*seconds && timeStart <= 7*seconds)
        {
            hintergrund.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Hintergrund;
            schaf.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Schaf;
            platform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Platform;
            oneWayPlatform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1OneWayPlatform;
            fallingPlatform.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1FallingPlatform;
            spikes.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Spikes;
            boden.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Boden;
            decke.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Decke;
            fillBlock.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1FillBlock;
            wallLeft.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1WallLeft;
            wallRight.gameObject.GetComponent<SpriteRenderer>().sprite = Phase1WallRight;
            
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
