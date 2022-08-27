﻿

using UnityEngine;
using System.Collections;

public class GlobalStateManager : MonoBehaviour
{

    private int deadPlayers = 0;
private int deadPlayerNumber = -1;  
    public void PlayerDied (int playerNumber)
    {
deadPlayers++; // 1

if (deadPlayers == 1) 
{ // 2
    deadPlayerNumber = playerNumber; // 3
    Invoke("CheckPlayersDeath", .3f); // 4
}  

    }


    void CheckPlayersDeath() 
{
  // 1
  if (deadPlayers == 1) 
  { 
    // 2
    if (deadPlayerNumber == 1) 
    { 
      Debug.Log("Player 2 is the winner!");
    // 3
    } 
    else 
    { 
      Debug.Log("Player 1 is the winner!");
    }
     // 4
  } 
  else 
  { 
    Debug.Log("The game ended in a draw!");
  }
}  
}
