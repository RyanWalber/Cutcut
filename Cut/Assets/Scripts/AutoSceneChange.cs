using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoSceneChange : MonoBehaviour
{
    [SerializeField] private float tempo = 3f; // tempo da cutscene

    [SerializeField] private string proximaCena; // nome da cena

    void Start()
    {
        Invoke(nameof(TrocarCena), tempo);
    }

    void TrocarCena()
    {
        SceneManager.LoadScene(proximaCena);
    }
}
