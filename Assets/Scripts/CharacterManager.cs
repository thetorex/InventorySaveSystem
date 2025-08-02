using UnityEngine;
using System.IO;
using UnityEditor;
using System.Collections.Generic; // File sınıfını kullanabilmemiz için gerekiyor

public class CharacterManager : MonoBehaviour
{
    public Character character = new Character();
    public Enemies enemies = new Enemies();

    void Awake()
    {
        LoadCharacterData();
        LoadEnemyData();
    }



    #region Save&Load

    #region General

    [ContextMenu("Save All")]
    public void SaveAll()
    {
        SaveCharacter();
        SaveEnemy();
    }

    [ContextMenu("Delete")]
    public void DeleteAll()
    {
        if (File.Exists("Assets/Saves/enemy.json")) 
            File.Delete("Assets/Saves/enemy.json");
        if (File.Exists("Assets/Saves/character.json"))
            File.Delete("Assets/Saves/character.json");
    }

    #endregion

    #region Character

    [ContextMenu("Save Character")] // inspectordaki üç noktada görünmesini sağlar
    public void SaveCharacter()
    {
        string json = JsonUtility.ToJson(character, true);
        File.WriteAllText("Assets/Saves/character.json", json);
    }

    public void LoadCharacter()
    {
        string json = File.ReadAllText("Assets/Saves/character.json");
        character = JsonUtility.FromJson<Character>(json);
    }

    private void LoadCharacterData()
    {
        if (File.Exists("Assets/Saves/character.json"))
        {
            LoadCharacter();
        }
    }

    #endregion

    #region Enemy

    [ContextMenu("Save Enemy")]
    public void SaveEnemy()
    {
        string json = JsonUtility.ToJson(enemies, true);
        File.WriteAllText("Assets/Saves/enemy.json", json);
    }

    public void LoadEnemy()
    {
        string json = File.ReadAllText("Assets/Saves/enemy.json");
        enemies = JsonUtility.FromJson<Enemies>(json);
    }

    private void LoadEnemyData()
    {
        if (File.Exists("Assets/Saves/enemy.json"))
        {
            LoadEnemy();
        }
    }

    #endregion

    #endregion
}
