using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombTile : AbstractTile
{
    public Sprite[] sprites;

    private int turnsLeftToKaboom = 5;//8

    public override void Start()
    {
       spriteRenderer.sprite = sprites[turnsLeftToKaboom];
    }

    public bool IsKaboom()
    {
        return turnsLeftToKaboom < 1;//1
    }

    public void CountDown()
    {
        --turnsLeftToKaboom;
        if (turnsLeftToKaboom < 0)
        {
            //Destroy(this.gameObject);
             return;
          // benim yazdığım  SceneManager.LoadScene("GameOver");
        }
        spriteRenderer.sprite = sprites[turnsLeftToKaboom];
    }

    public override void Hexplode()
    {
        score.Increment(5);
        Destroy(gameObject);
    }
}