using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator charAnimator;
    // Start is called before the first frame update
    void Start()
    {
        charAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame

    void AttackNow()
    {
        charAnimator.SetTrigger("goAttack");
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("RAAAAAAAAAAAH!");
            AttackNow();
        }
    }
}
