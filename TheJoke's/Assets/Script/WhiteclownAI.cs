using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WhiteclownAI : MonoBehaviour
{
    public NavMeshAgent ai;
    public Animator anim;
    public Transform player;
    Vector3 dest;

    void Update()
    {
        dest = player.position;
        ai.destination = dest;
        if (PickUpthekey.keyCollected == 0)
        {
            ai.speed = 3f;
            anim.speed = 0.3f;
        }
        if (PickUpthekey.keyCollected == 1)
        {
            ai.speed = 3.5f;
            anim.speed = 0.6f;
        }
        if (PickUpthekey.keyCollected == 2)
        {
            ai.speed = 4f;
            anim.speed = 0.9f;
        }
        if (PickUpthekey.keyCollected == 3)
        {
            ai.speed = 4.5f;
            anim.speed = 1.2f;
        }
        if (PickUpthekey.keyCollected == 1)
        {
            ai.speed = 5.0f;
            anim.speed = 1.5f;
        }
        if (PickUpthekey.keyCollected == 5)
        {
            ai.speed = 5.5f;
            anim.speed = 1.8f;
        }
        if (PickUpthekey.keyCollected == 6)
        {
            ai.speed = 6.0f;
            anim.speed = 2.1f;
        }
        if (PickUpthekey.keyCollected == 7)
        {
            ai.speed = 6.5f;
            anim.speed = 2.4f;
        }
        if (PickUpthekey.keyCollected == 8)
        {
            ai.speed = 7.0f;
            anim.speed = 2.7f;
        }
    }
}
