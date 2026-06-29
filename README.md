# Unity Data Storage Assignment
### ScriptableObjects & PlayerPrefs

---

## 📋 Project Overview
This project demonstrates how to use **ScriptableObjects** and **PlayerPrefs** in Unity to store, retrieve, and display game data in a UI.

---

## 📁 Scripts

| Script | Purpose |
|---|---|
| `SoldierData.cs` | ScriptableObject that holds soldier data |
| `SoldierDataDisplay.cs` | Reads from ScriptableObject and displays in UI |
| `SoldierStorage.cs` | Saves and loads data using PlayerPrefs |
| `SoldierControlScript.cs` | Controls the UI and connects to SoldierStorage |

---

## 📦 Part 1 — ScriptableObject

### What it does
Stores reusable soldier data in a Unity asset file that can be edited directly in the Inspector without touching code.

### Variables
| Variable | Type | Value |
|---|---|---|
| `soldierName` | string | Sergeant |
| `rank` | int | 1 |
| `moveSpeed` | float | 5.5 |

### How to set up
1. Add `SoldierData.cs` to your Scripts folder
2. Right click in Project window → **Create → Game Data → Soldier**
3. Name it `SoldierOne`
4. Fill in the values in the Inspector
5. Attach `SoldierDataDisplay.cs` to a GameObject
6. Drag `SoldierOne` and 3 TMP texts into the Inspector slots

---

## 💾 Part 2 — PlayerPrefs

### What it does
Saves and loads soldier data so it **persists between game sessions** even after closing and reopening the game.

### Variables Stored
| Key | Type | Default |
|---|---|---|
| `Score` | int | 0 |
| `Health` | float | 100 |
| `Name` | string | Sergeant |

### How to set up
1. Attach `SoldierStorage.cs` to an empty GameObject named `SoldierStorage`
2. Attach `SoldierControlScript.cs` to an empty GameObject named `SoldierControl`
3. Drag `SoldierStorage` into the `SoldierControl` Inspector slot
4. Drag 3 TMP texts into the Inspector slots
5. Connect the **Take Damage** button to `OnTakeDamageButton` function

---

## 🎮 How to Use
1. Press **Play** in Unity
2. You will see all soldier data displayed on screen
3. Click the **Take Damage** button to:
   - Increase Score by 10
   - Decrease Health by 5
4. Stop the game and Press Play again — data is still saved ✅
