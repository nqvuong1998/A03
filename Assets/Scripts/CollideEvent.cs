using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollideEvent : MonoBehaviour
{

    public GameObject TextGUI;
    public AudioClip coinSound;
    //public GameObject endingVideo;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Flower")) 
        {
            Debug.Log("Mario health - 10");
        }
        if (collision.gameObject.tag.Equals("Land")) 
        {
            Debug.Log("Mario is landed");
        }
        if (collision.gameObject.tag.Equals("Coin"))
        {
            Debug.Log("Coin");
            int t = int.Parse(TextGUI.GetComponent<Text>().text); 
            t++; 
            TextGUI.GetComponent<Text>().text = t.ToString(); 
            GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>().PlaySoundOneTime(coinSound); 
            Destroy(collision.gameObject); 
        }
    }
}