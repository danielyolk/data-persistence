using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string Username;
    public int Highscore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    public class DataToSave
    {
        public string username;
        public int highscore;

    }

    public void SaveData()
    {
        DataToSave data = new DataToSave();
        data.highscore = DataManager.Instance.Highscore;
        data.username = DataManager.Instance.Username;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            DataToSave data = JsonUtility.FromJson<DataToSave>(json);
            DataManager.Instance.Username = data.username;
            DataManager.Instance.Highscore = data.highscore;
        }
    }
}
