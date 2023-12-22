using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite : MonoBehaviour
{
    public GameObject placeHoldersParent;
    public List<Sprite> sprites;
    // Her oyuncunun ta�lar�n� tutan listeler
    public List<Sprite> Player1Blocks;
    public List<Sprite> Player2Blocks;
    public List<Sprite> Player3Blocks;
    public List<Sprite> Player4Blocks;

    void Start()
    {
       /* // E�er sprites listesi �nceden tan�mlanmad�ysa, tan�mla
        if (sprites == null)
            sprites = new List<Sprite>();

        // E�er sprites listesi bo�sa, GetComponentsInChildren ile dolur
        if (sprites.Count == 0)
            sprites.AddRange(GetComponentsInChildren<Sprite>());
       */
        // Her ta�tan iki tane olacak
        sprites.AddRange(sprites);

        StartGame();
    }

    public int finf()
    {
        int a = Random.Range(0, sprites.Count);
        while (sprites[a]==null)
        {
            a = Random.Range(0, sprites.Count);
           
        }
        return a;
        

    }
    public void StartGame()
    {
        // Ta�lar� kar��t�r
       // ShuffleSprites();

        // Her oyuncuya ta�lar� da��t
        
        for (int i = 0; i < 14; i++)
        {
            int a = Random.Range(0, sprites.Count);
            int b = Random.Range(0, sprites.Count);
            int c = Random.Range(0, sprites.Count);
            int d = Random.Range(0, sprites.Count);

            if (sprites[a]!=null) {
                
                Player1Blocks.Add(sprites[a]);
                sprites.RemoveAt(a);
   
            }
            else
            {
                a = finf();
                Player1Blocks.Add(sprites[a]);
                sprites.RemoveAt(a);

            }

            if (sprites[b] != null)
            {

                Player2Blocks.Add(sprites[b]);
                sprites.RemoveAt(b);

            }
            else
            {
                b = finf();
                Player2Blocks.Add(sprites[b]);
                sprites.RemoveAt(b);

            }

            if (sprites[c] != null)
            {

                Player3Blocks.Add(sprites[c]);
                sprites.RemoveAt(c);

            }
            else
            {
                c = finf();
                Player3Blocks.Add(sprites[c]);
                sprites.RemoveAt(c);

            }


            if (sprites[d] != null)
            {

                Player4Blocks.Add(sprites[d]);
                sprites.RemoveAt(d);

            }
            else
            {
                d = finf();
                Player4Blocks.Add(sprites[d]);
                sprites.RemoveAt(d);

            }
        }

        // Birinci oyuncuya fazlal�k ta� ekle
        Player1Blocks.Add(sprites[sprites.Count - 1]);
    }

    void ShuffleSprites()
    {
        for (int i = 0; i < sprites.Count; i++)
        {
            Sprite temp = sprites[i];
            int randomIndex = Random.Range(i, sprites.Count);
            sprites[i] = sprites[randomIndex];
            sprites[randomIndex] = temp;
        }
    }
}
