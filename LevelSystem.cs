using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LevelSystem : MonoBehaviour,ISaveable
{
    [SerializeField] private int level = 1;
    [SerializeField] private int exp = 1;
    public object CaptureState()
    {
        return new SaveData
        {
            level = level,
            exp = exp,
        };
    }

    public void RestoreState(object state)
    {
        var saveData = (SaveData)state;
        level = saveData.level;
        exp = saveData.exp;
    }

    [Serializable]
    private struct SaveData
    {
        public int level;
        public int exp;
    }

}
