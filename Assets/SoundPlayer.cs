﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{

    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnCollisionEnter2D(Collision2D other)
    {
        // ブロックと衝突したら音を鳴らす
        if (other.gameObject.tag == "BlockTag")
        {
            audioSource.Play();
        }
    }

}
