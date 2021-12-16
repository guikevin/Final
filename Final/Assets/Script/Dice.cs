using UnityEngine;
using UnityEngine.UI;


public class Dice : MonoBehaviour
{
   public Text Score;
   public Text  highScore;

   void Start()
   {
       highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

   }

   public void Rdice ()
   {
       int num = Random.Range(1, 100);
       Score.text = num.ToString();

       if (num > PlayerPrefs.GetInt("HighScore", 0))
       {
            PlayerPrefs.SetInt("HighScore", num);
            highScore.text = num.ToString();
       }
      
   }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        highScore.text ="0";

    }

}
