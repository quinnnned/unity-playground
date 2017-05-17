using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    public Text output;

    void Start() {

        string[] giantspeak = { "fee", "fi", "fo", "fum" };

        this.output.text = ""
           + Sampler.Sample(giantspeak) + "\n"
           + Sampler.Sample(giantspeak) + "\n"
           + Sampler.Sample(giantspeak) + "\n"
           + Sampler.Sample(giantspeak) + "\n"
           + Sampler.Sample(giantspeak) + "\n"
           + Sampler.Sample(giantspeak) + "\n";
    }
}