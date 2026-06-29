using UnityEngine;
using TMPro;

public class SoldierControlScript : MonoBehaviour
{
    public SoldierStorage soldierStorage;  

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI nameText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        soldierStorage.LoadData();          
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTakeDamageButton()
    {
        soldierStorage.soldierScore  += 10;
        soldierStorage.soldierHealth -= 5f;
        soldierStorage.SaveData();
        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text  = "Score: "  + soldierStorage.soldierScore;
        healthText.text = "Health: " + soldierStorage.soldierHealth;
        nameText.text   = "Name: "   + soldierStorage.soldierName;
    }
}
