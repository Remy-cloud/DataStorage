using UnityEngine;
using TMPro;

public class SoldierDD : MonoBehaviour {

    public SoldierData soldierData;      

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI rankText;
    public TextMeshProUGUI speedText;

    void Start() {
        nameText.text  = "Name: "  + soldierData.soldierName;
        rankText.text  = "Rank: "  + soldierData.rank;
        speedText.text = "Speed: " + soldierData.moveSpeed;
    }
}
