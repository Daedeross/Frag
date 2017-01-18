using UnityEngine;
using System.Collections;

public class Character : EntityBase {

    public int HealthBase;

    public int HealthBonus;

    public int Health { get { return HealthBase + HealthBonus; } }

    public string DisplayHealth { get { return string.Format(HealthBonus > 0 ? "{0} ({1})" : "{0}", HealthBase, Health); } }

    public int SpeedBase;

    public int SpeedBonus;

    public int Speed { get { return SpeedBase + SpeedBonus; } }

    public string DisplaySpeed { get { return string.Format(SpeedBonus > 0 ? "{0} ({1})" : "{0}", SpeedBase, Speed); } }

    public int AccuracyBase;

    public int AccuracyBonus;

    public int Accuracy { get { return AccuracyBase + AccuracyBonus; } }

    public string DisplayAccuracy { get { return string.Format(AccuracyBonus > 0 ? "{0} ({1})" : "{0}", AccuracyBase, Accuracy); } }

    // Use this for initialization
    void Start () {
        HealthBase = 2;
        SpeedBase = 2;
        AccuracyBase = 3;
    }

    float t = 0;

    // Update is called once per frame
    void Update () {
        HealthBonus = (int)Time.realtimeSinceStartup / 10;
    }
}
