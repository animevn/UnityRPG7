using System;
using System.Collections;
using UnityEngine;

namespace Script.SceneManagement
{
    public class Fader : MonoBehaviour
    {
        [SerializeField] private float timeFade;

        private CanvasGroup canvas;
        
        private void Start()
        {
            canvas = GetComponent<CanvasGroup>();
            StartCoroutine(FadeOutIn(timeFade));
        }

        private IEnumerator FadeOutIn(float time)
        {
            yield return FadeOut(time);
            print("Fadeout OK");
            yield return FadeIn(time);
            print("Fadein OK");
        }

        private IEnumerator FadeOut(float time)
        {
            while (Math.Abs(canvas.alpha - 1) > 0)
            {
                canvas.alpha += Time.deltaTime / time;
                yield return null;
            }
        }
        
        private IEnumerator FadeIn(float time)
        {
            while (Math.Abs(canvas.alpha) > 0)
            {
                canvas.alpha -= Time.deltaTime / time;
                yield return null;
            }
        }
    }   
}
