using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    public int ShopPage;
    public GameObject[] ShopPages;
    public PlayerAbilities playerAbilities;
    public int PagesUnlocked;

    [Header("UI")]
    public Text levelName;    


    public Image Subpath1Image;
    public Image Subpath2Image;
    public Text Subpath1Text;
    public Text Subpath2Text;

    public Image UpgradeImage;
    public Text UpgradeText;

    public Text Page3ShopName;
    public Text Page4ShopName;

    [Header("Shield")]
   
    public Sprite[] Page3Shield; public string[] Page3ShieldName;
    public Sprite[] UpgradeSubPath1; public string[] UpgradeSubPath1Name;
    public Sprite[] UpgradeSubPath2; public string[] UpgradeSubPath2Name;

    [Header("Sword")]
   
    public Sprite[] Page3Sword; public string[] Page3SwordName;
    public Sprite[] SwordUpgradeSubPath1; public string[] SwordUpgradeSubPath1Name;
    public Sprite[] SwordUpgradeSubPath2; public string[] SwordUpgradeSubPath2Name;

    [Header("Boots")]
    
    public Sprite[] Page3Boots; public string[] Page3BootsName;
    public Sprite[] BootsUpgradeSubPath1; public string[] BootsUpgradeSubPath1Name;
    public Sprite[] BootsUpgradeSubPath2; public string[] BootsUpgradeSubPath2Name;

    [Header("Opening")]
    public GameObject player;
    public float talkDist;
    public GameObject talkObject;
    public float playerDist;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerAbilities = player.GetComponent<PlayerAbilities>();
    }

    // Update is called once per frame
    void Update()
    {
        playerDist = Mathf.Abs(gameObject.transform.position.x - player.transform.position.x);
        if(playerDist < talkDist)
        {
            talkObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                OpenShop();
            }
        }

        else
        {
            talkObject.SetActive(false);
        }

        for(int i = 0; i < ShopPages.Length; i++)
        {
            if(ShopPage < 4)
            {
                if (i != ShopPage)
                {
                    ShopPages[i].SetActive(false);

                }

                else
                {
                    ShopPages[i].SetActive(true);
                }
            }

            else
            {
                ShopPages[3].SetActive(false);
                ShopPages[4].SetActive(true);
            }
           
        }

        IconUi();
        TextUi();
        OtherUI();

    }

    public GameObject ShopMenu;
    
    public void OpenShop()
    {
        ShopMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseShop()
    {
        ShopMenu.SetActive(false);
        ShopPage = 1;
        Time.timeScale = 1;
    } 

    public void OtherUI()
    {
        levelName.text = "Level " + ShopPage;

        //PageNames
        if(playerAbilities.mainPath == 1)
        {
            Page3ShopName.text = "Choose Blade";
            Page4ShopName.text = "Upgrade Blade";
        }

        if (playerAbilities.mainPath == 2)
        {
            Page3ShopName.text = "Choose Boot Type";
            Page4ShopName.text = "Upgrade Boots";
        }

        if (playerAbilities.mainPath == 3)
        {
            Page3ShopName.text = "Choose Engraving";
            Page4ShopName.text = "Upgrade Engraving";
        }

    }

    public void IconUi()
    {
        if (ShopPage == 3)
        {

            if (playerAbilities.mainPath == 3)
            {
                Subpath1Image.sprite = Page3Shield[0];
                Subpath2Image.sprite = Page3Shield[1];
            }

            if (playerAbilities.mainPath == 1)
            {
                Subpath1Image.sprite = Page3Sword[0];
                Subpath2Image.sprite = Page3Sword[1];
            }

            if (playerAbilities.mainPath == 2)
            {
                Subpath1Image.sprite = Page3Boots[0];
                Subpath2Image.sprite = Page3Boots[1];
            }

        }

        if (ShopPage > 3)
        {
            if (playerAbilities.mainPath == 1)
            {
                if (playerAbilities.subPath == 1)
                {
                    UpgradeImage.sprite = SwordUpgradeSubPath1[ShopPage - 4];
                }

                else
                {
                    UpgradeImage.sprite = SwordUpgradeSubPath2[ShopPage - 4];
                }
            }

            if (playerAbilities.mainPath == 2)
            {
                if (playerAbilities.subPath == 1)
                {
                    UpgradeImage.sprite = BootsUpgradeSubPath1[ShopPage - 4];
                }

                else
                {
                    UpgradeImage.sprite = BootsUpgradeSubPath2[ShopPage - 4];
                }
            }

            if (playerAbilities.mainPath == 3)
            {
                if (playerAbilities.subPath == 1)
                {
                    UpgradeImage.sprite = UpgradeSubPath1[ShopPage - 4];
                }

                else
                {
                    UpgradeImage.sprite = UpgradeSubPath2[ShopPage - 4];
                }
            }

        }
    }

    public void TextUi()
    {
        if (ShopPage == 3)
        {

            if (playerAbilities.mainPath == 3)
            {
                Subpath1Text.text = Page3ShieldName[0];
                Subpath2Text.text = Page3ShieldName[1];
            }

            if (playerAbilities.mainPath == 1)
            {
                Subpath1Text.text = Page3SwordName[0];
                Subpath2Text.text = Page3SwordName[1];
            }

            if (playerAbilities.mainPath == 2)
            {
                Subpath1Text.text = Page3BootsName[0];
                Subpath2Text.text = Page3BootsName[1];
            }

        }

        if (ShopPage > 3)
        {
            if (playerAbilities.mainPath == 1)
            {
                if (playerAbilities.subPath == 1)
                {
                    UpgradeText.text = SwordUpgradeSubPath1Name[ShopPage - 4];
                }

                else
                {
                    UpgradeText.text = SwordUpgradeSubPath2Name[ShopPage - 4];
                }
            }

            if (playerAbilities.mainPath == 2)
            {
                if (playerAbilities.subPath == 1)
                {
                    UpgradeText.text = BootsUpgradeSubPath1Name[ShopPage - 4];
                }

                else
                {
                    UpgradeText.text = BootsUpgradeSubPath2Name[ShopPage - 4];
                }
            }

            if (playerAbilities.mainPath == 3)
            {
                if (playerAbilities.subPath == 1)
                {
                    UpgradeText.text = UpgradeSubPath1Name[ShopPage - 4];
                }

                else
                {
                    UpgradeText.text = UpgradeSubPath2Name[ShopPage - 4];
                }
            }

        }
    }

    public void NextPage()
    {
        if(ShopPage < PagesUnlocked)
        {
            ShopPage++;
        }
    }

    public void PreviousPage()
    {
        if(ShopPage > 1)
        {
            ShopPage--;
        }
    }


}
