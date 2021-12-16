using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  // Singleton for GameManager
  private static GameManager _instance;
  public static GameManager Instance { get { return _instance; } }
  void Awake()
  {
    if (_instance != null && _instance != this)
    {
      Destroy(this.gameObject);
    } else {
      _instance = this;
    }
  }

  public static float Timer;
  public static int IdGame;
  public static int Score;
  public static int Hint;

  // Student
  public static int IdStudent;
  public static int IdAssignment;
  public static int NiveauPermission;
  public static bool IsDone;
  public static int Checkpoint;

  // Guest
  public static bool IsGuest;
}
