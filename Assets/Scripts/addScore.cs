﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore : MonoBehaviour
{
    public hasPassanger rider;
    public scoreScript score_script;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" & rider.rider == true)
        {
            Debug.Log("TriggerPassenger");
            score_script.current_score += 100;
            rider.rider = false;
        }
    }
}
