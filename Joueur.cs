using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    public float vitesse = 10f;
    public int vieMax = 10;
    public int degat = 5;

    int vieActuelle;

    // Start is called before the first frame update
    void Start()
    {
        vieActuelle = vieMax;
    }

    // Update is called once per frame
    void Update()
    {
        DeplacerJoueur();
    }

    void DeplacerJoueur()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-vitesse, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(vitesse, 0) * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TakeDamage();
    }

    void TakeDamage()
    {
        vieActuelle -= degat;
        Debug.Log("La vie du joueur est maintenant a " + vieActuelle);
        if (vieActuelle <= 0)
        {
            Destroy(gameObject);
        }
    }
}



