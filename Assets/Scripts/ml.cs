﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ml : MonoBehaviour {

    public static int messageCount;
    // Use this for initialization
    void Start()
    {
        messageCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            messageCount++;
            Debug.Log(messageCount);
        }
        if (messageCount > 2)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
