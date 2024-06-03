using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VerifUI();
    }

    [SerializeField] Image Soul1;
    [SerializeField] Image Soul2;
    [SerializeField] Image Soul3;
    [SerializeField] Image Soul4;
    [SerializeField] Image Soul5;

    [SerializeField] Image Power1;
    [SerializeField] Image Power2;
    [SerializeField] Image Power3;
    [SerializeField] Image Power4;
    [SerializeField] Image Power5;

    [SerializeField] Image Speed1;
    [SerializeField] Image Speed2;
    [SerializeField] Image Speed3;
    [SerializeField] Image Speed4;
    [SerializeField] Image Speed5;

    [SerializeField] Image Jump1;
    [SerializeField] Image Jump2;
    [SerializeField] Image Jump3;
    [SerializeField] Image Jump4;
    [SerializeField] Image Jump5;

    public void VerifUI() 
    
    {
        if (ShopControlScript.MaxUpgrade1 == 0)
        {
            Power1.gameObject.SetActive(false);
            Power2.gameObject.SetActive(false);
            Power3.gameObject.SetActive(false);
            Power4.gameObject.SetActive(false);
        }
        if (ShopControlScript.MaxUpgrade1 == 1)
        {
            Power1.gameObject.SetActive(true);
        }

        if (ShopControlScript.MaxUpgrade1 == 2)
        {
            Power1.gameObject.SetActive(true);
            Power2.gameObject.SetActive(true);

        }

        if (ShopControlScript.MaxUpgrade1 == 3)
        {
            Power1.gameObject.SetActive(true);
            Power2.gameObject.SetActive(true);
            Power3.gameObject.SetActive(true);

        }

        if (ShopControlScript.MaxUpgrade1 == 4)
        {
            Power1.gameObject.SetActive(true);
            Power2.gameObject.SetActive(true);
            Power3.gameObject.SetActive(true);
            Power4.gameObject.SetActive(true);

        }



        if (ShopControlScript.MaxUpgrade2 == 0)
        {
            Speed1.gameObject.SetActive(false);
            Speed2.gameObject.SetActive(false);
            Speed3.gameObject.SetActive(false);
            Speed4.gameObject.SetActive(false);
        }
        if (ShopControlScript.MaxUpgrade2 == 1)
        {
            Speed1.gameObject.SetActive(true);
        }

        if (ShopControlScript.MaxUpgrade2 == 2)
        {
            Speed1.gameObject.SetActive(true);
            Speed2.gameObject.SetActive(true);

        }


        if (ShopControlScript.MaxUpgrade2 == 3)

        {
            Speed1.gameObject.SetActive(true);
            Speed2.gameObject.SetActive(true);
            Speed3.gameObject.SetActive(true);

        }

        if (ShopControlScript.MaxUpgrade2 == 4)
        {
            Speed1.gameObject.SetActive(true);
            Speed2.gameObject.SetActive(true);
            Speed3.gameObject.SetActive(true);
            Speed4.gameObject.SetActive(true);

        }




        if (ShopControlScript.MaxUpgrade3 == 0)
        {
            Soul1.gameObject.SetActive(false);
            Soul2.gameObject.SetActive(false);
            Soul3.gameObject.SetActive(false);
            Soul4.gameObject.SetActive(false);
        }
        if (ShopControlScript.MaxUpgrade3 == 1)
        {
            Soul1.gameObject.SetActive(true);
        }

        if (ShopControlScript.MaxUpgrade3 == 2)
        {
            Soul1.gameObject.SetActive(true);
            Soul2.gameObject.SetActive(true);

        }

        if (ShopControlScript.MaxUpgrade3 == 3)
        {
            Soul1.gameObject.SetActive(true);
            Soul2.gameObject.SetActive(true);
            Soul3.gameObject.SetActive(true);

        }

        if (ShopControlScript.MaxUpgrade3 == 4)
        {
            Soul1.gameObject.SetActive(true);
            Soul2.gameObject.SetActive(true);
            Soul3.gameObject.SetActive(true);
            Soul4.gameObject.SetActive(true);

        }



        if (ShopControlScript.MaxUpgrade4 == 0)
        {
            Jump1.gameObject.SetActive(false);
            Jump2.gameObject.SetActive(false);
            Jump3.gameObject.SetActive(false);
            Jump4.gameObject.SetActive(false);
        }

        if (ShopControlScript.MaxUpgrade4 == 1)
        {
            Jump1.gameObject.SetActive(true);
        }

        if (ShopControlScript.MaxUpgrade4 == 2)
        {
            Jump1.gameObject.SetActive(true);
            Jump2.gameObject.SetActive(true);

        }

        if (ShopControlScript.MaxUpgrade4 == 3)
        {
            Jump1.gameObject.SetActive(true);
            Jump2.gameObject.SetActive(true);
            Jump3.gameObject.SetActive(true);

        }
         
        if (ShopControlScript.MaxUpgrade4 == 4)
        {
            Jump1.gameObject.SetActive(true);
            Jump2.gameObject.SetActive(true);
            Jump3.gameObject.SetActive(true);
            Jump4.gameObject.SetActive(true);

        }

    }
        


}
