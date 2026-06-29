using UnityEngine;

[CreateAssetMenu(fileName = "NewSoldier", menuName = "Game Data/Soldier")]
public class SoldierData : ScriptableObject {
    public string soldierName = "Sergeant";
    public int rank = 1;
    public float moveSpeed = 5.5f;
}
