using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Switch : MonoBehaviour
{
    //Arrays
    public GameObject[] hintergrundArray;
    public GameObject[] schafArray;
    public GameObject[] platformArray;
    public GameObject[] oneWayPlatformArray;
    public GameObject[] fallingPlatformArray;
    public GameObject[] spikesArray;
    public GameObject[] bodenArray;
    public GameObject[] deckeArray;
    public GameObject[] fillBlockArray;
    public GameObject[] wallLeftArray;
    public GameObject[] wallRightArray;

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
            for(int i = 0; i < hintergrundArray.Length; i++)
                {
                hintergrundArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Hintergrund;
                }
            for(int i = 0; i < schafArray.Length; i++)
                {
                schafArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Schaf;
                }
            for(int i = 0; i < oneWayPlatformArray.Length; i++)
                {
                oneWayPlatformArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase1OneWayPlatform;
                }
            for(int i = 0; i < platformArray.Length; i++)
                {
                platformArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Platform;
                }
            for(int i = 0; i < fallingPlatformArray.Length; i++)
                {
                fallingPlatformArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase1FallingPlatform;
                }
            for(int i = 0; i < spikesArray.Length; i++)
                {
                spikesArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Spikes;
                }
            for(int i = 0; i < bodenArray.Length; i++)
                {
                bodenArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Boden;
                }
            for(int i = 0; i < deckeArray.Length; i++)
                {
                deckeArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase1Decke;
                }
            for(int i = 0; i < fillBlockArray.Length; i++)
                {
                fillBlockArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase1FillBlock;
                }
            for(int i = 0; i < wallLeftArray.Length; i++)
                {
                wallLeftArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase1WallLeft;
                }
            for(int i = 0; i < wallRightArray.Length; i++)
                {
                wallRightArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase1WallRight;
                }
        }
        //Phase 2
        else if(timeStart > seconds && timeStart <= 2*seconds)
        {
            for(int i = 0; i < hintergrundArray.Length; i++)
                {
                hintergrundArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Hintergrund;
                }
            for(int i = 0; i < schafArray.Length; i++)
                {
                schafArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Schaf;
                }
            for(int i = 0; i < oneWayPlatformArray.Length; i++)
                {
                oneWayPlatformArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase2OneWayPlatform;
                }
            for(int i = 0; i < platformArray.Length; i++)
                {
                platformArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Platform;
                }
            for(int i = 0; i < fallingPlatformArray.Length; i++)
                {
                fallingPlatformArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase2FallingPlatform;
                }
            for(int i = 0; i < spikesArray.Length; i++)
                {
                spikesArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Spikes;
                }
            for(int i = 0; i < bodenArray.Length; i++)
                {
                bodenArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Boden;
                }
            for(int i = 0; i < deckeArray.Length; i++)
                {
                deckeArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase2Decke;
                }
            for(int i = 0; i < fillBlockArray.Length; i++)
                {
                fillBlockArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase2FillBlock;
                }
            for(int i = 0; i < wallLeftArray.Length; i++)
                {
                wallLeftArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase2WallLeft;
                }
            for(int i = 0; i < wallRightArray.Length; i++)
                {
                wallRightArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase2WallRight;
                }
            
        }
        
        //Phase 3
        else if(timeStart > 2*seconds && timeStart <= 3*seconds)
        {
           for(int i = 0; i < hintergrundArray.Length; i++)
                {
                hintergrundArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase3Hintergrund;
                }
            for(int i = 0; i < schafArray.Length; i++)
                {
                schafArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase3Schaf;
                }
            for(int i = 0; i < oneWayPlatformArray.Length; i++)
                {
                oneWayPlatformArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase3OneWayPlatform;
                }
            for(int i = 0; i < platformArray.Length; i++)
                {
                platformArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase3Platform;
                }
            for(int i = 0; i < fallingPlatformArray.Length; i++)
                {
                fallingPlatformArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase3FallingPlatform;
                }
            for(int i = 0; i < spikesArray.Length; i++)
                {
                spikesArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase3Spikes;
                }
            for(int i = 0; i < bodenArray.Length; i++)
                {
                bodenArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase3Boden;
                }
            for(int i = 0; i < deckeArray.Length; i++)
                {
                deckeArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase3Decke;
                }
            for(int i = 0; i < fillBlockArray.Length; i++)
                {
                fillBlockArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase3FillBlock;
                }
            for(int i = 0; i < wallLeftArray.Length; i++)
                {
                wallLeftArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase3WallLeft;
                }
            for(int i = 0; i < wallRightArray.Length; i++)
                {
                wallRightArray[i].gameObject.GetComponent<SpriteRenderer>().sprite = Phase3WallRight;
                }
            
        }
        
        //Restart
        else if (timeStart > 3*seconds)
        {
            timeStart = 0;
            print("Error");
        }

    }
}
