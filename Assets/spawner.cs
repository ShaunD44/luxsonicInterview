using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{   // found this script on unity fourum
    [SerializeField] private ObjectInfo[] objects;  // fill in editor

    GameObject GetRandomObject(ObjectInfo[] objects)
    {
        float chance = Random.Range(0, 100); // random (0 to 99) %

        foreach (ObjectInfo obj in objects)
        {
            // Check if random is in chance
            if (chance < obj.chance)
            {
                return obj.obj; // returns object
            }

            // Fix chance for next item
            chance -= (int)item.chance;
        }
    }
}

[System.Serializable]
public struct ObjectInfo
{ // structure for object information
    public GameObject obj; // Prefab
    public short chance; // (0 to 99) %
}
