using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public GameObject slot1;
    private Solitaire solitaire;
    // Start is called before the first frame update
    void Start()
    {
        solitaire = FindObjectOfType<Solitaire>();     
        slot1 = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        GetMouseClick();
    }

    void GetMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -10));
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit)
            {
                print("hit");
                if (hit.collider.CompareTag("Deck"))
                {
                    // clicked deck
                    Deck();
                }
                else if (hit.collider.CompareTag("Card"))
                {
                    // clicked card
                    Card(hit.collider.gameObject);
                }
                else if (hit.collider.CompareTag("Top"))
                {
                    // clicked top
                    Top();
                }
                else if (hit.collider.CompareTag("Bottom"))
                {
                    // clicked bottom
                    Bottom();
                }
            }
        }
    }


    void Deck()
    {
        print("Clicked on Deck");
        solitaire.DealFromDeck();
    }

    void Card(GameObject selected)
    {
        print("Clicked on Card");

        // if the card clicked on is facedown
            // if the card clicked on is not blocked
                //flip it over

        // if the card clicked on is in the deck pile with the trips
            // if it is not blocked
                // select it      

        // if the card is face up
            // if there is no card currently selected
                // select it

        if (slot1 == this.gameObject)
        {
            slot1 = selected;            
        }
            // if there is already a card selected (and it is not the same card)
                // if the new card is eligible to stack on the old card
                    // stack it
                // else
                    // select the new card
            // else if there is already a card slected and it is the same card
                // if the time is short enough then it is a double click
                    // if the card is eligible to fly to top then do it
    }

    void Top()
    {
        print("Clicked on Top");
    }
    
    void Bottom()
    {
        print("Clicked on Bottom");
    }
}
