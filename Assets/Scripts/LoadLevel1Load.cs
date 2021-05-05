﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class LoadLevel1Load : MonoBehaviour
{
    public VideoPlayer VideoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component
    void Start()
    {
        VideoPlayer.loopPointReached += EndReached;

        
    }
    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

   void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(2);
        }
    }

}