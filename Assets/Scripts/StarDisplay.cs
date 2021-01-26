using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour {

    [SerializeField] float baseStars = 1500;
    [SerializeField] float levelDiff = 250;
    float stars;
    Text starText;
	void Start () {
        stars = baseStars - PlayerPrefsController.GetDifficulty() * levelDiff;
        starText = GetComponent<Text>();
        UpdateDisplay();
	}
	
	private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public void SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
        
    }
}
