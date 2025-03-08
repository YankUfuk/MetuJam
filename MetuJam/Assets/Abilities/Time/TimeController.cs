using System;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public static float gravity = -100f;
    public struct RecordedData
    {
        public Vector3 pos;
        public Vector3 ve3;
    }
    RecordedData[][] _recordedData;
    TimeControlled[] _timeObjects;

    private void Awake()
    {
        _timeObjects = GameObject.FindObjectsOfType<TimeControlled>();
    }

    void Update()
    {
        bool pause = Input.GetKeyDown(KeyCode.UpArrow);
        bool stepBack = Input.GetKeyDown(KeyCode.LeftArrow);
        bool stepForward = Input.GetKeyDown(KeyCode.RightArrow);
        
        if (stepBack)
        {
            
        }
        else if (pause && stepForward)
        {
            
        }
        else if (!pause && !stepBack)
        {
            for (int i = 0; i < _timeObjects.Length; i++)
            {
                
            }
        }
    }
}
