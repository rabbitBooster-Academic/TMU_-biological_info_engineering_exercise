using UnityEngine;
using UnityEngine.UI;
using Zenject;
using UniRx;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class GameOverView : MonoBehaviour
{
    IGameOverSpawnPresenter gameOverSpawnPresenter;
    Image gameOverImage;
    [Inject]
    public void Init(IGameOverSpawnPresenter gameOverSpawnPresenter)
    {
        this.gameOverSpawnPresenter = gameOverSpawnPresenter;
    }
    void Start()
    {
        Time.timeScale =1f;
        gameOverImage = GetComponent<Image>();
        gameOverSpawnPresenter.GameOverAsObserable.Subscribe(_ =>
        {
            Time.timeScale = 0f;
            StartCoroutine(Fade());
        });
    }
    IEnumerator Fade()
    {
        float f = 0f;
        while (f < 1f)
        {
            gameOverImage.color = new Color(gameOverImage.color.r, gameOverImage.color.g, gameOverImage.color.b, f);
            yield return null;
            f += 0.02f;
        }

        GameObject child = new GameObject();
        child.transform.parent = this.transform;

        var image = child.AddComponent<Image>();
        image.rectTransform.anchoredPosition = Vector3.zero;
        image.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);
        image.color = Color.clear;
        yield return new WaitForSecondsRealtime(3f);
        f = 0f;
        while (f < 1f)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, f);
            yield return null;
            f += 0.02f;
        }
        SceneManager.LoadScene(gameObject.scene.name);

    }
}
