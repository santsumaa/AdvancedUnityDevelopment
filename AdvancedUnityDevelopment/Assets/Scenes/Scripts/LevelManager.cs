using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : Singleton<LevelManager>
{
    public List<LevelData> scenes = new List<LevelData>();

    [System.Serializable]
    public class LevelData
    {
        public string LevelName;
        public SceneReference scene;
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        LoadLevel("First Level");
    }

    public void LoadLevel(string sceneToLoad)
    {
        foreach (LevelData levelData in scenes)
        {
            if (levelData.LevelName == sceneToLoad)
            {
                SceneManager.LoadScene(levelData.scene);
                return;
            }
        }

        Debug.Log("Level " + sceneToLoad + " not found!!");
    }
}
