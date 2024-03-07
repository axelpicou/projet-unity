using UnityEngine;
using TMPro;

public class example_timer : MonoBehaviour
{
    public TMP_Text tex;
    public TMP_Text Minutes;
    public TMP_Text Seconds;
    public TMP_Text ElapsedTime;
    float countdown = 300;
    float time_elapsed;
    float initial_value;

    void Start()
    {
        initial_value = countdown;
    }

    void Update()
    {
        if (countdown > 0)
        {
            countdown -= Time.deltaTime;
            time_elapsed = initial_value - countdown;
        }
        float min = Mathf.FloorToInt(countdown / 60);
        float sec = Mathf.FloorToInt(countdown % 60);
        tex.text = string.Format("{0,00}:{1,00}", min, sec);

    }

}