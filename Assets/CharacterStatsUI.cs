using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;

public class CharacterStatsUI : MonoBehaviour {

    public Character selectedCharacter;

    private GameObject panel;
    private Text healthValue;
    private Text speedValue;
    private Text accuracyValue;

    // Use this for initialization
    void Start () {
        panel = gameObject;
        var textComponents = GetComponentsInChildren<Text>();
        healthValue = textComponents.Where(c => c.name == "HealthValue").First();
        speedValue = textComponents.Where(c => c.name == "SpeedValue").First();
        accuracyValue = textComponents.Where(c => c.name == "AccuracyValue").First();

        var charobj = GameObject.Find("TestDude");
        selectedCharacter = charobj.GetComponent<Character>();
    }
    
    // Update is called once per frame
    void Update () {
        if (selectedCharacter == null)
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);

            healthValue.text = selectedCharacter.DisplayHealth;
            speedValue.text = selectedCharacter.DisplaySpeed;
            accuracyValue.text = selectedCharacter.DisplayAccuracy;
        }
    }
}
