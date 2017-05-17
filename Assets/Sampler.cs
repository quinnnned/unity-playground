using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sampler {

    public static T Sample<T>(T[] things) {
        int length = things.Length;
        int index = Mathf.FloorToInt(length * 100 * Random.value) % length;
        return things[index];
    }
}