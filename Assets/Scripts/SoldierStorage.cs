using UnityEngine;

public class SoldierStorage : MonoBehaviour {

    public int soldierScore    = 0;
    public float soldierHealth = 100f;
    public string soldierName  = "Sergeant";

    public void SaveData() {
        PlayerPrefs.SetInt("Score", soldierScore);
        PlayerPrefs.SetFloat("Health", soldierHealth);
        PlayerPrefs.SetString("Name", soldierName);
        PlayerPrefs.Save();
    }

    public void LoadData() {
        soldierScore  = PlayerPrefs.GetInt("Score", 0);
        soldierHealth = PlayerPrefs.GetFloat("Health", 100f);
        soldierName   = PlayerPrefs.GetString("Name", "Sergeant");
    }
}
