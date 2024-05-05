using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourWine : MonoBehaviour
{
    public GameObject wineStream;
    public Transform wineBottle;
    public Transform bottleTop;

    private bool isPouring = false;
    private bool pourCheck;
    public float bottleTopHeight;
    public float bottleMidHeight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bottleMidHeight = wineBottle.position.y;
        bottleTopHeight = bottleTop.position.y;

        pourCheck = (bottleMidHeight- bottleTopHeight) > 0;


        if (isPouring != pourCheck)
        {
            isPouring = pourCheck;
            wineStream.SetActive(isPouring);
        }
    }
}
