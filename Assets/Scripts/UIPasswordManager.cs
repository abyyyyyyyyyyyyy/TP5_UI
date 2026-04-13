using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIPasswordManager : MonoBehaviour
{
    public GameObject txtResultadoContra;
    public TextMeshProUGUI txtResultadoContraTexto;
    public TMP_InputField input_Password;


    // Start is called before the first frame update
    void Start()
    {
        txtResultadoContra.SetActive(false);
    }

   public void ValidatePassword(){

     txtResultadoContra.SetActive(true);
     txtResultadoContraTexto.text = input_Password.text;

    }

   }
