using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// simple manager for tracking score
public class ScoreManager : MonoBehaviour
{
    // only one score manager
    private static ScoreManager s_instance;
    // vent called whenever score is increased
    [SerializeField] private UnityEvent<int> GoldUpdated;

    // assing self as manager
    public void Awake()
    {
        s_instance = this;
        s_instance.GoldUpdated.Invoke(s_instance._gold);
    }

    // amount of gold
    public int _gold;

    // adds gold
    public static void AddGold(int value)
    {
        s_instance._gold += value;
        s_instance.GoldUpdated.Invoke(s_instance._gold);
    }
}
