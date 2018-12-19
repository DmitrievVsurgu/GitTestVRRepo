﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour {

    private Animator anim;
    public string triggerToSet;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void SetTrigger()
    {
        anim.SetTrigger(triggerToSet);
    }

}
