using UnityEngine;
using System.IO;
using UnityEditor; // File sınıfını kullanabilmemiz için gerekiyor

public class CharacterManager : MonoBehaviour
{
    public Character character = new Character();

    void Awake()
    {
        LoadCharacterData();
    }



    #region Save&Loadgit 

    [ContextMenu("Save")] // inspectordaki üç noktada görünmesini sağlar
    public void Save()
    {
        string json = JsonUtility.ToJson(character, true);
        File.WriteAllText("Assets/Saves/character.json", json);
    }

    public void Load()
    {
        string json = File.ReadAllText("Assets/Saves/character.json");
        character = JsonUtility.FromJson<Character>(json);
    }

    private void LoadCharacterData()
    {
        if (File.Exists("Assets/Saves/character.json"))
        {
            Load();
        }
    }

    #endregion
}
