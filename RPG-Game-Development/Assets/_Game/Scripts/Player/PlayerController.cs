using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [NonSerialized] public PlayerMoviment playerMoviment;
    [NonSerialized] public PlayerStats playerStats;

    void Awake()
    {
        playerMoviment = GetComponent<PlayerMoviment>();
        playerStats = GetComponent<PlayerStats>();
    }

}
